using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace Image_ProcessingPackage{
    public class ImageOperations
    {
        /*Opens coloured image in common formats and
         * Returns buffer containing the opened image Pixels.*/

        public static Color[,] openImageRegular(string image_path)
        {
            Bitmap original_image = new Bitmap(image_path);

            int height = (int)original_image.Height;
            int width = (int)original_image.Width;

            Color[,] buffer = new Color[height, width];

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    buffer[y,x] = original_image.GetPixel(x, y);
                }
            return buffer;
        }

        /*Displays the opened image in picture box*/

        public static void DisplayImage(PictureBox PicBox, Color[,] image_buffer)
        {
            Int32 Height = image_buffer.GetLength(0);
            Int32 Width = image_buffer.GetLength(1);

            Bitmap Image = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                {
                    Image.SetPixel(x, y, image_buffer[y, x]);
                }

            PicBox.Image = Image;
           PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //PicBox.Height = Form1.Instance.pictureBoxInputImage.Height;
            //PicBox.Width = Form1.Instance.pictureBoxInputImage.Width;
        }

        //Converts 2D array into 1D array.

        public static Color[] flattenWindow(Color[,] input_image_buffer)
        {
            int height = input_image_buffer.GetLength(0);
            int width = input_image_buffer.GetLength(1);
            int length = height * width;
            int k = 0;
            Color [] input_image__buffer_1D = new Color[length];

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    input_image__buffer_1D[k++] = input_image_buffer[i, j];
                }
            return input_image__buffer_1D;
        }

        //Get max color intensities

        public static Color GetmaxIntensities(Color[] input_image_buffer_1D)
        {
            Color max_color_components = new Color();
            int length = input_image_buffer_1D.Length;

            int max_red = 0;
            int max_green = 0;
            int max_blue = 0;

            for (int i = 0; i < length; i++)
            {
                if (input_image_buffer_1D[i].R >= max_red)
                    max_red = input_image_buffer_1D[i].R;
                if (input_image_buffer_1D[i].G >= max_green)
                    max_green = input_image_buffer_1D[i].G;
                if (input_image_buffer_1D[i].B >= max_blue)
                    max_blue = input_image_buffer_1D[i].B;   
            }
            max_color_components = Color.FromArgb(max_red, max_green, max_blue);
            return max_color_components;
        }

        //Get min color intensities

        public static Color GetminIntensities(Color[] input_image_buffer_1D)
        {
            Color min_color_components = new Color();
            int length = input_image_buffer_1D.Length;

            int min_red = 255;
            int min_green = 255;
            int min_blue = 255;

            for (int i = 0; i < length; i++)
            {
                if (input_image_buffer_1D[i].R <= min_red)
                    min_red = input_image_buffer_1D[i].R;
                if (input_image_buffer_1D[i].G <= min_green)
                    min_green = input_image_buffer_1D[i].G;
                if (input_image_buffer_1D[i].B <= min_blue)
                    min_blue = input_image_buffer_1D[i].B;
            }
            min_color_components = Color.FromArgb(min_red, min_green, min_blue);
            return min_color_components;
        }
    }
}
