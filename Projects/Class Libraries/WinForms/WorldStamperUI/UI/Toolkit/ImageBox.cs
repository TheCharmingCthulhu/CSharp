using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WorldStamperUI.UI.Toolkit
{
    public class ImageBox : UserControl
    {
        public class ImageBoxItem
        {
            public Image Image { get; set; }
            public object Tag { get; set; }
        }

        Image _item, _selection;
        List<ImageBoxItem> _items = new List<ImageBoxItem>();

        #region <- Events ->
        public class ImageBoxArgs
        {
            public ImageBoxItem Item { get; set; }
        }

        public delegate void ImageBoxHandler(ImageBoxArgs e);
        public event ImageBoxHandler ImageSelected;
        #endregion

        public int ImageWidth { get; set; } = 32;
        public int ImageHeight { get; set; } = 32;

        public ImageBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        #region <- Functions ->
        public void AddImage(Image image, object tag = null)
        {
            _items.Add(new ImageBoxItem()
            {
                Image = image,
                Tag = tag,
            });

            Invalidate();
        }

        public void RemoveImage(Image image)
        {
            var item = _items.Find(i => i.Image == image);

            if (item != null) _items.Remove(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public int Count()
        {
            return _items.Count;
        }

        private Image MouseCoordinatesToRectangle(MouseEventArgs e)
        {
            foreach (var item in _items)
                if (((Rectangle)item.Image.Tag).Contains(e.Location))
                    return item.Image;

            return null;
        }
        #endregion

        #region <- Usercontrol ->
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawFrame(e);
            DrawImages(e);
            DrawHighlight(e);
            DrawSelection(e);

            base.OnPaint(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            _item = MouseCoordinatesToRectangle(e);

            if (_item != null) Invalidate(((Rectangle)_item.Tag)); else { Invalidate(); }

            base.OnMouseMove(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            SelectAndProcessImage();

            base.OnMouseClick(e);
        }

        private void SelectAndProcessImage()
        {
            if (_item != null)
            {
                _selection = new Bitmap(_item);
                _selection.Tag = _item.Tag;

                using (var g = Graphics.FromImage(_selection))
                {
                    var rect = g.VisibleClipBounds;

                    using (var brush = new SolidBrush(Color.FromArgb(128, Color.LightGray)))
                        g.FillRectangle(brush, rect);

                    g.DrawLine(Pens.Black, (rect.Width / 2) - 2.5f, rect.Height / 2, (rect.Width / 2) + 3f, rect.Height / 2);
                    g.DrawLine(Pens.Black, rect.Width / 2, (rect.Height / 2) - 2.5f, rect.Width / 2, (rect.Height / 2) + 3f);
                }

                Invalidate();

                if (ImageSelected != null)
                    ImageSelected(new ImageBoxArgs() {
                        Item = _items.Find(i => i.Image == _item)
                    });
            }
        }
        #endregion

        #region <- Paint ->
        private void DrawImages(PaintEventArgs e)
        {
            if (_items != null && _items.Count > 0)
            {
                int x = 1, y = 1;
                int columns = (Width / ImageWidth);

                foreach (var item in _items)
                {
                    var rect = new Rectangle((x * ImageWidth) - ImageWidth + (x * (ImageWidth / 2)),
                                             (y * ImageHeight) - ImageHeight + (y * (ImageHeight / 2)), ImageWidth, ImageHeight);

                    item.Image.Tag = rect;

                    e.Graphics.DrawImageUnscaledAndClipped(item.Image, rect);
                    e.Graphics.DrawRectangle(Pens.Black, rect);

                    x++;

                    if (x % (columns - 1) == 0) { x = 1; y++; }
                }
            }
        }

        private void DrawFrame(PaintEventArgs e)
        {
            var frame = new Rectangle(e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            e.Graphics.FillRectangle(Brushes.White, frame);
            e.Graphics.DrawRectangle(Pens.Black, frame);
        }

        private void DrawHighlight(PaintEventArgs e)
        {
            if (_item != null)
            {
                var rect = ((Rectangle)_item.Tag);
                e.Graphics.DrawRectangle(Pens.Black, rect.Left, rect.Top, rect.Width - 1, rect.Height - 1);
            }
        }

        private void DrawSelection(PaintEventArgs e)
        {
            if (_selection != null)
                e.Graphics.DrawImage(_selection, ((Rectangle)_selection.Tag));
        }
        #endregion
    }
}
