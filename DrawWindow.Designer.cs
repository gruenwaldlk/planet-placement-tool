namespace PlanetPlacementTool
{
    partial class DrawWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawWindow));
            this.main_tsc_ = new System.Windows.Forms.ToolStripContainer();
            this.main_status_strip_ = new System.Windows.Forms.StatusStrip();
            this.main_status_strip_label01_ = new System.Windows.Forms.ToolStripStatusLabel();
            this.main_status_strip_label02_ = new System.Windows.Forms.ToolStripStatusLabel();
            this.main_status_strip_progressbar_ = new System.Windows.Forms.ToolStripProgressBar();
            this.main_split_container_ = new System.Windows.Forms.SplitContainer();
            this.planet_display_ = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.update_scale_ = new System.Windows.Forms.Button();
            this.Project_Scale_ = new System.Windows.Forms.NumericUpDown();
            this.main_canvas_ = new System.Windows.Forms.Panel();
            this.canvas_draw_space_ = new System.Windows.Forms.PictureBox();
            this.main_planet_tools_ = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.planet_tools_select_move_ = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_item_file_ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_file_new_ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_item_file_open_ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_item_file_save_ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_export_ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_export_planets_ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_export_traderoutes_ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_item_export_all_ = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu_strip_ = new System.Windows.Forms.MenuStrip();
            this.tool_tip_ = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.main_tsc_.BottomToolStripPanel.SuspendLayout();
            this.main_tsc_.ContentPanel.SuspendLayout();
            this.main_tsc_.TopToolStripPanel.SuspendLayout();
            this.main_tsc_.SuspendLayout();
            this.main_status_strip_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_split_container_)).BeginInit();
            this.main_split_container_.Panel1.SuspendLayout();
            this.main_split_container_.Panel2.SuspendLayout();
            this.main_split_container_.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Project_Scale_)).BeginInit();
            this.main_canvas_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas_draw_space_)).BeginInit();
            this.main_planet_tools_.SuspendLayout();
            this.main_menu_strip_.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tsc_
            // 
            // 
            // main_tsc_.BottomToolStripPanel
            // 
            this.main_tsc_.BottomToolStripPanel.Controls.Add(this.main_status_strip_);
            // 
            // main_tsc_.ContentPanel
            // 
            this.main_tsc_.ContentPanel.Controls.Add(this.main_split_container_);
            this.main_tsc_.ContentPanel.Size = new System.Drawing.Size(784, 490);
            this.main_tsc_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tsc_.Location = new System.Drawing.Point(0, 24);
            this.main_tsc_.Name = "main_tsc_";
            this.main_tsc_.Size = new System.Drawing.Size(784, 537);
            this.main_tsc_.TabIndex = 2;
            this.main_tsc_.Text = "toolStripContainer1";
            // 
            // main_tsc_.TopToolStripPanel
            // 
            this.main_tsc_.TopToolStripPanel.Controls.Add(this.main_planet_tools_);
            // 
            // main_status_strip_
            // 
            this.main_status_strip_.Dock = System.Windows.Forms.DockStyle.None;
            this.main_status_strip_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.main_status_strip_label01_,
            this.main_status_strip_label02_,
            this.main_status_strip_progressbar_});
            this.main_status_strip_.Location = new System.Drawing.Point(0, 0);
            this.main_status_strip_.Name = "main_status_strip_";
            this.main_status_strip_.Size = new System.Drawing.Size(784, 22);
            this.main_status_strip_.TabIndex = 0;
            // 
            // main_status_strip_label01_
            // 
            this.main_status_strip_label01_.Name = "main_status_strip_label01_";
            this.main_status_strip_label01_.Size = new System.Drawing.Size(127, 17);
            this.main_status_strip_label01_.Text = "Loaded project: [none]";
            // 
            // main_status_strip_label02_
            // 
            this.main_status_strip_label02_.Name = "main_status_strip_label02_";
            this.main_status_strip_label02_.Size = new System.Drawing.Size(0, 17);
            // 
            // main_status_strip_progressbar_
            // 
            this.main_status_strip_progressbar_.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.main_status_strip_progressbar_.Enabled = false;
            this.main_status_strip_progressbar_.MarqueeAnimationSpeed = 10;
            this.main_status_strip_progressbar_.Name = "main_status_strip_progressbar_";
            this.main_status_strip_progressbar_.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.main_status_strip_progressbar_.Size = new System.Drawing.Size(120, 16);
            this.main_status_strip_progressbar_.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.main_status_strip_progressbar_.Visible = false;
            // 
            // main_split_container_
            // 
            this.main_split_container_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_split_container_.Location = new System.Drawing.Point(0, 0);
            this.main_split_container_.Name = "main_split_container_";
            // 
            // main_split_container_.Panel1
            // 
            this.main_split_container_.Panel1.Controls.Add(this.planet_display_);
            this.main_split_container_.Panel1.Controls.Add(this.groupBox1);
            // 
            // main_split_container_.Panel2
            // 
            this.main_split_container_.Panel2.AutoScroll = true;
            this.main_split_container_.Panel2.Controls.Add(this.main_canvas_);
            this.main_split_container_.Size = new System.Drawing.Size(784, 490);
            this.main_split_container_.SplitterDistance = 261;
            this.main_split_container_.TabIndex = 1;
            // 
            // planet_display_
            // 
            this.planet_display_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planet_display_.FormattingEnabled = true;
            this.planet_display_.Location = new System.Drawing.Point(0, 0);
            this.planet_display_.Name = "planet_display_";
            this.planet_display_.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.planet_display_.Size = new System.Drawing.Size(261, 426);
            this.planet_display_.Sorted = true;
            this.planet_display_.TabIndex = 0;
            this.tool_tip_.SetToolTip(this.planet_display_, "List of imported planets.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.update_scale_);
            this.groupBox1.Controls.Add(this.Project_Scale_);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map Scale Setting";
            // 
            // update_scale_
            // 
            this.update_scale_.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.update_scale_.Enabled = false;
            this.update_scale_.Location = new System.Drawing.Point(3, 38);
            this.update_scale_.Name = "update_scale_";
            this.update_scale_.Size = new System.Drawing.Size(255, 23);
            this.update_scale_.TabIndex = 1;
            this.update_scale_.Text = "Recalculate Galactic Coordinates";
            this.tool_tip_.SetToolTip(this.update_scale_, "Recalculates the planet positions based on the current radius.");
            this.update_scale_.UseVisualStyleBackColor = true;
            this.update_scale_.Click += new System.EventHandler(this.update_scale__Click);
            // 
            // Project_Scale_
            // 
            this.Project_Scale_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Project_Scale_.Location = new System.Drawing.Point(3, 16);
            this.Project_Scale_.Name = "Project_Scale_";
            this.Project_Scale_.Size = new System.Drawing.Size(255, 20);
            this.Project_Scale_.TabIndex = 0;
            this.Project_Scale_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tool_tip_.SetToolTip(this.Project_Scale_, "Set the galaxy radius.");
            this.Project_Scale_.ValueChanged += new System.EventHandler(this.Project_Scale__ValueChanged);
            // 
            // main_canvas_
            // 
            this.main_canvas_.AutoScroll = true;
            this.main_canvas_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.main_canvas_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_canvas_.Controls.Add(this.canvas_draw_space_);
            this.main_canvas_.Location = new System.Drawing.Point(0, 0);
            this.main_canvas_.Name = "main_canvas_";
            this.main_canvas_.Size = new System.Drawing.Size(519, 490);
            this.main_canvas_.TabIndex = 0;
            this.main_canvas_.Paint += new System.Windows.Forms.PaintEventHandler(this.main_canvas__Paint);
            this.main_canvas_.Resize += new System.EventHandler(this.main_canvas__Resize);
            // 
            // canvas_draw_space_
            // 
            this.canvas_draw_space_.BackColor = System.Drawing.Color.Transparent;
            this.canvas_draw_space_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.canvas_draw_space_.Cursor = System.Windows.Forms.Cursors.Default;
            this.canvas_draw_space_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas_draw_space_.Location = new System.Drawing.Point(0, 0);
            this.canvas_draw_space_.Name = "canvas_draw_space_";
            this.canvas_draw_space_.Size = new System.Drawing.Size(517, 488);
            this.canvas_draw_space_.TabIndex = 0;
            this.canvas_draw_space_.TabStop = false;
            // 
            // main_planet_tools_
            // 
            this.main_planet_tools_.Dock = System.Windows.Forms.DockStyle.None;
            this.main_planet_tools_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.planet_tools_select_move_,
            this.toolStripSeparator5});
            this.main_planet_tools_.Location = new System.Drawing.Point(3, 0);
            this.main_planet_tools_.Name = "main_planet_tools_";
            this.main_planet_tools_.Size = new System.Drawing.Size(138, 25);
            this.main_planet_tools_.TabIndex = 0;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // planet_tools_select_move_
            // 
            this.planet_tools_select_move_.CheckOnClick = true;
            this.planet_tools_select_move_.Image = ((System.Drawing.Image)(resources.GetObject("planet_tools_select_move_.Image")));
            this.planet_tools_select_move_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.planet_tools_select_move_.Name = "planet_tools_select_move_";
            this.planet_tools_select_move_.Size = new System.Drawing.Size(114, 22);
            this.planet_tools_select_move_.Text = "Select and Move";
            this.planet_tools_select_move_.ToolTipText = "Select this to move planets.";
            this.planet_tools_select_move_.CheckedChanged += new System.EventHandler(this.planet_tools_select_move__CheckedChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // menu_item_file_
            // 
            this.menu_item_file_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_file_new_,
            this.toolStripSeparator2,
            this.menu_item_file_open_,
            this.toolStripSeparator1,
            this.menu_item_file_save_});
            this.menu_item_file_.Name = "menu_item_file_";
            this.menu_item_file_.Size = new System.Drawing.Size(37, 20);
            this.menu_item_file_.Text = "File";
            // 
            // menu_item_file_new_
            // 
            this.menu_item_file_new_.Name = "menu_item_file_new_";
            this.menu_item_file_new_.Size = new System.Drawing.Size(107, 22);
            this.menu_item_file_new_.Text = "New...";
            this.menu_item_file_new_.ToolTipText = "Create a new project...";
            this.menu_item_file_new_.Click += new System.EventHandler(this.menu_item_file_new__Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // menu_item_file_open_
            // 
            this.menu_item_file_open_.Name = "menu_item_file_open_";
            this.menu_item_file_open_.Size = new System.Drawing.Size(107, 22);
            this.menu_item_file_open_.Text = "Open";
            this.menu_item_file_open_.ToolTipText = "Open an existing project...";
            this.menu_item_file_open_.Click += new System.EventHandler(this.menu_item_file_open__Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // menu_item_file_save_
            // 
            this.menu_item_file_save_.Name = "menu_item_file_save_";
            this.menu_item_file_save_.Size = new System.Drawing.Size(107, 22);
            this.menu_item_file_save_.Text = "Save";
            this.menu_item_file_save_.ToolTipText = "Save the current project...";
            this.menu_item_file_save_.Click += new System.EventHandler(this.menu_item_file_save__Click);
            // 
            // menu_item_export_
            // 
            this.menu_item_export_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_export_planets_,
            this.menu_item_export_traderoutes_,
            this.toolStripSeparator3,
            this.menu_item_export_all_});
            this.menu_item_export_.Name = "menu_item_export_";
            this.menu_item_export_.Size = new System.Drawing.Size(52, 20);
            this.menu_item_export_.Text = "Export";
            this.menu_item_export_.ToolTipText = "Export the planet positions to the xml files.";
            // 
            // menu_item_export_planets_
            // 
            this.menu_item_export_planets_.Name = "menu_item_export_planets_";
            this.menu_item_export_planets_.Size = new System.Drawing.Size(136, 22);
            this.menu_item_export_planets_.Text = "Planets";
            this.menu_item_export_planets_.ToolTipText = "Export your planets to xml.";
            this.menu_item_export_planets_.Click += new System.EventHandler(this.menu_item_export_planets__Click);
            // 
            // menu_item_export_traderoutes_
            // 
            this.menu_item_export_traderoutes_.Enabled = false;
            this.menu_item_export_traderoutes_.Name = "menu_item_export_traderoutes_";
            this.menu_item_export_traderoutes_.Size = new System.Drawing.Size(136, 22);
            this.menu_item_export_traderoutes_.Text = "Traderoutes";
            this.menu_item_export_traderoutes_.ToolTipText = "Export your traderoutes to xml.";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // menu_item_export_all_
            // 
            this.menu_item_export_all_.Enabled = false;
            this.menu_item_export_all_.Name = "menu_item_export_all_";
            this.menu_item_export_all_.Size = new System.Drawing.Size(136, 22);
            this.menu_item_export_all_.Text = "All";
            this.menu_item_export_all_.ToolTipText = "Export your planets and traderoutes to xml.";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.ToolTipText = "Help.";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // main_menu_strip_
            // 
            this.main_menu_strip_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_file_,
            this.menu_item_export_,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1});
            this.main_menu_strip_.Location = new System.Drawing.Point(0, 0);
            this.main_menu_strip_.Name = "main_menu_strip_";
            this.main_menu_strip_.Size = new System.Drawing.Size(784, 24);
            this.main_menu_strip_.TabIndex = 0;
            this.main_menu_strip_.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // DrawWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.main_tsc_);
            this.Controls.Add(this.main_menu_strip_);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.main_menu_strip_;
            this.Name = "DrawWindow";
            this.Text = "EaW-FoC: Planet Placement Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrawWindow_FormClosing);
            this.main_tsc_.BottomToolStripPanel.ResumeLayout(false);
            this.main_tsc_.BottomToolStripPanel.PerformLayout();
            this.main_tsc_.ContentPanel.ResumeLayout(false);
            this.main_tsc_.TopToolStripPanel.ResumeLayout(false);
            this.main_tsc_.TopToolStripPanel.PerformLayout();
            this.main_tsc_.ResumeLayout(false);
            this.main_tsc_.PerformLayout();
            this.main_status_strip_.ResumeLayout(false);
            this.main_status_strip_.PerformLayout();
            this.main_split_container_.Panel1.ResumeLayout(false);
            this.main_split_container_.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_split_container_)).EndInit();
            this.main_split_container_.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Project_Scale_)).EndInit();
            this.main_canvas_.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas_draw_space_)).EndInit();
            this.main_planet_tools_.ResumeLayout(false);
            this.main_planet_tools_.PerformLayout();
            this.main_menu_strip_.ResumeLayout(false);
            this.main_menu_strip_.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer main_tsc_;
        private System.Windows.Forms.ToolStripMenuItem menu_item_file_;
        private System.Windows.Forms.ToolStripMenuItem menu_item_file_new_;
        private System.Windows.Forms.ToolStripMenuItem menu_item_file_open_;
        private System.Windows.Forms.ToolStripMenuItem menu_item_export_;
        private System.Windows.Forms.ToolStripMenuItem menu_item_export_planets_;
        private System.Windows.Forms.ToolStripMenuItem menu_item_export_traderoutes_;
        private System.Windows.Forms.ToolStripMenuItem menu_item_export_all_;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_item_file_save_;
        private System.Windows.Forms.MenuStrip main_menu_strip_;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel main_canvas_;
        private System.Windows.Forms.StatusStrip main_status_strip_;
        private System.Windows.Forms.ToolStripStatusLabel main_status_strip_label01_;
        private System.Windows.Forms.ToolStrip main_planet_tools_;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton planet_tools_select_move_;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.SplitContainer main_split_container_;
        private System.Windows.Forms.ToolStripStatusLabel main_status_strip_label02_;
        private System.Windows.Forms.ToolStripProgressBar main_status_strip_progressbar_;
        private System.Windows.Forms.ListBox planet_display_;
        private System.Windows.Forms.PictureBox canvas_draw_space_;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Project_Scale_;
        private System.Windows.Forms.Button update_scale_;
        private System.Windows.Forms.ToolTip tool_tip_;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

