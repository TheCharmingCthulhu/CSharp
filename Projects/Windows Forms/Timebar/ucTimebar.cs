using System;
using System.Drawing;
using System.Windows.Forms;

namespace Timebar
{
    class ucTimebar : FlowLayoutPanel
    {
        int _Index = -1;

        public const int SPACER = 30;

        public static class Timebar
        {
            public static int Height { get; set; } = 20;
        }

        public ucTimebar() : base()
        {
            WrapContents = false;
            HorizontalScroll.SmallChange = SPACER;
            HorizontalScroll.LargeChange = SPACER * 2;

            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        public int IndexToPosition(int index)
        {
            return (SPACER * index) - HorizontalScroll.Value;
        }

        public Rectangle IndexToRectangle(int index)
        {
            int offsetX = 0, offsetY = 0;

            if (HorizontalScroll.Visible)
            {
                offsetX = HorizontalScroll.Value;
                offsetY = SystemInformation.HorizontalScrollBarHeight;
            }

            return new Rectangle(IndexToPosition(index) + offsetX, Height - Timebar.Height - offsetY, SPACER, Height - offsetY);
        }

        public int LocationToIndex(Point location)
        {
            double position = ((double)(location.X - Cursor.Size.Width / 2) / Width);

            return Convert.ToInt32(position * (Width / SPACER));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SuspendLayout();

            e.Graphics.FillRectangle(Brushes.LightGray, new RectangleF(0, e.ClipRectangle.Height - Timebar.Height, Width, Timebar.Height));

            for (int i = 0; i < Width; i++)
            {
                e.Graphics.DrawLine(Pens.Black, IndexToPosition(i), e.ClipRectangle.Height - Timebar.Height, IndexToPosition(i), e.ClipRectangle.Height);

                e.Graphics.DrawString(i.ToString(), DefaultFont, Brushes.Black,
                    new Point(IndexToPosition(i) - (SPACER / 2) - Convert.ToInt32(e.Graphics.MeasureString(i.ToString(), DefaultFont).Width / 2),
                    e.ClipRectangle.Height - Timebar.Height - 15));

                int spacer_w = 5;
                for (int j = 1; j < SPACER / spacer_w; j++)
                {
                    int start_w = IndexToPosition(i);
                    e.Graphics.DrawLine(Pens.DarkGray, start_w + spacer_w * j, e.ClipRectangle.Height - Timebar.Height, 
                        start_w + spacer_w * j, e.ClipRectangle.Height);
                }
            }

            if (_Index > -1)
                e.Graphics.FillRectangle(SystemBrushes.Highlight, IndexToRectangle(_Index));

            ResumeLayout();
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);

            if (se.NewValue % SPACER > 0)
                HorizontalScroll.Value = se.NewValue - (se.NewValue % SPACER);

            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            var index = LocationToIndex(e.Location);

            if (index != _Index)
            {
                _Index = index;
                Invalidate();
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);

            var empty = Width % SPACER;

            if (empty > 0)
                Width = Width - empty;
        }
    }
}
