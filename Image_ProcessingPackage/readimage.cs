using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Image_ProcessingPackage
{
    class readimage
    {
        public Color[,] displayimage(string file)
        {
            Bitmap bit = new Bitmap(file);
            Color[,] pixelColor = new Color[bit.Width, bit.Height];
            for (int x = 0; x < bit.Width; x++)
            {
                for (int y = 0; y < bit.Height; y++)
                {
                    pixelColor[x, y] = bit.GetPixel(x, y);
                    // things we do with pixelColor
                }
            }

            return pixelColor;
        }
    }
}
