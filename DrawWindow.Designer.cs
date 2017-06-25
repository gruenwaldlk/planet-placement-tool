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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawWindow));
            this.main_tsc_ = new System.Windows.Forms.ToolStripContainer();
            this.main_status_strip_ = new System.Windows.Forms.StatusStrip();
            this.main_status_strip_label01_ = new System.Windows.Forms.ToolStripStatusLabel();
            this.main_canvas_ = new System.Windows.Forms.Panel();
            this.main_planet_tools_ = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_item_file_ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_file_new_ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_item_file_open_ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_file_close_ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_item_file_save_ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_export_ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_export_planets_ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_export_traderoutes_ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_item_export_all_ = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu_strip_ = new System.Windows.Forms.MenuStrip();
            this.main_tsc_.BottomToolStripPanel.SuspendLayout();
            this.main_tsc_.ContentPanel.SuspendLayout();
            this.main_tsc_.TopToolStripPanel.SuspendLayout();
            this.main_tsc_.SuspendLayout();
            this.main_status_strip_.SuspendLayout();
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
            this.main_tsc_.ContentPanel.Controls.Add(this.main_canvas_);
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
            this.main_status_strip_label01_});
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
            // main_canvas_
            // 
            this.main_canvas_.AutoScroll = true;
            this.main_canvas_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_canvas_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.main_canvas_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_canvas_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_canvas_.Location = new System.Drawing.Point(0, 0);
            this.main_canvas_.Name = "main_canvas_";
            this.main_canvas_.Size = new System.Drawing.Size(784, 490);
            this.main_canvas_.TabIndex = 0;
            // 
            // main_planet_tools_
            // 
            this.main_planet_tools_.Dock = System.Windows.Forms.DockStyle.None;
            this.main_planet_tools_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator5});
            this.main_planet_tools_.Location = new System.Drawing.Point(3, 0);
            this.main_planet_tools_.Name = "main_planet_tools_";
            this.main_planet_tools_.Size = new System.Drawing.Size(223, 25);
            this.main_planet_tools_.TabIndex = 0;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton1.Text = "Add Planet";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton2.Text = "Select and Move";
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
            this.menu_item_file_close_,
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
            // menu_item_file_close_
            // 
            this.menu_item_file_close_.Name = "menu_item_file_close_";
            this.menu_item_file_close_.Size = new System.Drawing.Size(107, 22);
            this.menu_item_file_close_.Text = "Close";
            this.menu_item_file_close_.ToolTipText = "Close the current project...";
            this.menu_item_file_close_.Click += new System.EventHandler(this.menu_item_file_close__Click);
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
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.ToolTipText = "Help.";
            // 
            // main_menu_strip_
            // 
            this.main_menu_strip_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_file_,
            this.menu_item_export_,
            this.helpToolStripMenuItem});
            this.main_menu_strip_.Location = new System.Drawing.Point(0, 0);
            this.main_menu_strip_.Name = "main_menu_strip_";
            this.main_menu_strip_.Size = new System.Drawing.Size(784, 24);
            this.main_menu_strip_.TabIndex = 0;
            this.main_menu_strip_.Text = "menuStrip1";
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
            this.main_tsc_.BottomToolStripPanel.ResumeLayout(false);
            this.main_tsc_.BottomToolStripPanel.PerformLayout();
            this.main_tsc_.ContentPanel.ResumeLayout(false);
            this.main_tsc_.TopToolStripPanel.ResumeLayout(false);
            this.main_tsc_.TopToolStripPanel.PerformLayout();
            this.main_tsc_.ResumeLayout(false);
            this.main_tsc_.PerformLayout();
            this.main_status_strip_.ResumeLayout(false);
            this.main_status_strip_.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem menu_item_file_close_;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

