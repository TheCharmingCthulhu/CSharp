using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Motomatic.Controls
{
    class DraggablePictureBox : PictureBox
    {
        const int MOUSE_DRAG_OFFSET = 1;

        Point _MouseLocation;

        Control _DragTarget;
        Color _DragTargetDefaultBackColor;

        public delegate void DraggablePictureBoxEventHandler(object sender);
        public event DraggablePictureBoxEventHandler DraggablePictureBoxDragDrop;

        public Action Callback { get; set; }

        public Control DragDefaultControl { get; set; }

        public Control DragBaseControl { get; set; }

        public Control DragTarget
        {
            get { return _DragTarget; }
            set
            {
                _DragTarget = value;
                _DragTargetDefaultBackColor = _DragTarget.BackColor;
            }
        }

        public DraggablePictureBox()
        {
            Width = 135;
            Height = 80;
            BorderStyle = BorderStyle.FixedSingle;
            SizeMode = PictureBoxSizeMode.CenterImage;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _MouseLocation = e.Location;
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Math.Abs(_MouseLocation.X - e.X) > 0 && Math.Abs(_MouseLocation.Y - e.Y) > 0)
                {
                    if (DragDefaultControl == null) return;
                    if (DragBaseControl == null) DragBaseControl = FindForm();

                    if (Parent != DragBaseControl)
                    {
                        Parent = DragBaseControl;
                        BringToFront();
                    }

                    Location = new Point(Parent.PointToClient(Cursor.Position).X - Width / 2, Parent.PointToClient(Cursor.Position).Y - Height / 2);

                    UpdateDragTarget();

                    Update();
                }
            }

            base.OnMouseMove(e);
        }

        private void UpdateDragTarget()
        {
            DragTarget.BackColor = IsMouseOverDragTarget() ? Color.SkyBlue : _DragTargetDefaultBackColor;
        }

        public bool IsMouseOverDragTarget()
        {
            return DragTarget.ClientRectangle.Contains(DragTarget.PointToClient(Cursor.Position));
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Parent = DragDefaultControl;

                DraggablePictureBoxDragDrop?.Invoke(this);

                // Reset Drag
                _DragTarget.BackColor = _DragTargetDefaultBackColor;

                if (IsMouseOverDragTarget())
                    Callback();
            }

            base.OnMouseUp(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            Cursor = Cursors.Hand;

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Cursor = Cursors.Default;

            base.OnMouseLeave(e);
        }
    }
}
