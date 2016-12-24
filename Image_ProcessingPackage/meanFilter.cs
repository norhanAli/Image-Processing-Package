using System;
using System.Collections.Generic;
using System.Drawing;

namespace Image_ProcessingPackage
{
    class meanFilter
    {
        public static Color [,] maskfilter(int width, int height,Color [,] old_image)
        {
            int image_height = old_image.GetLength(0);
            int image_width = old_image.GetLength(1);

            Color[,] new_image  = new Color [image_height,image_width];

            double total = width * height;
            double[,] mask = new double[width, height];
            
            // Constructing mask coeffiecents:

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    mask[i, j] = (1 / total); 
                }
            }

            //Convolution of mask and image:

            for (int y_image = 0; y_image < image_width; y_image++)
            {
                for (int x_image = 0; x_image < image_height; x_image++)
                {
                    int color_value_red = 0;
                    int color_value_green = 0;
                    int color_value_blue = 0;
                    Color pixel = new Color();

                    try
                    {
                        for (int y_filter = 0; y_filter < width; y_filter++)
                        {
                            for (int x_filter = 0; x_filter < height; x_filter++)
                            {
                                color_value_red += (int)(mask[y_filter, x_filter] * (double)(old_image[(y_image + y_filter), (x_filter + x_image)].R));
                                color_value_green += (int)(mask[y_filter, x_filter] * (double)(old_image[(y_filter + y_image), (x_filter + x_image)].G));
                                color_value_blue += (int)(mask[y_filter, x_filter] * (double)(old_image[(y_filter + y_image), (x_filter + x_image)].B));
                                pixel = Color.FromArgb(color_value_red, color_value_green, color_value_blue);
                            }
                        }
                        new_image[x_image + width,y_image + height] = pixel; //Color.FromArgb(color_value_red, color_value_green, color_value_blue);
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                }
            }
            return new_image;
        }
    }
}
