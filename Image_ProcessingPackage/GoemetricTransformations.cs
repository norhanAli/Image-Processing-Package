using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Image_ProcessingPackage
{
    class GoemetricTransformations
    {
        public static Color[,] geometricLinearTransformations(Color[,] original_buffer, Matrix W)
        {
            //(1)Calculate width & height of new buffer:
            //==========================================
            int original_width = original_buffer.GetLength(1);
            int original_height = original_buffer.GetLength(0);
        
      
            Point ptn_corner = new Point();
            Point[] corners = new Point[4];

            int []X_coordinates = new int [4];
            int[] Y_coordinates = new int [4];

            //(a) Points at the corners of original image.
            //========================================
            
            //corner at (0 , 0):
            ptn_corner.X = 0;
            ptn_corner.Y = 0;
            corners[0] = ptn_corner;

            //corner at (old width , 0):
            ptn_corner.X = original_width-1;
            ptn_corner.Y = 0;
            corners[1] = ptn_corner;
            
            //corner at (0, old height):
            ptn_corner.X = 0;
            ptn_corner.Y = original_height-1;
            corners[2] = ptn_corner;

            //corner at (old width , old height)
            ptn_corner.X = original_width-1;
            ptn_corner.Y = original_height-1;
            corners[3] = ptn_corner;

       // (b) direct mapping of original image corners:
       //===========================================

            W.TransformPoints(corners);
            for (int i = 0; i < 4; i++)
            {
                X_coordinates[i] = corners[i].X;
                Y_coordinates[i] = corners[i].Y;
            }

           int max_x = X_coordinates.Max();
           int min_x = X_coordinates.Min();

           int max_y = Y_coordinates.Max();
           int min_y = Y_coordinates.Min();

           int new_width = max_x - min_x;
           int new_height = max_y - min_y;

        //(2)Append a translation vector [- min_x,-min_y] with W:
       //========================================================
           W.Translate(-min_x, -min_y);
           Matrix I = new Matrix();
           I.Multiply(W, MatrixOrder.Append);
       //(3)Invert W matrix:
      //======================
           W.Invert();
           
      //(4)Create new buffer:
     //======================
           Color[,] Transformed_buffer = new Color[new_height, new_width];

    //(5)For each pixel location in new buffer do:
    //=============================================
           Point[] new_buffer_loctions = new Point[(new_height * new_width)];
           
            int k = 0;

            //(a)Find old locations  
           //========================
            for (int y = 0; y < new_height; y++)
            {
                for (int x = 0; x < new_width; x++)
                {
                    Point ptn1 = new Point();
                    ptn1.X = y;
                    ptn1.Y = x;

                    new_buffer_loctions[k++] = ptn1;
                }
            }
            W.TransformPoints(new_buffer_loctions);
           
           //(b) validate that the old location lies in the original image:
           //================================================================

                int l = 0;
                for (int y = 0; y < new_height; y++)
                {
                    for (int x = 0; x < new_width; x++)
                    {
                        
                        

                        //if pixel belongs to original image new pexil value is interpolation of old pixels values:
                        //=========================================================================================
                        if ((new_buffer_loctions[l].X >= 0) && (new_buffer_loctions[l].X < original_height - 1)
                            && (new_buffer_loctions[l].Y >= 0) && (new_buffer_loctions[l].Y < original_width - 1))
                        {
                           
                            // (6) Bilinear Interpolation of pixels value:
                            //============================================
                            // (6.1) Find the four adjacent pixels:
                            //========================================
                            int x1 = (int)(Math.Floor((double)new_buffer_loctions[l].X));
                            int y1 = (int)(Math.Floor((double)new_buffer_loctions[l].Y));
                            int x2 = x1 + 1;
                            int y2 = y1 + 1;

                            Color[] neighbors = new Color[4];

                            neighbors[0] = original_buffer[x1, y1];
                            neighbors[1] = original_buffer[x2, y1];
                            neighbors[2] = original_buffer[x1, y2];
                            neighbors[3] = original_buffer[x2, y2];

                            //(6.2) calculate xfraction and y fraction:
                            //===========================================
                            double x_fraction = new_buffer_loctions[l].X - x1;
                            double y_fraction = new_buffer_loctions[l].Y - y1;

                            //(6.3) Interpolate in x direction:
                            //==================================
                            Color Z1 = new Color();
                            Color Z2 = new Color();

                            double z1_double = ((double)(neighbors[0].ToArgb()) * (1 - x_fraction)
                                        + (double)(neighbors[1].ToArgb()) * x_fraction);

                            double z2_double = ((double)(neighbors[2].ToArgb()) * (1 - x_fraction)
                                        + (double)(neighbors[3].ToArgb()) * x_fraction);

                            //(6.4) Interpolate in y direction:
                            //===================================
                            Z1 = Color.FromArgb((int)z1_double);
                            Z2 = Color.FromArgb((int)z2_double);
                            Color new_pixel = new Color();

                            int new_pixel_int = (int)((double)(Z1.ToArgb()) * (1 - y_fraction)
                                        + (double)(Z2.ToArgb()) * y_fraction);

                            new_pixel = Color.FromArgb(new_pixel_int);

                            Transformed_buffer[y,x] = new_pixel;
                            l++;
                        }

                        else
                        {
                            Transformed_buffer[y,x] = Color.Black;
                            l++;
                        }
                    }
                }
                
            //l++;
            return Transformed_buffer;
        }
    }
}
        