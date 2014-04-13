using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ColorConcentration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string imageFile;


        private string ShowFileDialog()
        {
            openFileDialog.Filter = string.Format("jpg files (*.jpg)|*.jpg|All files (*.*)|*.*");
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.ShowDialog();

            return openFileDialog.FileName;
        }
        public void HandleError(string errorMessage)
        {
            lblError.Text = errorMessage;
            lblError.Visible = true;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            imageFile = ShowFileDialog();

            try
            {
                if (!string.IsNullOrEmpty(imageFile) && imageFile.ToLower().EndsWith(".jpg"))
                {

                    tbxFileName.Text = imageFile;
                }
                else
                {
                    HandleError("Invalid Image type");
                }
            }
            catch (ArgumentException argumentException)
            {
                HandleError("Unable to load image");
            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                var bitmap = GetBitMap();
                var percentage = GetRedPercentage(bitmap);
                lblPercentValue.Text = percentage.ToString() + "%";
                lblPercentage.Visible = true;
            }
            catch (Exception ex)
            {
                HandleError(ex.Message);
            }
        }

        private Bitmap GetBitMap()
        {
            if (File.Exists(imageFile))
            {
                return (Bitmap) Image.FromFile(imageFile);
            }
            throw new Exception("Unable to convert image to Bitmap");
        }
        private double GetRedPercentage(Bitmap bmp)
        {
            // Specify a pixel format.
            PixelFormat pxf = PixelFormat.Format24bppRgb;

            // Lock the bitmap's bits.
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite,pxf);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;
            
            // Declare an array to hold the bytes of the bitmap. 
            // int numBytes = bmp.Width * bmp.Height * 3; 
            int numBytes = bmpData.Stride * bmp.Height;
            byte[] rgbValues = new byte[numBytes];

            // Copy the RGB values into the array.
            Marshal.Copy(ptr, rgbValues, 0, numBytes);

            // Manipulate the bitmap, such as changing the 
            // blue value for every other pixel in the the bitmap. 
            long totalRed = 0;
            int numSkipped = 0;
            const int greenCutoff = 190;
            var blueLower = string.IsNullOrWhiteSpace(tbxBlueLower.Text) ? 80 : Convert.ToInt32(tbxBlueLower.Text);
            var blueUpper = string.IsNullOrWhiteSpace(tbxBlue.Text) ? 180 : Convert.ToInt32(tbxBlue.Text);
            const int redCutoff = 155;
            for (int counter = 0; counter < rgbValues.Length-3; counter += 3)
            {
                var blue = Convert.ToInt64(rgbValues[counter]);
                var green = Convert.ToInt64(rgbValues[counter + 1]);
                var red = Convert.ToInt64(rgbValues[counter+2]);
                if (red < redCutoff)
                {
                    //Black content
                    numSkipped++;
                    //    Console.WriteLine("Red: " + red);
                    //    Console.WriteLine("Green: " + green);
                    //    Console.WriteLine("Blue: " + blue);
                    //    continue;
                }
                if (blue < blueUpper && green < greenCutoff && red > redCutoff)
                {
                    if(blue<=blueLower)
                        totalRed += 2;
                    else
                        totalRed += 1;
                }
            }
            var pureRed = ((numBytes/3)-numSkipped);//100 is the max range, since 255-155=100   
            // Unlock the bits.
            return ((double)totalRed/pureRed)*100.0;
        }
    }
}
