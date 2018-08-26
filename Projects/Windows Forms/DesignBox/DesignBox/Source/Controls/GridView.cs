using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DesignBox.Source.Controls
{
    public partial class GridView : UserControl
    {
        const string LOREM_PICTURE = "https://picsum.photos/{0}/{1}/?random";

        public int CellSize { get; set; } = 32;
        public int Columns { get; set; } = 2;
        public int Rows { get; set; } = 3;
        public List<Control> Views { get; set; } = new List<Control>();

        public GridView()
        {
            InitializeComponent();
            InitializeExample();
        }

        private void LayoutViews()
        {
            int xpos = Width / Columns, ypos = Height / Rows;
            int xoff = (Width - (xpos * (Columns - 1))) / 2, yoff = (Height - (ypos * (Rows - 1))) / 2;
            int x = 0, y = 0;

            foreach (var view in Views)
            {
                if (x >= Columns)
                {
                    x = 0;
                    y++;
                }

                view.Left = xpos * x + xoff - (view.Size.Width / 2);
                view.Top = ypos * y + yoff - (view.Size.Height / 2);

                x++;

                if (!Controls.Contains(view))
                    Controls.Add(view);
            }
        }

        private void InitializeExample()
        {
            for (int i = 0; i < 4; i++)
            {
                PictureBox view = new PictureBox();

                if (i % 2 == 0)
                    view.LoadAsync(string.Format(LOREM_PICTURE, 128, 128));
                else
                    view.LoadAsync(string.Format(LOREM_PICTURE, 64, 64));

                view.SizeMode = PictureBoxSizeMode.AutoSize;

                Views.Add(view);
            }
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            LayoutViews();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            LayoutViews();
        }
    }
}
