using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElegantUI.Controls
{
    public class Tabs : TabControl
    {
        Point _MousePosition;
        int _HoverTabIndex = -1;

        public Tabs()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        #region <- Events ->
        public class TabsEventArgs
        {
            public int TabIndex { get; set; }
        }

        public delegate void TabsHandler(TabsEventArgs e);
        public event TabsHandler TabClosing;
        #endregion

        #region <- Functions ->
        private int GetTabByLocation(Point location)
        {
            for (int i = 0; i < TabPages.Count; i++)
                if (GetTabRect(i).Contains(location))
                    return i;

            return -1;
        }
        #endregion

        #region <- Usercontrol ->
        protected override void OnParentChanged(EventArgs e)
        {
            Parent.Move += Parent_Move;

            base.OnParentChanged(e);
        }

        private void Parent_Move(object sender, EventArgs e)
        {
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            OnTabCloseDown(e);

            base.OnMouseDown(e);
        }

        private void OnTabCloseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _HoverTabIndex != -1 && _CloseButtonTarget.Contains(e.Location) || 
                e.Button == MouseButtons.Middle && _HoverTabIndex != -1)
            {
                TabClosing?.Invoke(new TabsEventArgs() { TabIndex = _HoverTabIndex });

                TabPages.RemoveAt(_HoverTabIndex);

                SelectedIndex = _HoverTabIndex != TabPages.Count ? _HoverTabIndex : TabPages.Count - 1;
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            _HoverTabIndex = GetTabByLocation(e.Location);
            _MousePosition = e.Location;

            Invalidate();

            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _HoverTabIndex = -1;

            Invalidate();

            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawFrame(e);
            DrawTabs(e);
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            Invalidate();

            base.OnSelectedIndexChanged(e);
        }
        #endregion

        #region <- Drawing ->
        Pen _FramePen = new Pen(Color.LightGray);
        private void DrawFrame(PaintEventArgs e)
        {
            if (SelectedIndex != -1)
            {
                var rect = new Rectangle(e.ClipRectangle.Left + 1, e.ClipRectangle.Top + GetTabRect(SelectedIndex).Height + 1,
                                         e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 2);

                e.Graphics.FillRectangle(new SolidBrush(TabPages[SelectedIndex].BackColor), rect);
                e.Graphics.DrawRectangle(_FramePen, rect);
            }
        }

        private void DrawTabs(PaintEventArgs e)
        {
            DrawSelectedTab(e);

            for (int i = 0; i < TabPages.Count; i++)
            {
                var rect = new Rectangle(GetTabRect(i).Left, GetTabRect(i).Top + 2, GetTabRect(i).Width, GetTabRect(i).Height - 3);

                if (i != SelectedIndex)
                {
                    if (_HoverTabIndex == i) e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(216, 234, 249)), rect);

                    e.Graphics.DrawLine(_FramePen, rect.Left, rect.Top, rect.Left, rect.Top + rect.Height - 1);
                    e.Graphics.DrawLine(_FramePen, rect.Left + rect.Width, rect.Top, rect.Left + rect.Width, rect.Top + rect.Height - 1);
                    e.Graphics.DrawLine(_FramePen, rect.Left, rect.Top, rect.Left + rect.Width - 1, rect.Top);
                }

                DrawCloseButton(e, rect, ref i);

                var textRect = new Rectangle(rect.Left + 4, rect.Top, rect.Width, rect.Height);
                e.Graphics.DrawString(TabPages[i].Text, Font, Brushes.Black, textRect, new StringFormat()
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                });
            }
        }

        RectangleF _CloseButtonTarget;
        Pen _CloseColorPen = Pens.Black;
        private void DrawCloseButton(PaintEventArgs e, Rectangle rectangle, ref int index)
        {
            var offset_ns = SelectedIndex != index ? 2 : 0;
            var offset_s = SelectedIndex == index ? 1 : 0;

            var closeRect = new RectangleF(rectangle.Left + rectangle.Width - 12, (rectangle.Top + (rectangle.Height / 2)) - 4 - offset_s, 8, 8);
            var hoverRect = new RectangleF(rectangle.Left + rectangle.Width - 15, rectangle.Top - offset_s, 15, rectangle.Height + offset_s);

            if (!DesignMode)
                _CloseColorPen = (_HoverTabIndex == -1 || !hoverRect.Contains(_MousePosition)) ? Pens.Black : Pens.White;

            if (!DesignMode)
                if (_HoverTabIndex != -1 && hoverRect.Contains(_MousePosition))
                {
                    e.Graphics.FillRectangle(Brushes.Red, hoverRect);

                    _CloseButtonTarget = hoverRect;
                }

            e.Graphics.DrawLine(_CloseColorPen, closeRect.Left, closeRect.Top, closeRect.Left + closeRect.Width, closeRect.Top + closeRect.Height);
            e.Graphics.DrawLine(_CloseColorPen, closeRect.Left + closeRect.Width, closeRect.Top, closeRect.Left, closeRect.Top + closeRect.Height);
        }

        private void DrawSelectedTab(PaintEventArgs e)
        {
            if (SelectedIndex != -1)
            {
                var rect = new Rectangle(GetTabRect(SelectedIndex).Left, GetTabRect(SelectedIndex).Top,
                                         GetTabRect(SelectedIndex).Width, GetTabRect(SelectedIndex).Height);

                e.Graphics.FillRectangle(Brushes.White, rect);
                e.Graphics.DrawLine(_FramePen, rect.Left, rect.Top, rect.Left, rect.Top + rect.Height - 1);
                e.Graphics.DrawLine(_FramePen, rect.Left + rect.Width, rect.Top, rect.Left + rect.Width, rect.Top + rect.Height - 1);
                e.Graphics.DrawLine(_FramePen, rect.Left, rect.Top, rect.Left + rect.Width - 1, rect.Top);
            }
        }
        #endregion
    }
}
