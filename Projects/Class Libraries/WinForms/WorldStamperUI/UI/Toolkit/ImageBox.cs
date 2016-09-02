using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WorldStamperUI.UI.Toolkit
{
    public class ImageBox : UserControl
    {
        List<Image> _items = new List<Image>();

        public int ImageWidth { get; set; } = 32;
        public int ImageHeight { get; set; } = 32;

        public ImageBox()
        {

        }

        #region <- Functions ->
        public void AddImage(Image image)
        {
            _items.Add(image);

            Invalidate();
        }

        public void Clear()
        {
            _items.Clear();
        }
        #endregion

        #region <- Usercontrol ->
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawFrame(e);
            DrawImages(e);

            base.OnPaint(e);
        }

        private void DrawImages(PaintEventArgs e)
        {
            if (_items != null && _items.Count > 0)
            {
                int x = 0, y = 0;
                int columns = (Width / ImageWidth);

                foreach (var item in _items)
                {
                    if (x == 0) { x++; };

                    e.Graphics.DrawImageUnscaledAndClipped(item,
                        new Rectangle((x * ImageWidth) - ((ImageWidth / 2) * 2) + (x * (ImageWidth / 2)), 
                                      (y * ImageWidth) + (ImageHeight / 2) + (y * (ImageWidth / 2)), ImageWidth, ImageHeight));

                    x++;

                    if (x % (columns - 1) == 0) { x = 0; y++; }
                }
            }
        }

        private void DrawFrame(PaintEventArgs e)
        {
            var frame = new Rectangle(e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            e.Graphics.FillRectangle(Brushes.White, frame);
            e.Graphics.DrawRectangle(Pens.Black, frame);
        }
        #endregion
    }
}
