using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_ProcessingPackage
{
    public class EnhancementsOperations
    {
        //adjust brightness for image
        public static Color[,] adjustBrightness(Color[,] image_buffer, int offset)
        {
            int Height = image_buffer.GetLength(1);
            int Width = image_buffer.GetLength(0);

            Color[,] output_buffer = new Color[Height, Width];

            for (int y = 0; y < image_buffer.GetLength(1); y++)
                for (int x = 0; x < image_buffer.GetLength(0); x++)
                {
                    int red = offset + image_buffer[x, y].R;
                    if (red > 255)
                        red = 255;
                    if(red < 0)
                        red = 0;

                    int green = offset + image_buffer[x, y].G;
                    if (green > 255)
                        green = 255;
                    if(green < 0)
                        green = 0;

                    int blue = offset + image_buffer[x,y].B;
                    if (blue > 255)
                        blue = 255;
                    if (blue < 0)
                        blue = 0;
                    Color c =Color.FromArgb(red, green, blue);
                    output_buffer[y,x] =c ;
                }
            return output_buffer;
        }

        //adjust gamma correction
        public static Color[,] adjustGamma(Color[,] input_image_buffer, double gamma)
        {
            int Height = input_image_buffer.GetLength(1);
            int Width = input_image_buffer.GetLength(0);

            Color[,] output_buffer = new Color[Height,Width];
            
            double red, green,blue;
            int new_red, new_green, new_blue;

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                {
                    red = input_image_buffer[x, y].R;
                    green = input_image_buffer[x, y].G;
                    blue = input_image_buffer[x, y].B;

                    new_red = (int)Math.Pow(red, gamma);
                    if (new_red > 255)
                        new_red = 255;
                    if (new_red < 0)
                        new_red = 0;
                    new_green = (int)Math.Pow(green, gamma);
                    if (new_green > 255)
                        new_green = 255;
                    if (new_green < 0)
                        new_green = 0;
                    new_blue = (int)Math.Pow(blue, gamma);
                    if (new_blue > 255)
                        new_blue = 255;
                    if (new_blue < 0)
                        new_blue = 0;
                   
                   
                   
                    Color co = Color.FromArgb(new_red, new_green, new_blue);
                    output_buffer[y,x] = co;
                }
            return output_buffer; 
        }

        //To Gray scale
        public static Color[,] GrayScale(Color[,] input_image_buffer)
        {
            int Height = input_image_buffer.GetLength(1);
            int Width = input_image_buffer.GetLength(0);

            Color[,] output_buffer = new Color[Height, Width];
            
            double red, green,blue;
            int new_red, new_green, new_blue;

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                {
                    red = input_image_buffer[x, y].R;
                    green = input_image_buffer[x, y].G;
                    blue = input_image_buffer[x, y].B;

                    new_red = (int)(red + green + blue) / 3;
                    new_green = (int)(red + green + blue) / 3;
                    new_blue = (int)(red + green + blue) / 3;
                
                    output_buffer[y, x] = Color.FromArgb(new_red, new_green, new_blue);
                }
            return output_buffer;
            
        }

        //adjust contrast
        public static Color[,] Adjust_ImageContrast(Color[,] image_buffer, int Amount)
        {
            float OldRmax, OldRmin, OldGmax, OldGmin, OldBmax, OldBmin;
            OldRmax = OldGmax = OldBmax= -1;
            OldRmin= OldGmin = OldBmin = 255;

            float NewRmax, NewRmin, NewGmin, NewGmax, NewBmax, NewBmin;

            
            for (int y = 0; y < image_buffer.GetLength(1); y++)
            {
                
                for (int x = 0; x < image_buffer.GetLength(0); x++)
                {
                    //Red Value
                    if (image_buffer[x, y].R > 0 && image_buffer[x, y].R > OldRmax)
                        OldRmax = image_buffer[x, y].R;
                    if (image_buffer[x, y].R > 0 && image_buffer[x, y].R < OldRmin)
                        OldRmin = image_buffer[x, y].R;

                    //Green Value
                    if (image_buffer[x, y].G > 0 && image_buffer[x, y].G >OldGmax)
                        OldGmax = image_buffer[x, y].G;
                    if (image_buffer[x, y].G > 0 && image_buffer[x, y].G < OldGmin)
                        OldGmin = image_buffer[x, y].G;

                    //Blue Value
                    if (image_buffer[x, y].B > 0 && image_buffer[x, y].B > OldBmax)
                        OldBmax = image_buffer[x, y].B;
                    if (image_buffer[x, y].B > 0 && image_buffer[x, y].B < OldBmin)
                        OldBmin = image_buffer[x, y].B;
                }
            }


            NewRmax = OldRmax + Amount;
            NewRmin = OldRmin + (-Amount);

           NewGmax= OldGmax + Amount;
           NewGmin= OldGmin + (-Amount);

            NewBmax= OldBmax + Amount;
            NewBmin= OldBmin + (-Amount);


            
            for (int y = 0; y < image_buffer.GetLength(1); y++)
            {
            
                for (int x = 0; x < image_buffer.GetLength(0); x++)
                {
                    //All Result1 Must be From 1 to 0
                    float Red_Result1 = (image_buffer[x,y].R - OldRmin) / (OldRmax - OldRmin);
                    float Green_Result1 = (image_buffer[x,y].G - OldGmin) / (OldGmax - OldGmin);
                    float Blue_Result1 = (image_buffer[x,y].B - OldBmin) / (OldBmax - OldBmin);


                    float RedResult_Final = ((Red_Result1 * (NewRmax - NewRmin)) + NewRmin);
                    float GreenResult_Final = ((Green_Result1 * (NewGmax- NewGmin)) + NewGmin);
                    float BlueResult_Final = ((Blue_Result1 * (NewGmax - NewBmin)) + NewBmin);

                    if (RedResult_Final < 0)
                        RedResult_Final = 0;
                    else if (RedResult_Final > 255)
                        RedResult_Final = 255;

                    if (GreenResult_Final < 0)
                        GreenResult_Final = 0;
                    else if (GreenResult_Final > 255)
                        GreenResult_Final = 255;

                    if (BlueResult_Final < 0)
                        BlueResult_Final = 0;
                    else if (BlueResult_Final > 255)
                        BlueResult_Final = 255;
                  //Putting The NewPixel
                    Color NewPixel = Color.FromArgb((int)RedResult_Final, (int)GreenResult_Final, (int)BlueResult_Final);
                    image_buffer[x,y] = NewPixel;
                }

            }
            return image_buffer;
        }
    }
}
