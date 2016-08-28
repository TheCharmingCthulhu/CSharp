using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldStamper.Sources.Utilities
{
    class GraphicUtils
    {
        internal static Bitmap Cut(int x, int y, int width, int height, Bitmap image)
        {
            return image.Clone(new Rectangle(x, y, width, height), image.PixelFormat);
        }
    }
}
