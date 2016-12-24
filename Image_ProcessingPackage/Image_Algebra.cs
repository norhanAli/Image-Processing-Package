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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Image_ProcessingPackage
{
    public partial class Image_Algebra : Form
    {

        private Bitmap Image1, Image2, ResultImage;
        private Color[,] Image1_bufferarr, Image2_bufferarr, ResultImage_bufferarr;

        private int CurrentValue = -1;
        public Image_Algebra()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            ComboBoxOpe.Items.Add("Add");
            ComboBoxOpe.Items.Add("Subtract");
            ComboBoxOpe.Items.Add("Not Image1");
            ComboBoxOpe.Items.Add("Not Image2");

            Apply_Button.Enabled = false;
            trackBar_add.Visible = false;
            trackBar_add.Enabled = false;
            AddLabel.Visible = false;
            labeladd.Visible = false;
        }

        //Bitmap Function : Load From Image1 To buffer
        private void BitmapImage1_To_Buffer(Bitmap X)
        {
            //Create New Array
            Image1_bufferarr= new Color[X.Width, X.Height];
            //2D Array
            for (int i = 0; i < X.Width; i++)
            {
                for (int j = 0; j < X.Height; j++)
                {
                    //Get The Pixel At This Location
                    Color ThisPixel = X.GetPixel(i, j);
                    Image1_bufferarr[i, j] = ThisPixel;
                }
            }

        }

        //Bitmap Function :Load From Image2 To buffer
        private void BitmapImage2_To_Buffer(Bitmap X)
        {
            //Create New Array
            Image2_bufferarr= new Color[X.Width, X.Height];

            //2D Array
            for (int i = 0; i < X.Width; i++)
            {
                for (int j = 0; j < X.Height; j++)
                {
                    //Get The Pixel At This Location
                    Color ThisPixel = X.GetPixel(i, j);
                    Image2_bufferarr[i, j] = ThisPixel;
                }
            }

            //IF image1 Hight or Width  not equal image2 Hight or Width Then fit them
            if (Image2.Height != Image1.Height || Image2.Width != Image1.Width)
                Fit_Image2_To_Image1();
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

        //Function fit 2 images 
        private void Fit_Image2_To_Image1()
        {
            //Get image1 As image to be fitted For image2
            //height , Width
            int imageFit_Width = Image1.Width;
            int imageFit_Height = Image1.Height;

         
            Color[,] FitImage_NewImage2_BuffArray = new Color[imageFit_Width, imageFit_Height]; 
            Bitmap FitImage = new Bitmap(imageFit_Width, imageFit_Height);

            //get image2 Height&Width
            float Current_Width = Image2.Width;
            float Current_Height = Image2.Height;
            //calculate width and height for Result(fitted image )
            float fitWidth = imageFit_Width / Current_Width;
            float fitHeight = imageFit_Height / Current_Height;
  
            for (int y = 0; y < FitImage_NewImage2_BuffArray.GetLength(1); y++)
            {
                for (int x = 0; x < FitImage_NewImage2_BuffArray.GetLength(0); x++)
                {
                    //P = P' * W^-1 that getting pixel From Old Image .
                    //P': new (destination) pixel location [x', y']
                    //-P: original pixel location [x, y]
                    //W^-1: inverse transformation matrix

                    //[2][2] Matrix (Matrix fit by it ) And Invert it by 1/new width , 1/new height
                    Matrix Fitting_Matrix = new Matrix(1 / fitWidth, 0, 1 / fitHeight, 0, 0, 0);
                   //xand y are New fitted Pixel Postion
                    Fitting_Matrix.Scale(x, y);

                    float[] MatrixElements = Fitting_Matrix.Elements;

                    //1: get floor
                    int x1 = (int)Math.Floor(MatrixElements[0]); // x
                    //Check If Every Point Still in The Scope 
                    if (x1 >= Image2_bufferarr.GetLength(0))
                        x1 = 0;

                    int x2 = x1 + 1;
                    if (x2 >= Image2_bufferarr.GetLength(0))
                        x2 = 0;

                    //get floor
                    int y1 = (int)Math.Floor(MatrixElements[2]); 
                    //Check If Every Point Still in The Scope If the image
                    if (y1 >= Image2_bufferarr.GetLength(1))
                        y1 = 0;

                    int y2 = y1 + 1;
                    if (y2 >= Image2_bufferarr.GetLength(1))
                        y2 = 0;

                    // after applying P = W-1P'

                    // Getting 4 Pixels Locations From old buffer
                    //P1 = OldBuffer[X1,Y1] 	; P2 = OldBuffer[X2,Y1]
                    //P3 = OldBuffer[X1,Y2] 	; P4 = OldBuffer[X2,Y2]

                    Color c1,c2, c3, c4;
                    c1 = Image2_bufferarr[x1, y2];
                    c2 = Image2_bufferarr[x2, y1];
                    c3 = Image2_bufferarr[x1, y2];
                    c4 = Image2_bufferarr[x2, y2];


                    //3: Fractions
                    //X_Fraction= Xold – X1
                    float X_Fraction = MatrixElements[0] - x1;
                    //Yfraction = Yold – Y1 
                    float Y_Fraction = MatrixElements[2] - y1;


                    // InterPolate in X- Direction

                    //First Top 2 Points P1 ,P2
                    float L = (1 - X_Fraction);
                    //Z1Red = P1 × L+ P2 ×L
                    float z1_R = (c1.R * L) + (c2.R * X_Fraction);
                    //Z1Green = P1 × L+ P2 ×L
                    float z1_G = (c1.G * L) + (c2.G * X_Fraction);
                    //Z1Blue = P1 × L+ P2 ×L
                    float z1_B = (c1.B * L) + (c2.B * X_Fraction);

                    // P3, p4
                    //Z2Red = P3 ×L + P4 ×L
                    float z2_R = (c3.R * L) + (c4.R * X_Fraction);
                    //Z2Green = P3 ×L + P4 ×L
                    float z2_G = (c3.G * L) + (c4.G * X_Fraction);
                    //Z2Blue = P3 ×L + P4 ×L
                    float z2_B = (c3.B * L) + (c4.B * X_Fraction);


                    // Interpolate In Y- direction
                    // NewPixel = Z1 × (1 – FractionY) + Z2 ×FractionY
                    // NewBuffer[Xnew, Ynew] = NewPixel;

                    int Final_R = (int)((z1_R * (1 - Y_Fraction)) + (z2_R * Y_Fraction));
                    int Final_G = (int)((z1_G * (1 - Y_Fraction)) + (z2_G * Y_Fraction));
                    int Final_B = (int)((z1_B * (1 - Y_Fraction)) + (z2_B * Y_Fraction));

                    Color NewPixel = Color.FromArgb(Final_R, Final_G, Final_B);

                    FitImage_NewImage2_BuffArray[x, y] = NewPixel;

                }
            }

            // Load From The New fitted Buffer To Bitmap image2 and set its buffer too

            //image2 buffer 
            Image2_bufferarr = new Color[FitImage_NewImage2_BuffArray.GetLength(0), FitImage_NewImage2_BuffArray.GetLength(1)];

            //Height Loop
            for (int j = 0; j < FitImage_NewImage2_BuffArray.GetLength(1); j++)
            {
                //width Loop
                for (int i = 0; i < FitImage_NewImage2_BuffArray.GetLength(0); i++)
                {
                    //Copy From The buffer To image2 buffer
                    Image2_bufferarr[i, j] = FitImage_NewImage2_BuffArray[i, j];

                    Color p = FitImage_NewImage2_BuffArray[i, j];
                    //Setting Pixels in new image2 To display it 
                    FitImage.SetPixel(i, j, p);
                }
            }

            Image2 = new Bitmap(FitImage);
        }

        //Add Operation
        private void Apply_Add_Opertaion(float Userinput)
        {
            //check length buffer
            ResultImage_bufferarr = new Color[Image1_bufferarr.GetLength(0), Image1_bufferarr.GetLength(1)];
            //check length bufferBitmap
            ResultImage = new Bitmap(Image1_bufferarr.GetLength(0), Image1_bufferarr.GetLength(1));


            for (int y = 0; y < Image1_bufferarr.GetLength(1); y++)
            {
                
                for (int x = 0; x < Image1_bufferarr.GetLength(0); x++)
                {
                    //Trackbar (Userinput) from 0 To 100 We Divide that values  by 100
                    //Img1 × fraction 
                    float Red_Result1 = Image1_bufferarr[x, y].R * (Userinput / 100);
                    float Green_Result1 = Image1_bufferarr[x, y].G * (Userinput / 100);
                    float Blue_Result1 = Image1_bufferarr[x, y].B * (Userinput / 100);

                    //Img2 × (1 – fraction)
                    float Red_FinalResult = Red_Result1 + (Image2_bufferarr[x, y].R * (1 - (Userinput / 100)));
                    float Green_FinalResult = Green_Result1 + (Image2_bufferarr[x, y].G * (1 - (Userinput / 100)));
                    float Blue_FinalResult = Blue_Result1 + (Image2_bufferarr[x, y].B * (1 - (Userinput / 100)));
                    //NewVal = Img1 × fraction + Img2 × (1 – fraction)
                    //fraction: user input between 0 and 1 to specify the participation percentage of each image in the result 
                    //here the track bar value.
                    Color NewPixel = Color.FromArgb((int)Red_FinalResult, (int)Green_FinalResult, (int)Blue_FinalResult);

                    ResultImage_bufferarr[x, y] = NewPixel;
                    ResultImage.SetPixel(x, y, NewPixel);
                }
            }

            ImageRes_PictureBox.Image = ResultImage;
            ImageRes_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        //Subtract Operation
        private void Apply_Subtract_Opertaion()
        {
            //check length buffer
            ResultImage_bufferarr = new Color[Image1_bufferarr.GetLength(0), Image1_bufferarr.GetLength(1)];
            //check length bufferBitmap
            ResultImage = new Bitmap(Image1_bufferarr.GetLength(0), Image1_bufferarr.GetLength(1));

            for (int y = 0; y < Image1_bufferarr.GetLength(1); y++)
            {
         
                for (int x = 0; x < Image1_bufferarr.GetLength(0); x++)
                {
                    float Red_FinalResult = Image1_bufferarr[x, y].R - Image2_bufferarr[x, y].R;
                    float Green_FinalResult = Image1_bufferarr[x, y].G - Image2_bufferarr[x, y].G;
                    float Blue_FinalResult = Image1_bufferarr[x, y].B - Image2_bufferarr[x, y].B;

                
                    // post Processing : Normalization
                    if (Red_FinalResult < 0)
                        Red_FinalResult = 0;
                    else if (Red_FinalResult > 255)
                        Red_FinalResult = 255;

                    if (Green_FinalResult < 0)
                        Green_FinalResult = 0;
                    else if (Green_FinalResult > 255)
                        Green_FinalResult = 255;

                    if (Blue_FinalResult < 0)
                        Blue_FinalResult = 0;
                    else if (Blue_FinalResult > 255)
                        Blue_FinalResult = 255;


                    Color NewPixel = Color.FromArgb((int)Red_FinalResult, (int)Green_FinalResult, (int)Blue_FinalResult);

                   ResultImage_bufferarr[x, y] = NewPixel;
                    ResultImage.SetPixel(x, y, NewPixel);
                }
            }

            ImageRes_PictureBox.Image = ResultImage;
            ImageRes_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Not Operation
        private void Apply_Not_Operation_Image1()
        {
            ////check length buffer
            ResultImage_bufferarr = new Color[Image1_bufferarr.GetLength(0), Image1_bufferarr.GetLength(1)];
            //check length bufferBitmap
            ResultImage = new Bitmap(Image1_bufferarr.GetLength(0), Image1_bufferarr.GetLength(1));
            
            //Both Images Same length So we can loop on any Of Them
            for (int y = 0; y < Image1_bufferarr.GetLength(1); y++)
            {
                //Width Loop
                for (int x = 0; x < Image1_bufferarr.GetLength(0); x++)
                {
                    //newval= 255-oldval
                    float Red_FinalResult = 255 - Image1_bufferarr[x, y].R;
                    float Green_FinalResult = 255 - Image1_bufferarr[x, y].G;
                    float Blue_FinalResult = 255 - Image1_bufferarr[x, y].B;

                    Color NewPixel = Color.FromArgb((int)Red_FinalResult, (int)Green_FinalResult, (int)Blue_FinalResult);

                    ResultImage_bufferarr[x, y] = NewPixel;
                    ResultImage.SetPixel(x, y, NewPixel);
                }
            }

            ImageRes_PictureBox.Image = ResultImage;
        }
        private void Apply_Not_Operation_Image2()
        {
            ////check length buffer
            ResultImage_bufferarr = new Color[Image2_bufferarr.GetLength(0), Image2_bufferarr.GetLength(1)];
            //check length bufferBitmap
            ResultImage = new Bitmap(Image2_bufferarr.GetLength(0), Image2_bufferarr.GetLength(1));


            
            for (int y = 0; y < Image2_bufferarr.GetLength(1); y++)
            {
                for (int x = 0; x < Image2_bufferarr.GetLength(0); x++)
                {
                    float Red_FinalResult = 255 - Image2_bufferarr[x, y].R;
                    float Green_FinalResult = 255 - Image2_bufferarr[x, y].G;
                    float Blue_FinalResult = 255 - Image2_bufferarr[x, y].B;

                    Color NewPixel = Color.FromArgb((int)Red_FinalResult, (int)Green_FinalResult, (int)Blue_FinalResult);

                    ResultImage_bufferarr[x, y] = NewPixel;
                    ResultImage.SetPixel(x, y, NewPixel);
                }
            }

            ImageRes_PictureBox.Image = ResultImage;
            ImageRes_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

 
       
     
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Image1 != null && Image2 != null && ComboBoxOpe.Text == "Add")
            {
                 AddLabel.Visible = true;
              ;
                trackBar_add.Visible = true;
                trackBar_add.Enabled = true;
                Apply_Button.Enabled = true;
                 labeladd.Visible = true;

                if (CurrentValue != trackBar_add.Value)
                {
                    Apply_Add_Opertaion(trackBar_add.Value);
                    CurrentValue = trackBar_add.Value;
                }
            }
            else if (Image1 != null && Image2 != null && ComboBoxOpe.Text == "Subtract")
            {
                AddLabel.Visible = false;
                trackBar_add.Visible = false;
                trackBar_add.Enabled = false;
                Apply_Button.Enabled = true;
                labeladd.Visible = false;;
                Apply_Subtract_Opertaion();
            }

            else if (Image1 != null & ComboBoxOpe.Text == "Not Image1")
            {
                AddLabel.Visible = false;
                trackBar_add.Visible = false;
                trackBar_add.Enabled = false;
                Apply_Button.Enabled = true;
                labeladd.Visible = false;
                Apply_Not_Operation_Image1();
            }

            else if (Image2 != null && ComboBoxOpe.Text == "Not Image2")
            {
                AddLabel.Visible = false;
                trackBar_add.Visible = false;
                trackBar_add.Enabled = false;
                Apply_Button.Enabled = true;
                labeladd.Visible = false;
                Apply_Not_Operation_Image2();
            }
        }

       



        private void F3_CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //Browse first image
        private void FirstImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Open = new OpenFileDialog())
            {
               
                Open.Filter = "(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                if (Open.ShowDialog() == DialogResult.OK)
                {
                    Image1 = new Bitmap(Open.FileName);

                    BitmapImage1_To_Buffer(Image1);

                    Image1_PictureBox.Image = Image1;
                    Image1_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
        //Browse Seconed Image
        private void SecondImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Open2 = new OpenFileDialog())
            {
                Open2.Filter = "(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"; ;

                if (Open2.ShowDialog() == DialogResult.OK)
                {
                    Image2 = new Bitmap(Open2.FileName);

                    BitmapImage2_To_Buffer(Image2);

                    Image2_PictureBox.Image = Image2;
                    Image2_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            Bitmap bit = (Bitmap)ImageRes_PictureBox.Image.Clone();
            ImageRes_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)bit;
            Form1.Instance.pictureBoxInputImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Form1.Instance.ModifiedInputImage = (Bitmap)bit;
            Form1.Instance.temp_BufferImgArray = ResultImage_bufferarr;
            this.Invalidate();
            this.Close();
        }

        private void trackBar_add_Scroll(object sender, EventArgs e)
        {
            AddLabel.Text = trackBar_add.Value.ToString();
        }

      

        
    }
}
