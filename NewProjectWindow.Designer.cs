namespace PlanetPlacementTool
{
    partial class NewProjectWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectWindow));
            this.npw_lab_001_ = new System.Windows.Forms.Label();
            this.npw_lab_002_ = new System.Windows.Forms.Label();
            this.npw_lab_003_ = new System.Windows.Forms.Label();
            this.npw_lab_004_ = new System.Windows.Forms.Label();
            this.project_name_ = new System.Windows.Forms.TextBox();
            this.project_path_display_ = new System.Windows.Forms.TextBox();
            this.planet_file_importer_ = new System.Windows.Forms.OpenFileDialog();
            this.project_save_folder_ = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_add_planet_file_ = new System.Windows.Forms.Button();
            this.btn_add_routes_file_ = new System.Windows.Forms.Button();
            this.btn_set_project_path_ = new System.Windows.Forms.Button();
            this.btn_create_ = new System.Windows.Forms.Button();
            this.npw_lab_005_ = new System.Windows.Forms.Label();
            this.btn_add_background_file_ = new System.Windows.Forms.Button();
            this.galaxy_pic_prev_ = new System.Windows.Forms.PictureBox();
            this.npw_planet_list_ = new System.Windows.Forms.ListBox();
            this.npw_traderoutes_list_ = new System.Windows.Forms.ListBox();
            this.route_file_importer_ = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.galaxy_pic_prev_)).BeginInit();
            this.SuspendLayout();
            // 
            // npw_lab_001_
            // 
            this.npw_lab_001_.AutoSize = true;
            this.npw_lab_001_.Location = new System.Drawing.Point(14, 14);
            this.npw_lab_001_.Margin = new System.Windows.Forms.Padding(5);
            this.npw_lab_001_.Name = "npw_lab_001_";
            this.npw_lab_001_.Padding = new System.Windows.Forms.Padding(5);
            this.npw_lab_001_.Size = new System.Drawing.Size(82, 23);
            this.npw_lab_001_.TabIndex = 0;
            this.npw_lab_001_.Text = "Project name:";
            // 
            // npw_lab_002_
            // 
            this.npw_lab_002_.AutoSize = true;
            this.npw_lab_002_.Location = new System.Drawing.Point(14, 47);
            this.npw_lab_002_.Margin = new System.Windows.Forms.Padding(5);
            this.npw_lab_002_.Name = "npw_lab_002_";
            this.npw_lab_002_.Padding = new System.Windows.Forms.Padding(5);
            this.npw_lab_002_.Size = new System.Drawing.Size(77, 23);
            this.npw_lab_002_.TabIndex = 1;
            this.npw_lab_002_.Text = "Project path:";
            // 
            // npw_lab_003_
            // 
            this.npw_lab_003_.AutoSize = true;
            this.npw_lab_003_.Location = new System.Drawing.Point(14, 80);
            this.npw_lab_003_.Margin = new System.Windows.Forms.Padding(5);
            this.npw_lab_003_.Name = "npw_lab_003_";
            this.npw_lab_003_.Padding = new System.Windows.Forms.Padding(5);
            this.npw_lab_003_.Size = new System.Drawing.Size(136, 23);
            this.npw_lab_003_.TabIndex = 2;
            this.npw_lab_003_.Text = "Import planets from file(s):";
            // 
            // npw_lab_004_
            // 
            this.npw_lab_004_.AutoSize = true;
            this.npw_lab_004_.Location = new System.Drawing.Point(14, 186);
            this.npw_lab_004_.Margin = new System.Windows.Forms.Padding(5);
            this.npw_lab_004_.Name = "npw_lab_004_";
            this.npw_lab_004_.Padding = new System.Windows.Forms.Padding(5);
            this.npw_lab_004_.Size = new System.Drawing.Size(158, 23);
            this.npw_lab_004_.TabIndex = 5;
            this.npw_lab_004_.Text = "Import trade routes from file(s):";
            // 
            // project_name_
            // 
            this.project_name_.Location = new System.Drawing.Point(104, 16);
            this.project_name_.Name = "project_name_";
            this.project_name_.Size = new System.Drawing.Size(697, 20);
            this.project_name_.TabIndex = 6;
            this.project_name_.TextChanged += new System.EventHandler(this.project_name__TextChanged);
            this.project_name_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.project_name__KeyPress);
            // 
            // project_path_display_
            // 
            this.project_path_display_.Enabled = false;
            this.project_path_display_.Location = new System.Drawing.Point(104, 50);
            this.project_path_display_.Name = "project_path_display_";
            this.project_path_display_.Size = new System.Drawing.Size(697, 20);
            this.project_path_display_.TabIndex = 9;
            // 
            // planet_file_importer_
            // 
            this.planet_file_importer_.DefaultExt = "xml";
            this.planet_file_importer_.FileName = "Planets.xml";
            this.planet_file_importer_.Filter = "xml files (*.xml)|*.xml";
            this.planet_file_importer_.Multiselect = true;
            // 
            // btn_add_planet_file_
            // 
            this.btn_add_planet_file_.Location = new System.Drawing.Point(807, 80);
            this.btn_add_planet_file_.Name = "btn_add_planet_file_";
            this.btn_add_planet_file_.Size = new System.Drawing.Size(75, 23);
            this.btn_add_planet_file_.TabIndex = 10;
            this.btn_add_planet_file_.Text = "Add ...";
            this.btn_add_planet_file_.UseVisualStyleBackColor = true;
            this.btn_add_planet_file_.Click += new System.EventHandler(this.btn_add_planet_file__Click);
            // 
            // btn_add_routes_file_
            // 
            this.btn_add_routes_file_.Enabled = false;
            this.btn_add_routes_file_.Location = new System.Drawing.Point(807, 186);
            this.btn_add_routes_file_.Name = "btn_add_routes_file_";
            this.btn_add_routes_file_.Size = new System.Drawing.Size(75, 23);
            this.btn_add_routes_file_.TabIndex = 11;
            this.btn_add_routes_file_.Text = "Add ...";
            this.btn_add_routes_file_.UseVisualStyleBackColor = true;
            this.btn_add_routes_file_.Click += new System.EventHandler(this.btn_add_routes_file__Click);
            // 
            // btn_set_project_path_
            // 
            this.btn_set_project_path_.Location = new System.Drawing.Point(807, 48);
            this.btn_set_project_path_.Name = "btn_set_project_path_";
            this.btn_set_project_path_.Size = new System.Drawing.Size(74, 23);
            this.btn_set_project_path_.TabIndex = 12;
            this.btn_set_project_path_.Text = "Browse...";
            this.btn_set_project_path_.UseVisualStyleBackColor = true;
            this.btn_set_project_path_.Click += new System.EventHandler(this.btn_set_project_path__Click);
            // 
            // btn_create_
            // 
            this.btn_create_.Enabled = false;
            this.btn_create_.Location = new System.Drawing.Point(7, 418);
            this.btn_create_.Name = "btn_create_";
            this.btn_create_.Size = new System.Drawing.Size(874, 50);
            this.btn_create_.TabIndex = 13;
            this.btn_create_.Text = "Create Project";
            this.btn_create_.UseVisualStyleBackColor = true;
            this.btn_create_.Click += new System.EventHandler(this.btn_create__Click);
            // 
            // npw_lab_005_
            // 
            this.npw_lab_005_.AutoSize = true;
            this.npw_lab_005_.Location = new System.Drawing.Point(14, 287);
            this.npw_lab_005_.Margin = new System.Windows.Forms.Padding(5);
            this.npw_lab_005_.Name = "npw_lab_005_";
            this.npw_lab_005_.Padding = new System.Windows.Forms.Padding(5);
            this.npw_lab_005_.Size = new System.Drawing.Size(142, 23);
            this.npw_lab_005_.TabIndex = 14;
            this.npw_lab_005_.Text = "Import galaxy background:";
            // 
            // btn_add_background_file_
            // 
            this.btn_add_background_file_.Location = new System.Drawing.Point(335, 287);
            this.btn_add_background_file_.Name = "btn_add_background_file_";
            this.btn_add_background_file_.Size = new System.Drawing.Size(75, 23);
            this.btn_add_background_file_.TabIndex = 16;
            this.btn_add_background_file_.Text = "Add ...";
            this.btn_add_background_file_.UseVisualStyleBackColor = true;
            this.btn_add_background_file_.Click += new System.EventHandler(this.btn_add_background_file__Click);
            // 
            // galaxy_pic_prev_
            // 
            this.galaxy_pic_prev_.Location = new System.Drawing.Point(180, 287);
            this.galaxy_pic_prev_.Name = "galaxy_pic_prev_";
            this.galaxy_pic_prev_.Size = new System.Drawing.Size(149, 125);
            this.galaxy_pic_prev_.TabIndex = 15;
            this.galaxy_pic_prev_.TabStop = false;
            // 
            // npw_planet_list_
            // 
            this.npw_planet_list_.FormattingEnabled = true;
            this.npw_planet_list_.HorizontalScrollbar = true;
            this.npw_planet_list_.Location = new System.Drawing.Point(180, 80);
            this.npw_planet_list_.Name = "npw_planet_list_";
            this.npw_planet_list_.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.npw_planet_list_.Size = new System.Drawing.Size(621, 95);
            this.npw_planet_list_.Sorted = true;
            this.npw_planet_list_.TabIndex = 17;
            // 
            // npw_traderoutes_list_
            // 
            this.npw_traderoutes_list_.FormattingEnabled = true;
            this.npw_traderoutes_list_.HorizontalScrollbar = true;
            this.npw_traderoutes_list_.Location = new System.Drawing.Point(180, 186);
            this.npw_traderoutes_list_.Name = "npw_traderoutes_list_";
            this.npw_traderoutes_list_.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.npw_traderoutes_list_.Size = new System.Drawing.Size(621, 95);
            this.npw_traderoutes_list_.Sorted = true;
            this.npw_traderoutes_list_.TabIndex = 18;
            // 
            // route_file_importer_
            // 
            this.route_file_importer_.DefaultExt = "xml";
            this.route_file_importer_.FileName = "Planets.xml";
            this.route_file_importer_.Filter = "xml files (*.xml)|*.xml";
            this.route_file_importer_.Multiselect = true;
            // 
            // NewProjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 478);
            this.ControlBox = false;
            this.Controls.Add(this.npw_traderoutes_list_);
            this.Controls.Add(this.npw_planet_list_);
            this.Controls.Add(this.btn_add_background_file_);
            this.Controls.Add(this.galaxy_pic_prev_);
            this.Controls.Add(this.npw_lab_005_);
            this.Controls.Add(this.btn_create_);
            this.Controls.Add(this.btn_set_project_path_);
            this.Controls.Add(this.btn_add_routes_file_);
            this.Controls.Add(this.btn_add_planet_file_);
            this.Controls.Add(this.project_path_display_);
            this.Controls.Add(this.project_name_);
            this.Controls.Add(this.npw_lab_001_);
            this.Controls.Add(this.npw_lab_004_);
            this.Controls.Add(this.npw_lab_002_);
            this.Controls.Add(this.npw_lab_003_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewProjectWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new project ...";
            ((System.ComponentModel.ISupportInitialize)(this.galaxy_pic_prev_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label npw_lab_001_;
        private System.Windows.Forms.Label npw_lab_002_;
        private System.Windows.Forms.Label npw_lab_003_;
        private System.Windows.Forms.Label npw_lab_004_;
        private System.Windows.Forms.TextBox project_name_;
        private System.Windows.Forms.TextBox project_path_display_;
        private System.Windows.Forms.OpenFileDialog planet_file_importer_;
        private System.Windows.Forms.FolderBrowserDialog project_save_folder_;
        private System.Windows.Forms.Button btn_add_planet_file_;
        private System.Windows.Forms.Button btn_add_routes_file_;
        private System.Windows.Forms.Button btn_set_project_path_;
        private System.Windows.Forms.Button btn_create_;
        private System.Windows.Forms.Label npw_lab_005_;
        private System.Windows.Forms.Button btn_add_background_file_;
        private System.Windows.Forms.PictureBox galaxy_pic_prev_;
        private System.Windows.Forms.ListBox npw_planet_list_;
        private System.Windows.Forms.ListBox npw_traderoutes_list_;
        private System.Windows.Forms.OpenFileDialog route_file_importer_;
    }
}