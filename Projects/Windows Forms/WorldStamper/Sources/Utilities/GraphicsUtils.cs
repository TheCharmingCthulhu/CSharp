using System.Drawing;

namespace WorldStamper.Sources.Utilities
{
    class GraphicsUtils
    {
        internal static Bitmap Cut(int x, int y, int width, int height, Bitmap image)
        {
            try { return image.Clone(new Rectangle(x, y, width, height), image.PixelFormat); }
            catch { return new Bitmap(width, height); }
        }
    }
}
