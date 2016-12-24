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
    public partial class Guassian_filter : Form
    {

        public int mask_height;
        public int mask_width;
        public double sigma;
        public int mask_size;
        //image modified buffer
        private Color[,] Image1_Array_Modified;
        //image1Buffer
        private Color[,] Image1_Array;
        public Guassian_filter()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            if (Form1.Instance.ModifiedInputImage == null)
            {
                //put rInput image Image From Form1 In Picture Box
                OringnalImg_pictureBox.Image = Form1.Instance.InputImage;
                OringnalImg_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                //Create New Array buffer
                Image1_Array_Modified = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];
                Image1_Array = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];

                //Copy original image buffer To our mofified image buffer  Array
                Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, Image1_Array_Modified);
                //Copy original image buffer To our mofified image buffer  Array
                //Copy  mofified image buffer from form1 To our mofified image buffer
                Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, Image1_Array);
            }
            else {
                Bitmap temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                OringnalImg_pictureBox.Image = temp;
                OringnalImg_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
                Image1_Array_Modified = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
                Image1_Array = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
                Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, Image1_Array_Modified);
                Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, Image1_Array);
            }
        }

        private void Copy_Bufffer_to_Another(Color[,] array1, Color[,] array2)
        {
            //Copy array1 To array2
            for (int y = 0; y < array1.GetLength(1); y++)
            {
                for (int x = 0; x < array1.GetLength(0); x++)
                {
                    array2[x, y] = array1[x, y];
                }
            }
        }

        private void btn_opt1_apply_filter_Click(object sender, EventArgs e)
        {
            mask_height = int.Parse(txt_mask_height.Text.ToString());
            mask_width = int.Parse(txt_mask_width.Text.ToString());
            sigma = double.Parse(txt_sigma.Text.ToString());
            Image1_Array_Modified = GuassianFilter.GuassianFilterOption1(mask_height, mask_width, sigma,Image1_Array);
            ImageOperations.DisplayImage(Filteredimg_pictureBox, Image1_Array_Modified);
            Filteredimg_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            label_def.Text = "Mask size: " + mask_size.ToString();
            label2_def.Text = "Sigma: " + sigma.ToString();
            
        }

        private void UnDo_button_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.ModifiedInputImage == null)
            {
                Bitmap temp = (Bitmap)Form1.Instance.InputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                Filteredimg_pictureBox.Image = temp;
                Filteredimg_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            else {
                Bitmap temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                Filteredimg_pictureBox.Image = temp;
                Filteredimg_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            
            }
        }

        private void Applay_button_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)Filteredimg_pictureBox.Image.Clone();
            Filteredimg_pictureBox.Image = temp;
            temp = (Bitmap)Filteredimg_pictureBox.Image;
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp;
            Form1.Instance.ModifiedInputImage = (Bitmap)temp;
            Form1.Instance.temp_BufferImgArray = Image1_Array_Modified;
            //Form1.Instance.InputImage_BufferArray = Image1_Array_Modified;
            this.Invalidate();
            this.Close();
        }

     

   
    }
}
