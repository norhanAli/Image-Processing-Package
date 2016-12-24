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
    public partial class GuassianFilterOption2 : Form
    {

        public int mask_height;
        public int mask_width;
        public double sigma;

        private Color[,] Image1_Array_Modified;
        // Original image buffer arr
        private Color[,] Image1_Array;
        public GuassianFilterOption2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            if (Form1.Instance.ModifiedInputImage == null)
            {
             
                pictureBoxOrGImG.Image = Form1.Instance.InputImage;
                pictureBoxOrGImG.SizeMode = PictureBoxSizeMode.StretchImage;

                Image1_Array_Modified = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];
                Image1_Array = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];
                Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, Image1_Array_Modified);
                Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, Image1_Array);
            }
            else
            {
                Bitmap temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                pictureBoxOrGImG.Image = temp;
                pictureBoxOrGImG.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
                Image1_Array_Modified = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
                Image1_Array = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
                //Copy [Global Array From (Form1)] To Our [Local Array]
                Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, Image1_Array_Modified);
                //Copy [Global Array From (Form1)] To Our [Global Array]
                Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, Image1_Array);
            }
        }
        private void Copy_Bufffer_to_Another(Color[,] array1, Color[,] array2)
        {
            //Copy array1 To array2
            //Hight loop
            for (int y = 0; y < array1.GetLength(1); y++)
            {
                //Width loop
                for (int x = 0; x < array1.GetLength(0); x++)
                {
                    array2[x, y] = array1[x, y];
                }
            }
        }

        private void btn_opt2_apply_filter_Click(object sender, EventArgs e)
        {
            sigma = double.Parse(txt_sigma.Text.ToString());
            int N = (int)(3.7 * sigma - 0.5);
            int mask_width = 2 * N + 1;
            Image1_Array_Modified = GuassianFilter.GuassianFilterOption2(sigma, Image1_Array);
            ImageOperations.DisplayImage(pictureBoxFilteredGau, Image1_Array_Modified);
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.ModifiedInputImage == null)
            {
           Bitmap temp = (Bitmap)Form1.Instance.InputImage.Clone();
            //Form1.Instance.InputImage = (Bitmap)temp.Clone();
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
            pictureBoxFilteredGau.Image = temp;
            pictureBoxFilteredGau.SizeMode=PictureBoxSizeMode.StretchImage;
            this.Invalidate();
            }
            else{
            Bitmap temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
            pictureBoxFilteredGau.Image = temp;
            pictureBoxFilteredGau.SizeMode=PictureBoxSizeMode.StretchImage;
            this.Invalidate();
            
            }
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)pictureBoxFilteredGau.Image.Clone();
            pictureBoxFilteredGau.Image = temp;

            temp = (Bitmap)pictureBoxFilteredGau.Image;
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp;
            Form1.Instance.ModifiedInputImage = (Bitmap)temp;
            Form1.Instance.temp_BufferImgArray = Image1_Array_Modified;
            //Form1.Instance.InputImage_BufferArray = Image1_Array_Modified;
            this.Invalidate();
            this.Close();

        }

       

       
    }
}
