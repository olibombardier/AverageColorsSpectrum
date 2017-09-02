using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AverageColorsSpectrum
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button_imageSelector_Click(object sender, EventArgs e)
        {
            if (openFileDialog_imageSelector.ShowDialog() == DialogResult.OK)
            {
                label_numberOfFilesSelected.Text = openFileDialog_imageSelector.FileNames.Length +  " file(s) selected";
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            if (openFileDialog_imageSelector.FileNames.Length == 0)
            {
                MessageBox.Show("You must select at least one image.");
            }
            else
            {
                if (saveFileDialog_saveLocation.FileNames.Length == 0)
                {
                    MessageBox.Show("You must specify where you wish the spectrum to be saved.");
                }
                else
                {
                    progressBar_completion.Maximum = openFileDialog_imageSelector.FileNames.Length;
                    progressBar_completion.Value = 0;
                    button_generate.Text = "Generating...";
                    button_generate.Enabled = false;

                    Image spectrum = new Bitmap(openFileDialog_imageSelector.FileNames.Length * (int)numericUpDown_widthOfStripes.Value, (int)numericUpDown_heightOfSpectrum.Value);
                    Graphics g = Graphics.FromImage(spectrum);

                    int imageCounter = 0;
                    foreach (string fileName in openFileDialog_imageSelector.FileNames)
                    {
                        Bitmap image = (Bitmap)Image.FromFile(fileName);

                        Color averageColor = getAverageColorOfImage(image);

                        Point rectangleLocation = new Point(imageCounter * (int)numericUpDown_widthOfStripes.Value, 0);
                        Size rectangleSize = new Size((int)numericUpDown_widthOfStripes.Value, (int)numericUpDown_heightOfSpectrum.Value);
                        Rectangle rectangle = new Rectangle(rectangleLocation, rectangleSize);

                        Brush brush = new SolidBrush(averageColor);
                        g.FillRectangle(brush, rectangle);

                        image.Dispose();

                        progressBar_completion.Increment(1);
                        imageCounter++;
                    }

                    button_generate.Text = "Generate!";
                    button_generate.Enabled = true;
                    spectrum.Save(saveFileDialog_saveLocation.FileName);
                }
            }
        }

        private Color getAverageColorOfImage(Bitmap image)
        {
            Color averageColor = Color.Empty;

            int totalR = 0;
            int totalG = 0;
            int totalB = 0;

            int pixelCounter = 0;
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    if (pixelColor.A == 255)
                    {
                        totalR += pixelColor.R;
                        totalG += pixelColor.G;
                        totalB += pixelColor.B;

                        pixelCounter++;
                    }
                }
            }

            averageColor = Color.FromArgb(totalR / pixelCounter, totalG / pixelCounter, totalB / pixelCounter);

            return averageColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_saveLocation.ShowDialog() == DialogResult.OK)
            {

                label_saveLocation.Text = "...\\" + Path.GetFileName(saveFileDialog_saveLocation.FileName);
            }
        }
    }
}
