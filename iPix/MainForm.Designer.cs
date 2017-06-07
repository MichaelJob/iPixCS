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
            this.trackBarGreyscale = new System.Windows.Forms.TrackBar();
            this.textBoxSliderValue = new System.Windows.Forms.TextBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreyscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarGreyscale
            // 
            this.trackBarGreyscale.Location = new System.Drawing.Point(97, 12);
            this.trackBarGreyscale.Maximum = 255;
            this.trackBarGreyscale.Name = "trackBarGreyscale";
            this.trackBarGreyscale.Size = new System.Drawing.Size(566, 45);
            this.trackBarGreyscale.TabIndex = 1;
            this.trackBarGreyscale.TickFrequency = 10;
            this.trackBarGreyscale.Value = 125;
            this.trackBarGreyscale.Scroll += new System.EventHandler(this.trackBarGreyscale_Scroll);
            // 
            // textBoxSliderValue
            // 
            this.textBoxSliderValue.Location = new System.Drawing.Point(1, 12);
            this.textBoxSliderValue.Name = "textBoxSliderValue";
            this.textBoxSliderValue.Size = new System.Drawing.Size(90, 20);
            this.textBoxSliderValue.TabIndex = 2;
            this.textBoxSliderValue.TextChanged += new System.EventHandler(this.textBoxSliderValue_TextChanged);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.ErrorImage = null;
            this.pictureBoxMain.Image = global::iPix.Properties.Resources.portugalsmall1;
            this.pictureBoxMain.Location = new System.Drawing.Point(1, 63);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(662, 361);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 424);
            this.Controls.Add(this.textBoxSliderValue);
            this.Controls.Add(this.trackBarGreyscale);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "MainForm";
            this.Text = "iPix";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreyscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.TrackBar trackBarGreyscale;
        private System.Windows.Forms.TextBox textBoxSliderValue;
    }
}

