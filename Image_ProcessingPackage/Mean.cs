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
    public partial class Mean : Form
    {
       
        public Color[,] output_image_buffer;
        public Color[,] output_Buffer;
        public Int32 width;
        public Int32 height;
        public int orignX;
        public int orignY;

        public double[,] mask;
        public Mean()
        {
            InitializeComponent();
             this.MaximizeBox = false;
             if (Form1.Instance.ModifiedInputImage == null)
             {
                 picturebox_Beforefilter.Image = Form1.Instance.InputImage;
                 picturebox_Beforefilter.SizeMode = PictureBoxSizeMode.StretchImage;
                 output_image_buffer = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];
                 output_Buffer = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];
                 Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, output_image_buffer);
                 Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, output_Buffer);
             }

             else {

                 Bitmap temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                 //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                 Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                 picturebox_Beforefilter.Image = temp;
                 picturebox_Beforefilter.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void Blur_Button_Click(object sender, EventArgs e)
        {
            width = int.Parse(textBoxWidth.Text.ToString());
            height = int.Parse(textBoxHeight.Text.ToString());

            orignX = int.Parse(textBox_OrgX.Text.ToString());
            orignY = int.Parse(textBox_OrgY.Text.ToString());
            output_image_buffer = meanFilter.maskfilter(width, height, output_Buffer);
            ImageOperations.DisplayImage(pictureBox_Afterpic, output_image_buffer);
           // pictureBox_Afterpic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.ModifiedInputImage == null)
            {
                Bitmap p = (Bitmap)Form1.Instance.InputImage.Clone();
                Form1.Instance.pictureBoxInputImage.Image = (Bitmap)p.Clone();
                pictureBox_Afterpic.Image = p;
                pictureBox_Afterpic.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            else {
                Bitmap p = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                pictureBox_Afterpic.Image = p;
                pictureBox_Afterpic.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
        }

        private void Applay_button_Click(object sender, EventArgs e)
        {
            Bitmap bit = (Bitmap)pictureBox_Afterpic.Image.Clone();
            pictureBox_Afterpic.Image = bit;
            pictureBox_Afterpic.Image = bit;        
            bit = (Bitmap)pictureBox_Afterpic.Image;
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)bit;
            Form1.Instance.ModifiedInputImage = (Bitmap)bit;
            Form1.Instance.temp_BufferImgArray = output_image_buffer;
            //Form1.Instance.InputImage_BufferArray = Image1_Array_Modified;
            this.Invalidate();
            this.Close();
        }
 }
}
