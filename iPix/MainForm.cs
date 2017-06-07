﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPix
{
    public partial class MainForm : Form
    {
       
        private static Bitmap img;
        private static Bitmap original;

        public MainForm()
        {
            InitializeComponent();
            textBoxSliderValue.Text = "" + trackBarGreyscale.Value;
            img = (Bitmap)pictureBoxMain.Image; //shown image
            original = (Bitmap)img.Clone();  //keep copy of original
        }

        private void trackBarGreyscale_Scroll(object sender, EventArgs e)
        {
            textBoxSliderValue.Text = "" + trackBarGreyscale.Value;
            adaptPixels();
        }

        private void textBoxSliderValue_TextChanged(object sender, EventArgs e)
        {
            validateUserEntry();
            if (img != null)
            {
                adaptPixels();
            }
       }


        private void validateUserEntry()
        {
            int value = 0;
            if (int.TryParse(textBoxSliderValue.Text, out value)) {
                // Checks the value of the text.
                if (value < 0 || value > 255)
                {
                    //invalid value: reset to 0
                    textBoxSliderValue.Text = "0";
                    trackBarGreyscale.Value = 0;
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "You did not enter a valid number. Use the slider... Reset to 0.";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    trackBarGreyscale.Value = value;
                }
            };
        }


        private void adaptPixels()
        {

                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        var color = original.GetPixel(x, y);    // Get the color of a pixel within img
                        if ((color.GetBrightness() * 255) < trackBarGreyscale.Value)
                        {
                            img.SetPixel(x, y, Color.OrangeRed);
                        }
                        else
                        {
                            img.SetPixel(x, y, color);
                        }
                    }
                };
                pictureBoxMain.Refresh();
        }
    }
}