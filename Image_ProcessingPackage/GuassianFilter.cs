using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_ProcessingPackage
{
    class GuassianFilter
    {
        //Gaussian Filter Option(1):
        //================================
        public static Color[,] GuassianFilterOption1(int mask_height, int mask_width, double sigma, Color[,] org_image_buffer)
        {
            int org_image_height = org_image_buffer.GetLength(1);
            int org_image_width = org_image_buffer.GetLength(0);

            Color[,] filtered_image_buffer = new Color[org_image_width, org_image_height];

            double mask_coefficients_sum = 0;
            double[,] Guassian_mask = new double[mask_width, mask_height];


            // constructing guassian mask coeffients:
            //========================================

            for (int y = 0; y < mask_width; y++)
                for (int x = 0; x < mask_height; x++)
                {
                    Guassian_mask[y, x] = (1 / (2 * Math.PI * (Math.Pow(sigma, 2)))) * (Math.Pow(Math.E, (-1 * ((Math.Pow(x, 2)) + Math.Pow(y, 2) / (2 * Math.Pow(sigma, 2))))));
                    mask_coefficients_sum += Guassian_mask[y,x];
                }

            //Normalizing guassian mask coeffients:
            //========================================

            for (int y = 0; y < mask_width; y++)
                for (int x = 0; x < mask_height; x++)
                    Guassian_mask[x, y] = Guassian_mask[x, y] / mask_coefficients_sum;

            //Convoluting the mask on image:
            //===============================
            for (int y_image = 0; y_image < org_image_width; y_image++)
            {
                for (int x_image = 0; x_image < org_image_height; x_image++)
                {
                    int color_value_red = 0;
                    int color_value_green = 0;
                    int color_value_blue = 0;
                    Color pixel = new Color();

                    try
                    {
                        for (int y_filter = 0; y_filter < mask_width; y_filter++)
                        {
                            for (int x_filter = 0; x_filter < mask_height; x_filter++)
                            {
                                color_value_red += (int)(Guassian_mask[y_filter, x_filter] * (double)(org_image_buffer[(y_image + y_filter), (x_filter + x_image)].R));
                                color_value_green += (int)(Guassian_mask[y_filter, x_filter] * (double)(org_image_buffer[(y_filter + y_image), (x_filter + x_image)].G));
                                color_value_blue += (int)(Guassian_mask[y_filter, x_filter] * (double)(org_image_buffer[(y_filter + y_image), (x_filter + x_image)].B));
                                pixel = Color.FromArgb(color_value_red, color_value_green, color_value_blue);
                            }
                        }
                        filtered_image_buffer[x_image + mask_width,y_image + mask_height] = pixel; //Color.FromArgb(color_value_red, color_value_green, color_value_blue);
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                }
            }
            return filtered_image_buffer;
        }

        // Gaussian filter option(2):
        //============================

        public static Color[,] GuassianFilterOption2(double sigma, Color[,] org_image_buffer)
        {
            int org_image_height = org_image_buffer.GetLength(1);
            int org_image_width = org_image_buffer.GetLength(0);

            Color[,] filtered_image_buffer = new Color[org_image_width, org_image_height];

            double mask_coefficients_sum = 0;
            double[,] Guassian_mask;

            //Calculating mask size:
            //=======================
            int N = (int)(3.7 * sigma - 0.5);

            int mask_width = 2 * N + 1;
            int mask_height = 2 * N + 1;

            Guassian_mask = new double[mask_width, mask_height];

            // constructing guassian mask coeffients:
            //========================================

            for (int y = 0; y < mask_width; y++)
                for (int x = 0; x < mask_height; x++)
                {
                    Guassian_mask[y, x] = (1 / (2 * Math.PI * (Math.Pow(sigma, 2)))) * (Math.Pow(Math.E, (-1 * ((Math.Pow(x, 2)) + Math.Pow(y, 2) / (2 * Math.Pow(sigma, 2))))));
                    mask_coefficients_sum += Guassian_mask[x,y];
                }

            //Normalizing guassian mask coeffients:
            //========================================

            for (int y = 0; y < mask_width; y++)
                for (int x = 0; x < mask_height; x++)
                    Guassian_mask[x,y] = Guassian_mask[x,y] / mask_coefficients_sum;

            //Convoluting the mask on image:
            //===============================

            for (int y_image = 0; y_image < org_image_width; y_image++)
            {
                for (int x_image = 0; x_image < org_image_height; x_image++)
                {
                    int color_value_red = 0;
                    int color_value_green = 0;
                    int color_value_blue = 0;
                    Color pixel = new Color();

                    try
                    {
                        for (int y_filter = 0; y_filter < mask_width; y_filter++)
                        {
                            for (int x_filter = 0; x_filter < mask_height; x_filter++)
                            {
                                color_value_red += (int)(Guassian_mask[y_filter, x_filter] * (double)(org_image_buffer[(y_image + y_filter), (x_filter + x_image)].R));
                                color_value_green += (int)(Guassian_mask[y_filter, x_filter] * (double)(org_image_buffer[(y_filter + y_image), (x_filter + x_image)].G));
                                color_value_blue += (int)(Guassian_mask[y_filter, x_filter] * (double)(org_image_buffer[(y_filter + y_image), (x_filter + x_image)].B));
                                pixel = Color.FromArgb(color_value_red, color_value_green, color_value_blue);
                            }
                        }
                        filtered_image_buffer[x_image + mask_width,y_image + mask_height] = pixel; //Color.FromArgb(color_value_red, color_value_green, color_value_blue);
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                }
            }
            return filtered_image_buffer;
        }
    }
}
