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
    public partial class Kircsh_filter : Form
    {
        public Bitmap temp;
        private Color[,] Image1_Array_Modified;
        private Color[,] Image1_Array;
        private Bitmap Test;
        public Kircsh_filter()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            if (Form1.Instance.ModifiedInputImage == null)
            {
                before_kircsh_pictureBox.Image = Form1.Instance.InputImage;
                before_kircsh_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                Image1_Array_Modified = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];
                Image1_Array = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];
                Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, Image1_Array_Modified);
                Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, Image1_Array);
            }
            else { 
            
                Bitmap temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                before_kircsh_pictureBox.Image = temp;
                before_kircsh_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
                Image1_Array_Modified = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
                Image1_Array = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
                Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, Image1_Array_Modified);
                Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, Image1_Array);
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            KircshMatrcies m = new KircshMatrcies();
            Image1_Array_Modified = m.convluteKirshfilter(KircshMatrcies.Kirsch3x3Horizontal, Image1_Array);
            ImageOperations.DisplayImage(afterKircsh_pictureBox, Image1_Array_Modified);
            afterKircsh_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KircshMatrcies m = new KircshMatrcies();
            Image1_Array_Modified = m.convluteKirshfilter(KircshMatrcies.Kirsch3x3Horizontal, Image1_Array);
            ImageOperations.DisplayImage(afterKircsh_pictureBox, Image1_Array_Modified);
            afterKircsh_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KircshMatrcies m = new KircshMatrcies();
            Image1_Array_Modified = m.convluteKirshfilter(KircshMatrcies.Kirsch3x3Daigonal1, Image1_Array);
            ImageOperations.DisplayImage(afterKircsh_pictureBox, Image1_Array_Modified);
            afterKircsh_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KircshMatrcies m = new KircshMatrcies();
            Image1_Array_Modified = m.convluteKirshfilter(KircshMatrcies.Kirsch3x3Daigonal2, Image1_Array);
            ImageOperations.DisplayImage(afterKircsh_pictureBox, Image1_Array_Modified);
            afterKircsh_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void undo_button_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.ModifiedInputImage == null)
            {
                temp = (Bitmap)Form1.Instance.InputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                afterKircsh_pictureBox.Image = temp;
                this.Invalidate();
            }
            else {
                temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                afterKircsh_pictureBox.Image = temp;
                this.Invalidate();
            }
          
        }

        private void Applay_button_Click(object sender, EventArgs e)
        {

            Bitmap temp = (Bitmap)afterKircsh_pictureBox.Image.Clone();
            afterKircsh_pictureBox.Image = temp;
            afterKircsh_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            temp = (Bitmap)afterKircsh_pictureBox.Image;
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp;
            Form1.Instance.ModifiedInputImage = (Bitmap)temp;
            Form1.Instance.temp_BufferImgArray = Image1_Array_Modified;
            this.Invalidate();
            this.Close();
        } 

 
    }
}
