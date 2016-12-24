using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_ProcessingPackage
{
    public partial class Image_Enhancement : Form
    {
        private Color[,] Image1_Array_Modified;
        //Original image buffer array
        private Color[,] Image1_Array;
        public  Bitmap temp;
        public Bitmap TestImage_Modified; 
        private int CurrentBrighntesValue = 0;
        private int CurrentContrastValue = 0;
        private float CurrentGammaValue = 0;

        public Image_Enhancement()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            //Instance = this;
            
            if (Form1.Instance.ModifiedInputImage == null)
            {
                Bitmap temp = (Bitmap)Form1.Instance.InputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                Image_befor_picbox.Image = temp;
                Image_befor_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                image_afterpicbpx.Image = temp;
                image_afterpicbpx.SizeMode = PictureBoxSizeMode.StretchImage;
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
            Image_befor_picbox.Image = temp;
            Image_befor_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            image_afterpicbpx.Image = temp;
            image_afterpicbpx.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Invalidate();
            Image1_Array_Modified = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
            Image1_Array = new Color[Form1.Instance.temp_BufferImgArray.GetLength(0), Form1.Instance.temp_BufferImgArray.GetLength(1)];
            Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, Image1_Array_Modified);
            Copy_Bufffer_to_Another(Form1.Instance.temp_BufferImgArray, Image1_Array);

            }
           //Reset trAck bars
           CurrentBrighntesValue = trackBar_Birghtness.Value = 0;
           CurrentContrastValue = trackBar_Contrast.Value = 0;
           CurrentGammaValue = trackBar1.Value = 1000;
           Brightness_label.Text = trackBar_Birghtness.Value.ToString();
           contrast_bar_label.Text = trackBar_Contrast.Value.ToString();
           float m = trackBar1.Value;
           float x = m / 1000;
           gamma_bar_label.Text = x.ToString();     
        }


        private void Copy_Bufffer_to_Another(Color[,] array1, Color[,] array2)
        {
            for (int y = 0; y< array1.GetLength(1); y++)
            {
                for (int x = 0; x < array1.GetLength(0); x++)
                {
                    array2[x,y] = array1[x,y];
                }
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.ModifiedInputImage == null)
            {
                temp = (Bitmap)Form1.Instance.InputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                image_afterpicbpx.Image = temp;
                image_afterpicbpx.SizeMode = PictureBoxSizeMode.StretchImage;
                Image1_Array_Modified = Form1.Instance.InputImage_BufferArray;    
                //Image_befor_picbox.Image = temp;
                this.Invalidate();
            }
            else {
                temp = (Bitmap)Form1.Instance.ModifiedInputImage.Clone();
                //Form1.Instance.InputImage = (Bitmap)temp.Clone();
                //Form1.Instance.pictureBoxInputImage.Image = (Bitmap)temp.Clone();
                image_afterpicbpx.Image = temp;
                image_afterpicbpx.SizeMode = PictureBoxSizeMode.StretchImage;
                Image1_Array_Modified = Form1.Instance.temp_BufferImgArray;
                //Image_befor_picbox.Image = temp;
                this.Invalidate();
            }
            CurrentBrighntesValue = trackBar_Birghtness.Value = 0;
            CurrentContrastValue = trackBar_Contrast.Value = 0;
             CurrentGammaValue = trackBar1.Value = 1000;
              Brightness_label.Text = trackBar_Birghtness.Value.ToString();
            contrast_bar_label.Text = trackBar_Contrast.Value.ToString();

            float m = trackBar1.Value;
            float x = m / 1000;
            gamma_bar_label.Text = x.ToString();
            Grayscalebutton.Enabled = true;
        }



        private void Apply_Button_Click(object sender, EventArgs e)
        {
            Bitmap bit = (Bitmap)image_afterpicbpx.Image.Clone();
            Image_befor_picbox.Image = bit;
            image_afterpicbpx.Image = bit;
            bit = (Bitmap)Image_befor_picbox.Image;
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)bit;
            Form1.Instance.ModifiedInputImage = (Bitmap)bit;
            Form1.Instance.temp_BufferImgArray = Image1_Array_Modified;
            //Form1.Instance.InputImage_BufferArray = Image1_Array_Modified;
            this.Invalidate();
            this.Close();
            //Reset track bars
            CurrentBrighntesValue = trackBar_Birghtness.Value = 0;
            CurrentContrastValue = trackBar_Contrast.Value = 0;
            CurrentGammaValue = trackBar1.Value = 1000;

            Brightness_label.Text = trackBar_Birghtness.Value.ToString();
            contrast_bar_label.Text = trackBar_Contrast.Value.ToString();
            float m = trackBar1.Value;
            float x = m / 1000;
            gamma_bar_label.Text = x.ToString();      
        }

        private void Ok_Button_Click(object sender, EventArgs e)
        {
            Bitmap bit = (Bitmap)TestImage_Modified.Clone();
            Image_befor_picbox.Image = bit;
            Image_befor_picbox.Image = bit;
            bit = (Bitmap)Image_befor_picbox.Image;
            Form1.Instance.pictureBoxInputImage.Image = (Bitmap)bit;
            Form1.Instance.ModifiedInputImage = (Bitmap)bit;
            Form1.Instance.temp_BufferImgArray = Image1_Array_Modified;
            this.Invalidate();
            this.Close();
        }

        private void Grayscalebutton_Click(object sender, EventArgs e)
        {
            Image1_Array = EnhancementsOperations.GrayScale(Image1_Array_Modified);
            ImageOperations.DisplayImage(image_afterpicbpx, Image1_Array);
        }




        private void GEtOutColors(Color color)
        {
            double[] Histogram_colorCount = new double[256];
            // Make All counts in the Array is 0
            Array.Clear(Histogram_colorCount, 0, Histogram_colorCount.Length);
            double MaxValue = -1;
            //Getting frequency color
            for (int y = 0; y < Image1_Array_Modified.GetLength(1); y++)
            {
                for (int x = 0; x < Image1_Array_Modified.GetLength(0); x++)
                {

                    if (color == Color.Red)
                    {
                        int redValue = Image1_Array_Modified[x,y].R;
                        Histogram_colorCount[redValue]++;
                    }
                    else if (color == Color.Green)
                    {
                        int GreemValue = Image1_Array_Modified[x, y].G;
                        Histogram_colorCount[GreemValue]++;
                    }
                    else if (color == Color.Blue)
                    {
                        int BlueValue = Image1_Array_Modified[x, y].B;
                        Histogram_colorCount[BlueValue]++;
                    }
                }
            }

            //Getting Max Value

            for (int n = 0; n < Histogram_colorCount.Length; n++)
            {
                if (Histogram_colorCount[n] > MaxValue)
                    MaxValue = Histogram_colorCount[n];
            }

            //Normalize The Values by max Value,
            //Then Multiplay them by pic bob height

            for (int p = 0; p < Histogram_colorCount.Length; p++)
            {
                Histogram_colorCount[p] = (Histogram_colorCount[p] / MaxValue) * histogrampic_box.Height;
            }
            GenerateHistogram(Histogram_colorCount, color);
        }

        // Drawing histogram
        public void GenerateHistogram(double[] histogramVal, Color c)
        {

            //Getting Width Of the Pen
            float PenWidth = histogrampic_box.Width / 256;
            //Clear all Colors First
            histogrampic_box.CreateGraphics().Clear(Color.Gainsboro);
            //Create pen
            Pen blackPen = new Pen(c, PenWidth);
            for (int i = 0; i < histogramVal.Length; i++)
            {

                float StartFromRight = (PenWidth + (PenWidth * i));
                //Create points that define line.
                PointF point1 = new PointF(StartFromRight, histogrampic_box.Height);
                float FixingHight = (float)((histogramVal[i] - histogrampic_box.Height) * -1);
                PointF point2 = new PointF(StartFromRight, FixingHight);

                //Draw
                histogrampic_box.CreateGraphics().DrawLine(blackPen, point1, point2);
                histogrampic_box.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void Red_button_histo_Click(object sender, EventArgs e)
        {
            GEtOutColors(Color.Red);
        }

        private void Green_button_histo_Click(object sender, EventArgs e)
        {
            GEtOutColors(Color.Green);
        }

        private void Blue_butto_histo_Click(object sender, EventArgs e)
        {
            GEtOutColors(Color.Blue);
        }
      
   
        private void trackBar1_Scroll(object sender, EventArgs e)
        {  
            Brightness_label.Text = trackBar_Birghtness.Value.ToString();
            Image1_Array_Modified = EnhancementsOperations.adjustBrightness(Image1_Array, trackBar_Birghtness.Value);
           // TestImage_Modified = new Bitmap(Image1_Array_Modified.GetLength(0), Image1_Array_Modified.GetLength(1));
            ImageOperations.DisplayImage(image_afterpicbpx, Image1_Array_Modified);
            image_afterpicbpx.SizeMode = PictureBoxSizeMode.StretchImage;
            //Bitmap t = (Bitmap)image_afterpicbpx.Image.Clone();
            //image_afterpicbpx.Image =t;
            //this.Invalidate();


        }

        private void trackBar_Contrast_Scroll(object sender, EventArgs e)
        {
            contrast_bar_label.Text = trackBar_Contrast.Value.ToString();
            Image1_Array_Modified = EnhancementsOperations.Adjust_ImageContrast(Image1_Array, trackBar_Contrast.Value);
            ImageOperations.DisplayImage(image_afterpicbpx, Image1_Array_Modified);
            TestImage_Modified = new Bitmap(Image1_Array_Modified.GetLength(0), Image1_Array_Modified.GetLength(1));
          

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            float m = trackBar1.Value;
            float x = m / 1000;
            gamma_bar_label.Text = x.ToString();
            Image1_Array = EnhancementsOperations.adjustGamma(Image1_Array_Modified, x);
            ImageOperations.DisplayImage(image_afterpicbpx, Image1_Array);
            //TestImage_Modified = new Bitmap(Image1_Array_Modified.GetLength(0), Image1_Array_Modified.GetLength(1));
           

        }

        private void Image_Enhancement_Load(object sender, EventArgs e)
        {

        }
    }
}
