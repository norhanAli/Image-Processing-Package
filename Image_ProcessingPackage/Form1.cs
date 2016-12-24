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
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public Bitmap InputImage;
        public Bitmap ModifiedInputImage;
        public Color[,] InputImage_BufferArray;
        public Color[,] BufferImage;
        public Color[,] temp_BufferImgArray;
        public Color[,] temp_BufferImage;
        private string PPM_Text = "";
        private double Zoom = 1.0;


        public string input_file_path;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Instance = this;
            saveToolStripMenuItem.Enabled = false;
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Open= new OpenFileDialog())
            {
                Open.Title = "Load Image";
                //Images format
                Open.Filter = "(*.jpg;*.png ;*.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif;*.png; *.bmp";
                try
                {
                    if (Open.ShowDialog() == DialogResult.OK)
                    {
                       readimage p = new readimage();
                       BufferImage = p.displayimage(Open.FileName);
                       InputImage = new Bitmap(BufferImage.GetLength(0), BufferImage.GetLength(1));
                        for (int x = 0; x < InputImage.Width; x++)
                        {
                            for (int y = 0; y < InputImage.Height; y++)
                            {
                                InputImage.SetPixel(x, y, BufferImage[x, y]);
                                // things we do with pixelColor
                            }
                        }
                        pictureBoxInputImage.Image = InputImage;
                        pictureBoxInputImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        Copy_BitMap_To_Buffer(InputImage);
                        saveToolStripMenuItem.Enabled = true;
                    }
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Invalid loading Image");
                    Application.Restart();
                }
            }
        }

        private void openP3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Open3 = new OpenFileDialog())
            {
                
                try
                {
                    if (Open3.ShowDialog() == DialogResult.OK)
                    {
                        //Get Full Path To OPen it Later
                        string fileName = Path.GetFullPath(Open3.FileName);


                        //Open Image 
                        FileStream fStream = File.Open(fileName, FileMode.Open, FileAccess.Read);

                        StreamReader SR = new StreamReader(fStream);

                        PPM_Text = SR.ReadToEnd();
                        fStream.Close();
                       Read_PPMText(PPM_Text);

                    }
                    pictureBoxInputImage.Image = InputImage;
                    //pictureBoxInputImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    Copy_BitMap_To_Buffer(InputImage);
                    saveToolStripMenuItem.Enabled = true;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Invalid loading Image");
                    Application.Restart();
                }
            }
        }

        //load bitmap to buffer function
        private void Copy_BitMap_To_Buffer(Bitmap X)
        {

            //Create New Array
            InputImage_BufferArray = new Color[X.Width, X.Height];
            //2D Array (Buffer)
            for (int i = 0; i < X.Width; i++)
            {
                for (int j = 0; j < X.Height; j++)
                {
                    //Get The Pixel At This Location
                    Color ThisPixel = X.GetPixel(i,j);
                    InputImage_BufferArray[i,j] = ThisPixel;
                }
            }
        }

        //Read ppm Images
        private void Read_PPMText(string T)
        {

            //Split The String By Lines
            string[] lines = T.Split('\n');
            //P3
            string Title = lines[0];
            //Comment
            string Comment = lines[1];
            //Image Dimensions Width[0] and height[1]
            string[] Dimentions = lines[2].Split(' ');

            int PPM_Width, PPM_Hieght;

            PPM_Width = PPM_Hieght = 0;

            if (Dimentions.Length == 2)
            {
                PPM_Width = int.Parse(Dimentions[0]);
                PPM_Hieght = int.Parse(Dimentions[1]);
            }
            //RGB Channel
            string MaxRBG = lines[3];

            StringBuilder STR = new StringBuilder();
            //Putting All Pixel Values in 1 String
            for (int i = 4; i < lines.Length; i++)
                STR.Append(lines[i]);


            //Getting All Pixel Values in Array
            string[] PixelValues = STR.ToString().Split(' ');

            // Load From String to buffer and bitmap
            //New Bitmap Image 
           InputImage= new Bitmap(PPM_Width, PPM_Hieght);
            //Also Load it into buffer
            BufferImage = new Color[PPM_Width, PPM_Hieght];
            int Counter = 0; //just To get the 3 values From (PixelValues)
            for (int y = 0; y < PPM_Hieght; y++)
            {
                for (int x = 0; x < PPM_Width; x++)
                {
                    //Setting Pixels in Input Image too display it 
                    InputImage.SetPixel(x, y, Color.FromArgb(int.Parse(PixelValues[Counter]), int.Parse(PixelValues[Counter + 1]), int.Parse(PixelValues[Counter + 2])));
                    //Also Load it into buffer
                    BufferImage[x, y] = Color.FromArgb(int.Parse(PixelValues[Counter]), int.Parse(PixelValues[Counter + 1]), int.Parse(PixelValues[Counter + 2]));
                    Counter += 3;
                   
                }
            }
        }

        private void imageEnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InputImage == null && ModifiedInputImage == null)
            {
                MessageBox.Show("Choose Image First");
                Application.Restart();
            
            }
            else
            {
                Image_Enhancement img = new Image_Enhancement();
                img.ShowDialog();
            }
           
        }

     

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
                Image_Algebra m = new Image_Algebra();
                m.ShowDialog();
            
        }

        private void option1UserInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InputImage == null && ModifiedInputImage == null)
            {
                MessageBox.Show(" Choose Image First :) ");
                Application.Restart();

            }
            else
            {
                Guassian_filter G = new Guassian_filter();
                G.ShowDialog();
            }


        }

        private void option2computedMaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InputImage == null && ModifiedInputImage == null)
            {
                MessageBox.Show(" Choose Image First :) ");
                Application.Restart();

            }
            else
            {

                GuassianFilterOption2 gi2 = new GuassianFilterOption2();
                gi2.ShowDialog();
            }
        }

        private void geometryOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InputImage == null && ModifiedInputImage==null)
            {
                MessageBox.Show(" Choose Image First :) ");
                Application.Restart();

            }
            else
            {
                GemotricTransform g = new GemotricTransform();
                g.ShowDialog();
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InputImage == null&&ModifiedInputImage == null)
            {
                MessageBox.Show(" Choose Image First :) ");
                Application.Restart();

            }
            else
            {
                Mean m = new Mean();
                m.ShowDialog();
            }
        }

        private void laplacianSharpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InputImage == null && ModifiedInputImage == null)
            {
                MessageBox.Show(" Choose Image First :) ");
                Application.Restart();

            }
            else
            {
                Laplacian_Filter L = new Laplacian_Filter();
                L.ShowDialog();
            }
        }

        private void kirschToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (InputImage == null && ModifiedInputImage == null)
            {
                MessageBox.Show(" Choose Image First :) ");
                Application.Restart();

            }
            else
            {
                Kircsh_filter k = new Kircsh_filter();
                k.ShowDialog();
            }
        }

       
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog Save= new SaveFileDialog())
            {
                Save.Title = "Save Image";
                Save.Filter = "Image Files (Jpg,Jpeg,Gif,Png,Bmp,PPM)|*.bmp;*.PPM;*jpg;*jpeg;*gif;*png;";

                if (Save.ShowDialog() == DialogResult.OK)
                {
                    string Ex = Path.GetExtension(Save.FileName);


                    if (Ex.ToLower() == ".bmp" || Ex.ToLower() == ".ppm" || Ex.ToLower() == ".jpg" || Ex.ToLower() == ".jpeg" || Ex.ToLower() == ".gif" || Ex.ToLower() == ".png")
                    {
                        pictureBoxInputImage.Image.Save(Save.FileName, ImageFormat.Bmp);
                       
                    }

                  
                }
            }
        }
        
}
}
