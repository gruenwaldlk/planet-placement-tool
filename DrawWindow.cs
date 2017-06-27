using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetPlacementTool
{
    public partial class DrawWindow : Form
    {
        public tool.PlanetPlacementProject planet_placement_project_ { get; set; }
        public string project_save_folder_ { get; set; }
        private tool.SaveHandler save_handler_ = new tool.SaveHandler();
        private Bitmap buffer_grid_;
        public DrawWindow()
        {
            InitializeComponent();
            main_canvas__Resize(this, null);
#if DEBUG

#endif
        }

        private void menu_item_file_new__Click(object sender, EventArgs e)
        {
            bool created = false;
            using(NewProjectWindow new_project_dialogue_ = new NewProjectWindow())
            {
                DialogResult result = new_project_dialogue_.ShowDialog();
                if (result == DialogResult.OK)
                {
                    planet_placement_project_ = new_project_dialogue_.planet_placement_tool_;
                    project_save_folder_ = new_project_dialogue_.export_path_;
                    created = true;
                }
            }
            if (created)
            {
                Enabled = false;
                main_status_strip_label01_.Text = "Creating project: " + project_save_folder_ + "\\" + planet_placement_project_.ProjectName + ".yvaw-pptp";
                tool.Global.PROJECT_SCALE_ = planet_placement_project_.ProjScaleSetting;
                create_resources();
                set_canvas_background();
                ThreadedParseFiles();
            }
        }

        private void menu_item_file_open__Click(object sender, EventArgs e)
        {
            string loadFile = "";
            bool loaded = false;
            using(OpenFileDialog chooseProject = new OpenFileDialog())
            {
                chooseProject.Filter = "planet placement files (*.yvaw-pptp)|*.yvaw-pptp";
                chooseProject.FilterIndex = 1;
                chooseProject.Multiselect = false;
                DialogResult result = chooseProject.ShowDialog();
                if (result == DialogResult.OK)
                {
                    loadFile = chooseProject.FileName;
                    project_save_folder_ = Path.GetDirectoryName(chooseProject.FileName);
                    loaded = true;
                }
            }
            if (loaded)
            {
                ThreadedLoadFromFile(loadFile);
            }
        }

        private void menu_item_file_close__Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void menu_item_file_save__Click(object sender, EventArgs e)
        {
            Save();
        }

        private void menu_item_export_planets__Click(object sender, EventArgs e)
        {

        }
        private void create_resources()
        {
            System.IO.Directory.CreateDirectory(project_save_folder_ + "\\" + planet_placement_project_.ProjectName);
            create_background(planet_placement_project_.BackgroundImagePath);
        }
        private void set_canvas_background()
        {
            main_canvas_.BackgroundImage = Image.FromFile(planet_placement_project_.BackgroundImagePath);
            main_canvas_.Width = main_canvas_.BackgroundImage.Width;
            main_canvas_.Height = main_canvas_.BackgroundImage.Height;
            draw_grid();
        }
        private void create_background(string background_path)
        {
            Image background = Image.FromFile(background_path);
            Bitmap bitmap;
            Point upperLeft;
            if (background.Width >= background.Height)
            {
                bitmap = new Bitmap(background.Width, background.Width);
                int x;
                x = (background.Width - background.Height) / 2;
                upperLeft = new Point(0, x);
            }
            else
            {
                bitmap = new Bitmap(background.Height, background.Height);
                int x;
                x = (background.Height - background.Width) / 2;
                upperLeft = new Point(x, 0);
            }
            Graphics canvas = Graphics.FromImage(bitmap);
            SolidBrush brush = new SolidBrush(Color.Black);
            canvas.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
            canvas.DrawImage(background, upperLeft);
            canvas.Save();
            bitmap.Save(@project_save_folder_ + "\\" + planet_placement_project_.ProjectName + "\\_background_canvas.png");
            planet_placement_project_.BackgroundImagePath = project_save_folder_ + "\\" + planet_placement_project_.ProjectName + "\\_background_canvas.png";
            canvas.Dispose();
            brush.Dispose();
            background.Dispose();
        }
        private void draw_grid()
        {
            using (Graphics bufferGrph = Graphics.FromImage(buffer_grid_))
            {
                Pen grid_pen = new Pen(Color.FromArgb(125,255,255,255));
                // width == height!
                int width = main_canvas_.Width;
                int middle = width / 2;
                // Grid size 10 px.
                int grid_size = 20;
                // Draw y from middle to end:
                for (int y = middle; y < width; y += grid_size)
                {
                    bufferGrph.DrawLine(grid_pen, 0, y, width, y);
                }
                for (int y = middle-grid_size; y > 0; y -= grid_size)
                {
                    bufferGrph.DrawLine(grid_pen, 0, y, width, y);
                }
                for (int x = middle; x < width; x += grid_size)
                {
                    bufferGrph.DrawLine(grid_pen, x, 0, x, width);
                }
                for (int x = middle-grid_size; x > 0; x -= grid_size)
                {
                    bufferGrph.DrawLine(grid_pen, x, 0, x, width);
                }
                grid_pen.Dispose();
            }

            // Invalidate the panel. This will lead to a call of 'panel1_Paint'
            main_canvas_.Invalidate();
        }

        private void main_canvas__Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(buffer_grid_, Point.Empty);
        }

        private void main_canvas__Resize(object sender, EventArgs e)
        {
            if (buffer_grid_ == null ||
                buffer_grid_.Width < main_canvas_.Width ||
                buffer_grid_.Height < main_canvas_.Height)
            {
                Bitmap newBuffer = new Bitmap(main_canvas_.Width, main_canvas_.Height);
                buffer_grid_ = newBuffer;
            }
            tool.Global.CANVAS_SIZE_ = main_canvas_.Width;
        }
        private void ThreadedParseFiles()
        {
            Action exec = ParseXMLFiles;
            BlockingProgressBar bpb = new BlockingProgressBar();
            BackgroundWorker parser = new BackgroundWorker();
            parser.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                exec.Invoke();
            };
            parser.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) => {
                if (bpb != null && bpb.Visible)
                {
                    Populate_Planet_Display();
                    DrawAllPlanets();
                    Save();
                    main_status_strip_label01_.Text = "Loaded project: " + project_save_folder_ + "\\" + planet_placement_project_.ProjectName + ".yvaw-pptp";
                    Enabled = true;
                    bpb.Close();
                    bpb.Dispose();
                }
            };
            this.Enabled = false;
            bpb.StartPosition = FormStartPosition.Manual;
            bpb.Location = new Point(Location.X + (Width - bpb.Width) / 2, Location.Y + (Height - bpb.Height) / 2);
            bpb.Show(this);
            parser.RunWorkerAsync();
        }
        private void ParseXMLFiles()
        {
            tool.XMLHandler XMLWorker = new tool.XMLHandler();
            planet_placement_project_.ProjActivePlanets = XMLWorker.DeserializeXMLFilesPlanets(planet_placement_project_);
        }
        private void Populate_Planet_Display()
        {
            if (planet_placement_project_ != null)
            {
                planet_display_.Items.Clear();
                foreach (tool.Planet planet in planet_placement_project_.ProjActivePlanets)
                {
                    planet_display_.Items.Add(planet.Name);
                }
            }
        }
        private void Save()
        {
            if (planet_placement_project_ != null)
            {
                ThreadedSaveToFile();
            }
#if DEBUG
            else
            {
                Console.Write(@"Nothing to save, no project loaded.");
            }
#endif
        }

        public void SaveToFile()
        {
            save_handler_.SaveToFile(project_save_folder_, planet_placement_project_.ProjectName, JsonConvert.SerializeObject(planet_placement_project_, Formatting.Indented));
        }

        private void ThreadedSaveToFile()
        {
            Action exec = SaveToFile;
            BackgroundWorker saveHandler = new BackgroundWorker();
            saveHandler.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                exec.Invoke();
            };
            saveHandler.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) => {
                    main_status_strip_label02_.Text = "";
            };
            main_status_strip_label02_.Text = "Saving ...";
            saveHandler.RunWorkerAsync();
        }

        private void LoadFromFile(string fileToLoad)
        {
            string fileContent = File.ReadAllText(fileToLoad);
            planet_placement_project_ = JsonConvert.DeserializeObject<tool.PlanetPlacementProject>(fileContent);
            tool.Global.PROJECT_SCALE_ = planet_placement_project_.ProjScaleSetting;
        }

        private void ThreadedLoadFromFile(string LoadFile)
        {
            Action<string> exec = LoadFromFile;
            BackgroundWorker loadHandler = new BackgroundWorker();
            loadHandler.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                exec.Invoke(LoadFile);
            };
            loadHandler.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) => {
                Enabled = false;
                set_canvas_background();
                Populate_Planet_Display();
                DrawAllPlanets();
                Enabled = true;
                if (main_status_strip_progressbar_ != null)
                {
                    main_status_strip_progressbar_.Visible = false;
                    main_status_strip_progressbar_.Enabled = false;
                }
                main_status_strip_label01_.Text = "Loaded project: " + LoadFile;
            };
            main_status_strip_label01_.Text = "Loading project: " + LoadFile;
            canvas_draw_space_.Controls.Clear();
            main_status_strip_progressbar_.Visible = true;
            main_status_strip_progressbar_.Enabled = true;
            loadHandler.RunWorkerAsync();
        }

        private void DrawPlanet(tool.Planet newPlanet)
        {
            PictureBox pb = newPlanet.Draw();
#if DEBUG
            Console.Write("{0}:\n", newPlanet.Name);
#endif
            canvas_draw_space_.Controls.Add(pb);
        }
        private void DrawAllPlanets()
        {
            if (planet_placement_project_ != null)
            {
                foreach(tool.Planet lp in planet_placement_project_.ProjActivePlanets)
                {
                    DrawPlanet(lp);
                }
            }
        }

        private void planet_tools_add__Click(object sender, EventArgs e)
        {
            tool.Global.APP_STATE_ = tool.ToolState.ADD_REMOVE_;
        }

        private void planet_tools_select_move__Click(object sender, EventArgs e)
        {
            tool.Global.APP_STATE_ = tool.ToolState.SELECT_MOVE_;
        }

    }
}
