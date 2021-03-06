﻿using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPix
{
    public partial class MainForm : Form
    {

        private static Bitmap img;
        private static Bitmap original;
        private static bool invert {get; set;}
        private static Color markColor = Color.AliceBlue;

        public MainForm()
        {
            InitializeComponent();
            textBoxSliderValue.Text = "" + trackBarGreyscale.Value;
            img = (Bitmap)pictureBoxMain.Image; //shown image
            original = (Bitmap)img.Clone();  //keep copy of original
            colorDialogMarkColor.AllowFullOpen = true;
        }

        private void trackBarGreyscale_Scroll(object sender, EventArgs e)
        {
            textBoxSliderValue.Text = "" + trackBarGreyscale.Value;
            CallEditImage();
        }

        private void textBoxSliderValue_TextChanged(object sender, EventArgs e)
        {
            validateUserEntry();
            if (img != null)
            {
                CallEditImage();
            }
       }


        private void validateUserEntry()
        {
            int value = 0;
            if (int.TryParse(textBoxSliderValue.Text, out value))
            {
                // Checks the value of the text if it could parse to int
                if (value < 0 || value > 255)
                {
                    messageInputError();    //not between 0 and 255
                }
                else
                {
                    trackBarGreyscale.Value = value;    //sets value
                }
            }
            else
            {
                messageInputError();    //not an integer!
            };
        }

        private void messageInputError()
        {
            //invalid value: reset to 0
            textBoxSliderValue.Text = "0";
            trackBarGreyscale.Value = 0;
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "You did not enter a valid number (0-255). Use the slider... Reset to 0.";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            // Displays the MessageBox.
            MessageBox.Show(message, caption, buttons);
        }

        private async void CallEditImage() {
            int value = trackBarGreyscale.Value;
            img = await editImageAsync(img, original, value);
            pictureBoxMain.Image = img;
        }

        private async Task<Bitmap> editImageAsync(Bitmap img, Bitmap original, int value) {
            return await Task.Factory.StartNew(()=>editImage(img, original, value));
        }

        private Bitmap editImage(Bitmap img, Bitmap original, int value) {
            lock (img)
            {
                try
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        for (int y = 0; y < img.Height; y++)
                        {
                            var color = original.GetPixel(x, y);    // Get the color of a pixel within img
                            if ((color.GetBrightness() * 255) < value)
                            {
                                if (invert)
                                {
                                    img.SetPixel(x, y, color);
                                }
                                else
                                {
                                    img.SetPixel(x, y, markColor);
                                }

                            }
                            else
                            {
                                if (invert)
                                {
                                    img.SetPixel(x, y, markColor);
                                }
                                else
                                {
                                    img.SetPixel(x, y, color);
                                }
                            }
                        }
                    };
                }
                catch (Exception e)
                {
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Oupps - something went wrong while Imagemanipulation: " + e.Message;
                    string caption = "Bummer!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons);
                }
            }
            return img;
        }
        
        private void checkBoxInvert_CheckedChanged(object sender, EventArgs e)
        {
            invert = checkBoxInvert.Checked;
            CallEditImage();
        }

        private void btnSelectMarkColor_Click(object sender, EventArgs e)
        {
            colorDialogMarkColor.ShowDialog();
            markColor = colorDialogMarkColor.Color;
            CallEditImage();
        }

        private void btLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog()) {
                fileDialog.Filter = "Images|*.jpeg;*.png;*.jpg;*.gif";
                String path = "";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = fileDialog.FileName;
                    pictureBoxMain.Image = Image.FromFile(path);
                    img = (Bitmap)pictureBoxMain.Image; //shown image to variable img
                    original = (Bitmap)img.Clone();  //keep copy of original 
                }
            } 
        }
    }
}
