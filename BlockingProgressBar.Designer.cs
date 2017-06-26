namespace PlanetPlacementTool
{
    partial class BlockingProgressBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockingProgressBar));
            this.progress_bar_ = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progress_bar_
            // 
            this.progress_bar_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress_bar_.Location = new System.Drawing.Point(0, 0);
            this.progress_bar_.Margin = new System.Windows.Forms.Padding(10);
            this.progress_bar_.MarqueeAnimationSpeed = 15;
            this.progress_bar_.Name = "progress_bar_";
            this.progress_bar_.Size = new System.Drawing.Size(550, 40);
            this.progress_bar_.Step = 30;
            this.progress_bar_.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress_bar_.TabIndex = 0;
            // 
            // BlockingProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 40);
            this.ControlBox = false;
            this.Controls.Add(this.progress_bar_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BlockingProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parsing ...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress_bar_;
    }
}