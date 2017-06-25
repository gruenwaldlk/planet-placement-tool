using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetPlacementTool
{
    public partial class DrawWindow : Form
    {
        public tool.PlanetPlacementProject planet_placement_project_ { get; set; }
        private int grid_width_height_ { get; set; }
        public string project_save_folder_ { get; set; }
        private tool.SaveHandler save_handler_ = new tool.SaveHandler();

        public DrawWindow()
        {
            InitializeComponent();
        }

        private void menu_item_file_new__Click(object sender, EventArgs e)
        {
            using(NewProjectWindow new_project_dialogue_ = new NewProjectWindow())
            {
                DialogResult result = new_project_dialogue_.ShowDialog();
                if (result == DialogResult.OK)
                {
                    planet_placement_project_ = new_project_dialogue_.planet_placement_tool_;
                    project_save_folder_ = new_project_dialogue_.export_path_;
                    main_status_strip_label01_.Text = "Loaded project: " + project_save_folder_ + "\\" + planet_placement_project_.ProjectName + ".yvaw-pptp";
#if DEBUG
                    string output = JsonConvert.SerializeObject(planet_placement_project_, Formatting.Indented);
                    Console.Write(output);
#endif
                    create_resources();
                    save_handler_.SaveToFile(project_save_folder_, planet_placement_project_.ProjectName, JsonConvert.SerializeObject(planet_placement_project_, Formatting.Indented));
                    main_canvas_.BackgroundImage = Image.FromFile(planet_placement_project_.BackgroundImagePath);
                }
            }
        }

        private void menu_item_file_open__Click(object sender, EventArgs e)
        {

        }

        private void menu_item_file_close__Click(object sender, EventArgs e)
        {

        }

        private void menu_item_file_save__Click(object sender, EventArgs e)
        {

        }

        private void menu_item_export_planets__Click(object sender, EventArgs e)
        {

        }
        private void create_resources()
        {
            System.IO.Directory.CreateDirectory(project_save_folder_ + "\\" + planet_placement_project_.ProjectName);
            create_background(planet_placement_project_.BackgroundImagePath);
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
            grid_width_height_ = bitmap.Width;
            Graphics canvas = Graphics.FromImage(bitmap);
            SolidBrush brush = new SolidBrush(Color.Black);
            canvas.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
            canvas.DrawImage(background, upperLeft);
            canvas.Save();
            bitmap.Save(@project_save_folder_ + "\\" + planet_placement_project_.ProjectName + "\\_background_canvas.png");
            planet_placement_project_.BackgroundImagePath = project_save_folder_ + "\\" + planet_placement_project_.ProjectName + "\\_background_canvas.png";
            canvas.Dispose();
        }
    }
}
