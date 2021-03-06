﻿using System.Drawing;
using WorldStamper.Sources.Models;

namespace WorldStamper.Sources.Utilities
{
    class GraphicsUtils
    {
        internal static Bitmap Cut(int x, int y, int width, int height, Bitmap image)
        {
            try { return image.Clone(new Rectangle(x, y, width, height), image.PixelFormat); }
            catch { return new Bitmap(width, height); }
        }

        internal static Bitmap Merge(int width, int height, Sprite[] sprites)
        {
            var image = new Bitmap(width, height);

            using (var g = Graphics.FromImage(image))
                foreach(var sprite in sprites)
                    g.DrawImage(sprite.Texture, sprite.X, sprite.Y);

            return image;
        }
    }
}
