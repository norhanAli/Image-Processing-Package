using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_ProcessingPackage
{
    public partial class Laplacian_Filter : Form
    {
         public Color[,] output_image_buffer;
         public Color[,] output_Buffer;
        public Bitmap pic;
        private int W, h;


         public Laplacian_Filter()
         {
             InitializeComponent();
             this.MaximizeBox = false;
             if (Form1.Instance.ModifiedInputImage == null)
             {
                 Bitmap temp = (Bitmap)Form1.Instance.InputImage.Clone();
                 //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                 Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                 before_pictureBox.Image = temp;
                 before_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                 output_image_buffer = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];
                 output_Buffer = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];
                 Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, output_image_buffer);
                 Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, output_Buffer);

             }
             else
             {
                 Bitmap temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                 //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                 Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                 before_pictureBox.Image = temp;
                 before_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                 this.Invalidate();
                 output_image_buffer = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
                 output_Buffer = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
                 Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, output_image_buffer);
                 Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, output_Buffer);
             }
         }

        private void Copy_Bufffer_to_Another(Color[,] array1, Color[,] array2)
        {
            for (int y = 0; y < array1.GetLength(1); y++)
            {
                for (int x = 0; x < array1.GetLength(0); x++)
                {
                    array2[x, y] = array1[x, y];
                }
            }
        }
        private double[,] laplacian_filter()
        {
            int filterWidth = 3;
            int filterHeight = 3;
            double[,] filter = new double[filterWidth, filterHeight];

            filter[0, 0] = filter[0, 1] = filter[0, 2] = filter[1, 0] = filter[1, 2] = filter[2, 0] = filter[2, 1] = filter[2, 2] = -1;
            filter[1, 1] = 9;
            return filter;

        }

        private void LinearFilter(Bitmap pic, double[,] filter, int origX, int origY)
        {
            int filterHeight = filter.GetLength(0);
            int filterWidth = filter.GetLength(1);
            int redA, greenA, blueA;
            for (int i = 0; i < pic.Width - filterWidth; i++)
            {
                for (int j = 0; j < pic.Height - filterHeight; j++)
                {
                    redA = 0;
                    greenA = 0;
                    blueA = 0;

                    for (int x = 0; x < filterWidth; x++)
                    {
                        for (int y = 0; y < filterHeight; y++)
                        {

                            Color pixelColor = pic.GetPixel(i + x, j + y);
                            redA += (int)(filter[x, y] * pixelColor.R);
                            greenA += (int)(filter[x, y] * pixelColor.G);
                            blueA+= (int)(filter[x, y] * pixelColor.B);
                        }
                    }
                    //Normalization
                    if (redA > 255)
                        redA = 255;
                    if (greenA > 255)
                        greenA = 255;
                    if (blueA > 255)
                        blueA= 255;
                    if (redA < 0)
                        redA = 0;
                    if (blueA < 0)
                        blueA = 0;
                    if (greenA < 0)
                        greenA = 0;

                    //set returend pixel
                    pic.SetPixel(i + origX, j + origY, Color.FromArgb(redA, greenA, blueA));

                }
            }

            After_pictureBox.Image = pic;
            After_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Sharp_Button_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)before_pictureBox.Image.Clone();
            pic = temp;
            LinearFilter(pic, laplacian_filter(), (int)h/ 2, (int)W/ 2);
          
           
            
        }

        private void undo_button_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.ModifiedInputImage == null)
            {
            Bitmap p = (Bitmap)Form1.Instance.InputImage.Clone();
            //Form1.Instance.InputImage = (Bitmap)temp.Clone();
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)p.Clone();
            After_pictureBox.Image = p;
            After_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Invalidate();}
             else{
                Bitmap p = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                //Form1.Instance.pictureBoxInputImage.Image = (Bitmap)p.Clone();
                After_pictureBox.Image = p;
                After_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
        }

        private void Applay_button_Click(object sender, EventArgs e)
        {
            Bitmap bit = (Bitmap)pic.Clone();
            before_pictureBox.Image = bit;
            before_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bit = (Bitmap)before_pictureBox.Image;
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)bit;
            Form1.Instance.ModifiedInputImage = (Bitmap)bit;
            Form1.Instance.temp_BufferImgArray = output_image_buffer;
            //Form1.Instance.InputImage_BufferArray = Image1_Array_Modified;
            this.Invalidate();
            this.Close();
        }
    }
}
