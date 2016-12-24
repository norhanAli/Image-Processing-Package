using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Image_ProcessingPackage
{
    public partial class GemotricTransform : Form
    {
        public Bitmap temp;
        Bitmap TestImage_Modified;
       // OpenFileDialog open = new OpenFileDialog();
        private Color[,] Image1_Array_Modified;
        //Global arr
        private Color[,] Image1_Array;
        //private Bitmap TestImage_Modified;

        public GemotricTransform()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            if (Form1.Instance.ModifiedInputImage == null)
            {
                //Put Original Image From Form1 In Picture Box
                pictureBox1.Image = Form1.Instance.InputImage;
              //  pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //Create New Array
                Image1_Array_Modified = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];
                Image1_Array = new Color[Form1.Instance.InputImage_BufferArray.GetLength(0), Form1.Instance.InputImage_BufferArray.GetLength(1)];

                //Copy buffer for  butmap image From Form1 To that buffer 
                Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, Image1_Array_Modified);
                //Copy buffer for  butmap from Form1 To Globalbufffer
                Copy_Bufffer_to_Another(Form1.Instance.InputImage_BufferArray, Image1_Array);
            }
            else {
                Bitmap temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                pictureBox1.Image = temp;
               // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
                Image1_Array_Modified = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
                Image1_Array = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
                //Copy [Global Array From (Form1)] To Our [Local Array]
                Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, Image1_Array_Modified);
                //Copy [Global Array From (Form1)] To Our [Global Array]
                Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, Image1_Array);
            
            }

        }

     

        //----------------------------------------------------------------------------------------

        private void button3_Click(object sender, EventArgs e)
        {
            Matrix AllThreeMatrix = new Matrix();
            Matrix identity = new Matrix();

            float x_scale = float.Parse(TextForXVal.Text);
            float y_scale = float.Parse(TextForYval.Text);
            float rotate_angle = float.Parse(textBox3.Text);
            float x_shear = float.Parse(textforshearx.Text);
            float y_shear = float.Parse(textforsheary.Text);

            //AllThreeMatrix.Multiply(identity);
            AllThreeMatrix.Scale(x_scale, y_scale);
            AllThreeMatrix.Rotate(rotate_angle);
            AllThreeMatrix.Shear(x_shear, y_shear);


            Image1_Array_Modified= GoemetricTransformations.geometricLinearTransformations(Image1_Array, AllThreeMatrix);
            ImageOperations.DisplayImage(pictureBox2, Image1_Array_Modified);
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

        private void Reset_button_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.ModifiedInputImage == null)
            {
            temp = (Bitmap)Form1.Instance.InputImage.Clone();
            //Form1.Instance.InputImage = (Bitmap)temp.Clone();
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
            pictureBox2.Image = temp;
            this.Invalidate();}
            else
            {
                temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                //Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                pictureBox2.Image = temp;
                this.Invalidate();
            }
          
        }


        
        private void AccumlativeImg_button_Click(object sender, EventArgs e)
        {



            Bitmap bit = (Bitmap)pictureBox2.Image.Clone();
            pictureBox1.Image = bit;
            pictureBox2.Image = bit;
            bit = (Bitmap)pictureBox1.Image;
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)bit;
            Form1.Instance.ModifiedInputImage = (Bitmap)bit;
            Form1.Instance.temp_BufferImgArray = Image1_Array_Modified;
            //Form1.Instance.InputImage_BufferArray = Image1_Array_Modified;
            this.Invalidate();
            this.Close();

        }

        private void buttonSacale_Click(object sender, EventArgs e)
        {
            float X = float.Parse(TextForXVal.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            float Y = float.Parse(TextForYval.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            Matrix S = new Matrix();
            S.Scale(X,Y);
            Image1_Array_Modified = GoemetricTransformations.geometricLinearTransformations(Image1_Array, S);
            ImageOperations.DisplayImage(pictureBox2, Image1_Array_Modified);
        }

        private void button_Rotate_Click(object sender, EventArgs e)
        {
            Matrix S = new Matrix();
            float Angle = float.Parse(textBox3.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            S.Rotate(Angle);
            Image1_Array_Modified = GoemetricTransformations.geometricLinearTransformations(Image1_Array, S);
            ImageOperations.DisplayImage(pictureBox2, Image1_Array_Modified);
        }

        private void button_Shear_Click(object sender, EventArgs e)
        {
            Matrix S = new Matrix();
            float shX = float.Parse(textforshearx.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            float shY = float.Parse(textforsheary.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            S.Shear(shX,shY);
            Image1_Array_Modified = GoemetricTransformations.geometricLinearTransformations(Image1_Array, S);
            ImageOperations.DisplayImage(pictureBox2, Image1_Array_Modified);
        }
        

     
      
        }
    }


