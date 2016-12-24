using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 
using System.Drawing.Imaging;

namespace Image_ProcessingPackage
{
    public class linearFilter
    {
        public  Color[,] lineFilter(Color[,] img, double[,] maskFilter, int origX, int origY)
        {
            /* no post-process parameter as mean filter doesn't need post processing */
           
            int mask_heigth = maskFilter.GetLength(1); 
            int mask_width = maskFilter.GetLength(0); 

           

            int img_height = img.GetLength(1); 
            int img_width = img.GetLength(0); 

            Color[,] padded_buffer = new Color[img_width+mask_width-1, img_height+mask_heigth-1];

            int widthPadded = padded_buffer.GetLength(0);
            int heightPadded = padded_buffer.GetLength(1);

            //padding with 0's
            int w=0, h=0; 
            for(int i=origX; ( i < widthPadded || w < img_width); i++){
                for(int j=origY; ( j < heightPadded && h < img_height); j++){
                    padded_buffer[i,j] = img[h++,w++];
                    
                }
            }

            Color[,] resultingImage = new Color[img_width, img_height]; 
            //blurring
            int red, green, blue;
            for(int i=0; i<img_width; i++){
                for(int j=0; j<img_height; j++){

                    red=0; green=0; blue=0; 

                    for(int ki = 0; ki<mask_width; ki++){
                        for(int kj = 0; kj<mask_heigth; kj++){
                             red += (int)(maskFilter[ki,kj] * padded_buffer[ki-i,kj-j].R);
                             green+=(int)(maskFilter[ki,kj] * padded_buffer[ki-i,kj-j].G); 
                             blue +=(int)(maskFilter[ki,kj] * padded_buffer[ki-i,kj-j].B); 

                        }
                    }
                    resultingImage[i,j] = Color.FromArgb(red, green, blue); 
                }
            }

            return resultingImage;
         
        }
    }
}
