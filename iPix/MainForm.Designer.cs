namespace iPix
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxSliderValue = new System.Windows.Forms.TextBox();
            this.trackBarGreyscale = new System.Windows.Forms.TrackBar();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreyscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSliderValue);
            this.splitContainer1.Panel1.Controls.Add(this.trackBarGreyscale);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxMain);
            this.splitContainer1.Size = new System.Drawing.Size(584, 441);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 3;
            // 
            // textBoxSliderValue
            // 
            this.textBoxSliderValue.Location = new System.Drawing.Point(0, 0);
            this.textBoxSliderValue.Name = "textBoxSliderValue";
            this.textBoxSliderValue.Size = new System.Drawing.Size(54, 20);
            this.textBoxSliderValue.TabIndex = 4;
            this.textBoxSliderValue.TextChanged += new System.EventHandler(this.textBoxSliderValue_TextChanged);
            // 
            // trackBarGreyscale
            // 
            this.trackBarGreyscale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarGreyscale.Location = new System.Drawing.Point(0, 30);
            this.trackBarGreyscale.Maximum = 255;
            this.trackBarGreyscale.Name = "trackBarGreyscale";
            this.trackBarGreyscale.Size = new System.Drawing.Size(584, 45);
            this.trackBarGreyscale.TabIndex = 3;
            this.trackBarGreyscale.TickFrequency = 10;
            this.trackBarGreyscale.Scroll += new System.EventHandler(this.trackBarGreyscale_Scroll);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.ErrorImage = null;
            this.pictureBoxMain.Image = global::iPix.Properties.Resources.portugalsmall1;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBoxMain.Size = new System.Drawing.Size(584, 362);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "iPix";
            this.TopMost = true;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreyscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxSliderValue;
        private System.Windows.Forms.TrackBar trackBarGreyscale;
        private System.Windows.Forms.PictureBox pictureBoxMain;
    }
}

