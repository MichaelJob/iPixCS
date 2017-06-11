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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBoxInvert = new System.Windows.Forms.CheckBox();
            this.textBoxSliderValue = new System.Windows.Forms.TextBox();
            this.trackBarGreyscale = new System.Windows.Forms.TrackBar();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.colorDialogMarkColor = new System.Windows.Forms.ColorDialog();
            this.btnSelectMarkColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectMarkColor);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxInvert);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSliderValue);
            this.splitContainer1.Panel1.Controls.Add(this.trackBarGreyscale);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxMain);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(584, 441);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 3;
            // 
            // checkBoxInvert
            // 
            this.checkBoxInvert.AutoSize = true;
            this.checkBoxInvert.Location = new System.Drawing.Point(173, 7);
            this.checkBoxInvert.Name = "checkBoxInvert";
            this.checkBoxInvert.Size = new System.Drawing.Size(116, 17);
            this.checkBoxInvert.TabIndex = 5;
            this.checkBoxInvert.Text = "mark brighter pixels";
            this.checkBoxInvert.UseVisualStyleBackColor = true;
            this.checkBoxInvert.CheckedChanged += new System.EventHandler(this.checkBoxInvert_CheckedChanged);
            // 
            // textBoxSliderValue
            // 
            this.textBoxSliderValue.Location = new System.Drawing.Point(98, 5);
            this.textBoxSliderValue.Name = "textBoxSliderValue";
            this.textBoxSliderValue.Size = new System.Drawing.Size(54, 20);
            this.textBoxSliderValue.TabIndex = 4;
            this.textBoxSliderValue.TextChanged += new System.EventHandler(this.textBoxSliderValue_TextChanged);
            // 
            // trackBarGreyscale
            // 
            this.trackBarGreyscale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarGreyscale.Location = new System.Drawing.Point(3, 27);
            this.trackBarGreyscale.Maximum = 255;
            this.trackBarGreyscale.Name = "trackBarGreyscale";
            this.trackBarGreyscale.Size = new System.Drawing.Size(578, 45);
            this.trackBarGreyscale.TabIndex = 3;
            this.trackBarGreyscale.TickFrequency = 10;
            this.trackBarGreyscale.Scroll += new System.EventHandler(this.trackBarGreyscale_Scroll);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.ErrorImage = null;
            this.pictureBoxMain.Image = global::iPix.Properties.Resources.portugalsmall1;
            this.pictureBoxMain.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(564, 342);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // btnSelectMarkColor
            // 
            this.btnSelectMarkColor.Location = new System.Drawing.Point(296, 4);
            this.btnSelectMarkColor.Name = "btnSelectMarkColor";
            this.btnSelectMarkColor.Size = new System.Drawing.Size(121, 23);
            this.btnSelectMarkColor.TabIndex = 6;
            this.btnSelectMarkColor.Text = "Choose mark color";
            this.btnSelectMarkColor.UseVisualStyleBackColor = true;
            this.btnSelectMarkColor.Click += new System.EventHandler(this.btnSelectMarkColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Brightness value:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.CheckBox checkBoxInvert;
        private System.Windows.Forms.ColorDialog colorDialogMarkColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectMarkColor;
    }
}

