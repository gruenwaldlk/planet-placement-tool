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
        public DrawWindow()
        {
            InitializeComponent();
        }

        private void menu_item_file_new__Click(object sender, EventArgs e)
        {
            NewProjectWindow new_project_dialogue_ = new NewProjectWindow();
            new_project_dialogue_.ShowDialog();
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
    }
}
