using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_ProcessingPackage
{
    class KircshMatrcies
    {


        public static double[,] Kirsch3x3Horizontal
        {
            get
            {
                return new double[,] 
                { {  5,  5,  5, }, 
                  { -3,  0, -3, }, 
                  { -3, -3, -3, }, };
            }
        }

        public static double[,] Kirsch3x3Vertical
        {
            get
            {
                return new double[,] 
                { {  5, -3, -3, }, 
                  {  5,  0, -3, }, 
                  {  5, -3, -3, }, };
            }
        }
        public static double[,] Kirsch3x3Daigonal1
        {
            get
            {
                return new double[,] 
                { {  -3,  5,  5, }, 
                  { -3,  0, 5, }, 
                  { -3, -3, -3, }, };
            }
        }

        public static double[,] Kirsch3x3Daigonal2
        {
            get
            {
                return new double[,] 
                { {  5, 5, -3, }, 
                  {  5,  0, -3, }, 
                  {  -3, -3, -3, }, };
            }
        }

        public Color[,] convluteKirshfilter(double[,] matrices, Color[,] bufferimage)
        {
            int orginalimage_height = bufferimage.GetUpperBound(1);
            int orginalimage_width = bufferimage.GetUpperBound(0);
            Color[,] filteredimage_buffer = new Color[orginalimage_width, orginalimage_height];




            for (int y_image = 0; y_image < orginalimage_height; y_image++)
            {
                for (int x_image = 0; x_image < orginalimage_width; x_image++)
                {
                    int color_value_red = 0;
                    int color_value_green = 0;
                    int color_value_blue = 0;
                    Color pixel = new Color();

                    try
                    {
                        for (int y_filter = 0; y_filter < matrices.GetLength(1); y_filter++)
                        {
                            for (int x_filter = 0; x_filter < matrices.GetLength(0); x_filter++)
                            {
                                color_value_red += (int)(matrices[x_filter, y_filter] * (double)(bufferimage[(y_image + y_filter), (x_filter + x_image)].R));
                                color_value_green += (int)(matrices[x_filter, y_filter] * (double)(bufferimage[(y_filter + y_image), (x_filter + x_image)].G));
                                color_value_blue += (int)(matrices[x_filter,y_filter] * (double)(bufferimage[(y_filter + y_image), (x_filter + x_image)].B));
                            }
                        }
                        //cut off 
                        if (color_value_red > 255)
                            color_value_red = 255;
                        if (color_value_green > 255)
                            color_value_green = 255;
                        if (color_value_blue > 255)
                            color_value_blue = 255;

                        if (color_value_red < 0)
                            color_value_red = 0;
                        if (color_value_green < 0)
                            color_value_green = 0;
                        if (color_value_blue < 0)
                            color_value_blue = 0;

                        pixel = Color.FromArgb(color_value_red, color_value_green, color_value_blue);
                        filteredimage_buffer[x_image + matrices.GetLength(0), y_image + matrices.GetLength(1)] = pixel;
                    
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                }
            }
            return filteredimage_buffer;

        }
    }
}
