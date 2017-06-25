using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetPlacementTool
{
    public partial class NewProjectWindow : Form
    {
        private tool.PlanetPlacementProject pptp { get; set; }
        private string export_path_ {get;set;}

        private string s_save_folder, s_project_name, s_selected_background_image_;
        private string[] arr_planet_files_, arr_trade_route_files_;
        private bool b_path_set_, b_name_set_, b_img_set_, b_route_set_, b_planet_set_ = false;

        public NewProjectWindow()
        {
            InitializeComponent();
        }

        private void btn_add_planet_file__Click(object sender, EventArgs e)
        {
            b_planet_set_ = false;
            btn_update_create();
            npw_planet_list_.Items.Clear();
            DialogResult result = planet_file_importer_.ShowDialog();
            if (result == DialogResult.OK)
            {
                arr_planet_files_ = planet_file_importer_.FileNames;
                foreach (string filePath in arr_planet_files_)
                {
                    npw_planet_list_.Items.Add(filePath);
                }
                b_planet_set_ = true;
            }
            btn_update_create();
        }

        private void btn_create__Click(object sender, EventArgs e)
        {
            //PlanetPlacementProject(string newProjectName, string[] newPlanetPaths, string newBackgroundImagePath)
            pptp = new tool.PlanetPlacementProject(s_project_name, arr_planet_files_, s_selected_background_image_);
            export_path_ = s_save_folder;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_add_background_file__Click(object sender, EventArgs e)
        {
            b_img_set_ = false;
            galaxy_pic_prev_.Image = null;
            btn_update_create();
            OpenFileDialog imagePath = new OpenFileDialog();
            imagePath.Filter = "jpg files (*.jpg)|*.jpg";
            imagePath.FilterIndex = 1;
            imagePath.Multiselect = false;
            if (imagePath.ShowDialog() == DialogResult.OK)
            {
                s_selected_background_image_ = imagePath.FileName;
                Image background = Image.FromFile(s_selected_background_image_);
                galaxy_pic_prev_.Image = background;
                Bitmap finalBack = new Bitmap(galaxy_pic_prev_.Image, galaxy_pic_prev_.Width, galaxy_pic_prev_.Height);
                galaxy_pic_prev_.SizeMode = PictureBoxSizeMode.CenterImage;
                galaxy_pic_prev_.Image = finalBack;
                b_img_set_ = true;
            }
            btn_update_create();
        }

        private void btn_set_project_path__Click(object sender, EventArgs e)
        {
            b_path_set_ = false;
            btn_update_create();
            project_path_display_.Text = null;
            DialogResult result = project_save_folder_.ShowDialog();
            if (result == DialogResult.OK)
            {
                s_save_folder = project_save_folder_.SelectedPath;
                project_path_display_.Text = s_save_folder + "\\" + s_project_name + ".yvaw-ppt";
                project_path_display_.Enabled = false;
                b_path_set_ = true;
            }
            btn_update_create();
        }

        private void btn_add_routes_file__Click(object sender, EventArgs e)
        {
            b_route_set_ = false;
            btn_update_create();
            npw_traderoutes_list_.Items.Clear();
            DialogResult result = route_file_importer_.ShowDialog();
            if (result == DialogResult.OK)
            {
                arr_trade_route_files_ = route_file_importer_.FileNames;
                foreach (string filePath in arr_trade_route_files_)
                {
                    npw_traderoutes_list_.Items.Add(filePath);
                }
                b_route_set_ = true;
            }
            btn_update_create();
        }
        private void project_name__KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }


        private void project_name__TextChanged(object sender, EventArgs e)
        {
            if(project_name_.Text != null)
            {
                s_project_name = project_name_.Text;
                project_path_display_.Text = s_save_folder + "\\" + s_project_name + ".yvaw-ppt";
                b_name_set_ = true;
            }
            else
            {
                b_name_set_ = false;
            }
        }

        private void btn_update_create()
        {
            if (b_path_set_ && b_name_set_ && b_img_set_ && b_planet_set_) // && b_route_set_)
                btn_create_.Enabled = true;
            else
                btn_create_.Enabled = false;
        }
    }
}
