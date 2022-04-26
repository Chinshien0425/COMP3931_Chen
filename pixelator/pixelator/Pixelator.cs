using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AForge.Imaging.ColorReduction;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace pixelator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPixelation_Click(object sender, EventArgs e)
        {
            //Control display function area
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel3.Location = new System.Drawing.Point(0, 80);
            }
            else
            {
                panel1.Visible = true;
                panel3.Location = new System.Drawing.Point(0, 201);
            }
        }

        private void picSource_Paint(object sender, PaintEventArgs e)
        {
            //Set the picturebox outline
            PictureBox p = (PictureBox)sender;
            Pen pp = new Pen(Color.Gray);
            e.Graphics.DrawRectangle(pp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.X + e.ClipRectangle.Width - 1, e.ClipRectangle.Y + e.ClipRectangle.Height - 1);
        }

        private void picOutput_Paint(object sender, PaintEventArgs e)
        {
            //Set the picturebox outline
            PictureBox p = (PictureBox)sender;
            Pen pp = new Pen(Color.Gray);
            e.Graphics.DrawRectangle(pp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.X + e.ClipRectangle.Width - 1, e.ClipRectangle.Y + e.ClipRectangle.Height - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
            this.picSource.AllowDrop = true;
            panel3.Location = new System.Drawing.Point(0, 85);
            txtPixelate.Text = trbPixelate.Value.ToString();
            txtBlur.Text = trbBlur.Value.ToString();
            labTime.Text = "";

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //Displays the value of the tarckbar
            txtPixelate.Text = trbPixelate.Value.ToString();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the image
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.picSource.Image = Image.FromFile(open.FileName);
                //Enable the function after entering the picture
                trbPixelate.Enabled = true;
                trbBlur.Enabled = true;
                cobColor.Enabled = true;
                cobMethod.Enabled = true;
                txtPixelate.Enabled = true;
                txtBlur.Enabled = true;
                btnPixelate.Enabled = true;
                label3.Visible = false;
            }
            else this.picSource.Image = null;//Don't show pictures
        }

        private void picSource_DragDrop(object sender, DragEventArgs e)
        {     
            string fileName = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.picSource.Image = Image.FromFile(fileName);

            //Enable the function after entering the picture
            trbPixelate.Enabled = true;
            trbBlur.Enabled = true;
            cobColor.Enabled = true;
            cobMethod.Enabled = true;
            txtPixelate.Enabled = true;
            txtBlur.Enabled = true;
            btnPixelate.Enabled = true;
            label3.Visible = false;
        }

        private void picSource_DragEnter(object sender, DragEventArgs e)
        {
            //Enable PictureBox to drag in images directly
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPixelate.Text == "") return;
            int a = Convert.ToInt32(txtPixelate.Text);
            if (a > trbPixelate.Maximum)
            {
                a = trbPixelate.Maximum;
            }
            trbPixelate.Value = a;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Restrict the input value to an integer
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else { }

        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project Name: Pixel Art Generation \n\r Made by: Siyuan Chen \n\r Student ID: ml19sc4", "About", MessageBoxButtons.OK);
        }


        private void PixelateImage(Image image, int pixelateSize, Bitmap different, Bitmap blur)
        {
            var bitmap = new Bitmap(image.Width, image.Height);
            Bitmap pixelated1 = new Bitmap(different.Width, different.Height);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            }

            // Loop through the image in pixelateSize*pixelateSize cells.
            for (var yy = 0; yy < image.Height && yy < image.Height; yy += pixelateSize)
            {
                for (var xx = 0; xx < image.Width && xx < image.Width; xx += pixelateSize)
                {
                    var cellColors = new List<Color>();

                    // Store each color from the pixelateSize*pixelateSize cell into cellColors.
                    for (var y = yy; y < yy + pixelateSize && y < image.Height; y++)
                    {
                        for (var x = xx; x < xx + pixelateSize && x < image.Width; x++)
                        {
                            cellColors.Add(bitmap.GetPixel(x, y));
                        }
                    }

                    // Get the average red, green, and blue values.
                    var averageRed = cellColors.Aggregate(0, (current, color) => current + color.R) / cellColors.Count;
                    var averageGreen = cellColors.Aggregate(0, (current, color) => current + color.G) / cellColors.Count;
                    var averageBlue = cellColors.Aggregate(0, (current, color) => current + color.B) / cellColors.Count;

                    var averageColor = Color.FromArgb(averageRed, averageGreen, averageBlue);

                    int max = 0;
                    int max1 = 0;
                    int max2 = 0;
                    int max3 = 0;
                    if (checkBox1.Checked)
                    {
                        for (var y = yy; y < yy + pixelateSize && y < image.Height; y++)
                        {
                            for (var x = xx; x < xx + pixelateSize && x < image.Width; x++)
                            {
                                int colormax1 = averageColor.R + averageColor.G + averageColor.B;
                                string a = cobMethod.Text;
                                int colormax;
                                double p;
                                Color color_original, color_different, color_blur;
                                color_different = different.GetPixel(x, y);
                                colormax = color_different.R + color_different.G + color_different.B;
                                switch (a)
                                {
                                    case "1"://method 1: value from original image
                                        if (max < colormax)
                                        {
                                            max = colormax;
                                            averageColor = bitmap.GetPixel(x, y);

                                        }
                                        break;
                                    case "2": //method 2: value from blurred image
                                        if (max < colormax)
                                        {
                                            max = colormax;
                                            averageColor = blur.GetPixel(x, y);

                                        }
                                        break;
                                    case "3": //method 2: value from original image and average
                                        Color averageColor1 = bitmap.GetPixel(x, y);
                                        Color averageColor2 = bitmap.GetPixel(x, y);
                                        Color averageColor3 = bitmap.GetPixel(x, y);
                                        if (max < colormax)
                                        {
                                            max = colormax;
                                            if (max < colormax)
                                            {
                                                max = colormax;
                                                averageColor1 = bitmap.GetPixel(x, y);
                                            }
                                            if (max1 < max)
                                            {
                                                max1 = max;
                                                averageColor2 = bitmap.GetPixel(x, y);

                                            }
                                            if (max2 < max1)
                                            {
                                                max2 = max1;
                                                averageColor3 = bitmap.GetPixel(x, y);

                                            }

                                        }
                                        //Take the average of the colors
                                        int R = Math.Abs((averageColor1.R + averageColor2.R + averageColor3.R) / 3);
                                        int G = Math.Abs((averageColor1.G + averageColor2.G + averageColor3.G) / 3);
                                        int B = Math.Abs((averageColor1.B + averageColor2.B + averageColor3.B) / 3);
                                        averageColor = Color.FromArgb(R, G, B);
                                        break;
                                    case "4":
                                        if (max < colormax)
                                        {
                                            max = colormax;
                                            averageColor = bitmap.GetPixel(x, y);
                                            color_blur = blur.GetPixel(x, y);
                                            p = trbProportion.Value / 100.00;
                                            int R1 = (int)Math.Abs(averageColor.R * p + (1 - p) * color_blur.R);
                                            int G1 = (int)Math.Abs(averageColor.G * p + (1 - p) * color_blur.G);
                                            int B1 = (int)Math.Abs(averageColor.B * p + (1 - p) * color_blur.B);
                                            averageColor = Color.FromArgb(R1, G1, B1);
                                        }
                                        break;
                                }


                            }
                        }

                    }

                    // Go back over the pixelateSize*pixelateSize cell and set each pixel to the average color.
                    for (var y = yy; y < yy + pixelateSize && y < image.Height; y++)
                    {
                        for (var x = xx; x < xx + pixelateSize && x < image.Width; x++)
                        {
                            bitmap.SetPixel(x, y, averageColor);
                        }
                    }
                }
            }
            picOutput.Image = bitmap;
        }

        public static double[,] GaussianBlur(int lenght, double weight)
        {
            double[,] kernel = new double[lenght, lenght];
            double kernelSum = 0;
            int foff = (lenght - 1) / 2;
            double distance = 0;
            double constant = 1d / (2 * Math.PI * weight * weight);
            for (int y = -foff; y <= foff; y++)
            {
                for (int x = -foff; x <= foff; x++)
                {
                    distance = ((y * y) + (x * x)) / (2 * weight * weight);
                    kernel[y + foff, x + foff] = constant * Math.Exp(-distance);
                    kernelSum += kernel[y + foff, x + foff];
                }
            }
            for (int y = 0; y < lenght; y++)
            {
                for (int x = 0; x < lenght; x++)
                {
                    kernel[y, x] = kernel[y, x] * 1d / kernelSum;
                }
            }
            return kernel;
        }


        private int result = 256;
        private void color(Image image)
        {
            Bitmap curBitmap = (Bitmap)image;
            // instantiate the images' color quantization class
            ColorImageQuantizer ciq = new ColorImageQuantizer(new MedianCutQuantizer());
            // get 16 color palette for a given image
            Color[] colorTable = ciq.CalculatePalette(curBitmap, result);

            // ... or just reduce colors in the specified image
            Bitmap newImage = ciq.ReduceColors(curBitmap, result);

            picOutput.Image = newImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel5.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                panel5.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = cobColor.Text;
            result = int.Parse(str);
            //callOnClick(button2);
        }

        private static Bitmap different(Bitmap a, Bitmap b)
        {
            Bitmap result = new Bitmap(a.Width, a.Height);
            //Original image-blur image=different image
            for (int i = 0; i < a.Width; i++)
            {
                for (int j = 0; j < a.Height; j++)
                {
                    Color color_a = a.GetPixel(i, j);
                    Color color_b = b.GetPixel(i, j);
                    int red = Math.Abs(color_a.R - color_b.R);
                    int blue = Math.Abs(color_a.B - color_b.B);
                    int green = Math.Abs(color_a.G - color_b.G);
                    result.SetPixel(i, j, Color.FromArgb(red, green, blue));

                }

            }
            return result;

        }

        public static Bitmap Convolve(Bitmap srcImage, double[,] kernel)
        {
            int width = srcImage.Width;
            int height = srcImage.Height;
            BitmapData srcData = srcImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            srcImage.UnlockBits(srcData);
            int colorChannels = 3;
            double[] rgb = new double[colorChannels];
            int foff = (kernel.GetLength(0) - 1) / 2;
            int kcenter = 0;
            int kpixel = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    for (int c = 0; c < colorChannels; c++)
                    {
                        rgb[c] = 0.0;
                    }
                    kcenter = y * srcData.Stride + x * 4;
                    for (int fy = -foff; fy <= foff; fy++)
                    {
                        for (int fx = -foff; fx <= foff; fx++)
                        {
                            int actualFx = (x + fx) < 0 ? 0 : fx;
                            actualFx = (x + fx) >= width ? 0 : actualFx;
                            int actualFy = (y + fy) < 0 ? 0 : fy;
                            actualFy = (y + fy) >= height ? 0 : actualFy;


                            kpixel = kcenter + actualFy * srcData.Stride + actualFx * 4;
                            for (int c = 0; c < colorChannels; c++)
                            {
                                rgb[c] += (double)(buffer[kpixel + c]) * kernel[fy + foff, fx + foff];
                            }
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        if (rgb[c] > 255)
                        {
                            rgb[c] = 255;
                        }
                        else if (rgb[c] < 0)
                        {
                            rgb[c] = 0;
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        result[kcenter + c] = (byte)rgb[c];
                    }
                    result[kcenter + 3] = 255;
                }
            }
            Bitmap resultImage = new Bitmap(width, height);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);
            return resultImage;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {

            txtBlur.Text = trbBlur.Value.ToString();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Exclude errors with blur=1 or ""
            if (txtBlur.Text == "") return;
            if (txtBlur.Text == "1") return;
            int a = Convert.ToInt32(txtBlur.Text);
            if (a > trbBlur.Maximum)
            {
                a = trbBlur.Maximum;
            }
            trbBlur.Value = a;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cobMethod.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "") return;
            int a = Convert.ToInt32(textBox3.Text);
            if (a > trbProportion.Maximum)
            {
                a = trbProportion.Maximum;
            }
            trbProportion.Value = a;
        }

        private void trbProportion_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = trbProportion.Value.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobMethod.Text == "4")
            {
                trbProportion.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                trbProportion.Enabled = false;
                textBox3.Enabled = false;

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Filter = "Jpg Image|*.jpg|Bmp Image|*.bmp|Gif Image|*.gif|Png Image|*.png|Wmf  Image|*.wmf";
            savedialog.FilterIndex = 0;
            savedialog.RestoreDirectory = true;//Save the dialog for memory of the last directory
            savedialog.CheckPathExists = true;//Check the directory
            savedialog.FileName = System.DateTime.Now.ToString("yyyyMMddHHmmss") + "-"; ;//Setting the default file name
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                picOutput.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);// Image indicates the image to be saved
                MessageBox.Show(this, "Saved successfully！", "Tip");
            }
        }

        private void btnPixelate_Click_1(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Bitmap curBitmap = (Bitmap)picSource.Image;

            double[,] d = GaussianBlur(trbBlur.Value, trbBlur.Value);
            Bitmap curBitmap2 = Convolve(curBitmap, d);

            PixelateImage(curBitmap, trbPixelate.Value, different(curBitmap2, curBitmap), curBitmap2);

            color(picOutput.Image);

            sw.Stop();
            TimeSpan ts2 = sw.Elapsed;
            labTime.Text = ts2.ToString();

        }

    }
}
