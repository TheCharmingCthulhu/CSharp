using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DesignBox.Source.Controls
{
    public partial class AsymmetricGrid : UserControl
    {
        const string loremPicsum = "https://picsum.photos/{0}/{1}/?random";

        int Columns = 6;
        Random rand = new Random();
        Size size = new Size(32, 32);
        List<AsymmetricGridView> views = new List<AsymmetricGridView>();

        #region Properties
        public AsymmetricGridView[] Views { get { return views.ToArray(); } }

        public Point CellCount
        {
            get
            {
                return new Point(Width / size.Width, Height / size.Height);
            }
        }

        public Point Offset {
            get
            {
                return new Point((Width - (CellCount.X * size.Width)) / 2, (Height - (CellCount.Y * size.Height)) / 2);
            }
        }
        #endregion
        public AsymmetricGrid()
        {
            InitializeComponent();
            InitializeExample();

            LayoutGrid();
        }

        private void InitializeExample()
        {
            for(int i = 0; i < 16; i++)
            {
                AsymmetricGridView view = new AsymmetricGridView(new PictureBox());
                Random rand = new Random();

                // Lädt ein Bild aus der angegebenen ressource anhand eines zufälligen quadratischen wertes in länge & höhe ..
                if (view.Control is PictureBox vcontrol)
                {
                    int width = 0, height = 0;

                    if (i % 2 == 0)
                    {
                        width = 128;
                        height = 128;
                    }
                    else
                    {
                        width = 64;
                        height = 32;
                    }

                    Size imageSize = new Size(width, height);

                    vcontrol.LoadAsync(string.Format(loremPicsum, imageSize.Width, imageSize.Height));
                    vcontrol.Size = imageSize;
                    vcontrol.SizeMode = PictureBoxSizeMode.StretchImage;
                    vcontrol.BorderStyle = BorderStyle.FixedSingle;
                }

                views.Add(view);
            }
        }

        private void LayoutGrid()
        {
            Point position = new Point(0, 0);
            int index = 0, height = 0;

            foreach (var view in views)
            {
                if (index == 0)
                {
                    height = view.Control.Height;
                }

                view.Position = position;
                view.Size = new Size(view.Size.Width, height);

                position.Offset(view.Size.Width, 0);

                // Falls über die Sichtgrenze, in neue Zeile setzen ..
                if (position.X > Width)
                {
                    index = 0;

                    position = new Point(0, position.Y + view.Size.Height);

                    height = view.Control.Height;

                    view.Position = position;

                    position.Offset(view.Size.Width, 0);
                }

                Controls.Add(view.Control);

                index++;

                // Falls alle spalten durch, in neue Zeile setzen ..
                if (index == Columns)
                {
                    index = 0;

                    position = new Point(0, position.Y + view.Size.Height);

                    height = view.Control.Height;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for(int x = 0; x < CellCount.X; x++)
            {
                for (int y = 0; y < CellCount.Y; y++)
                {
                    //e.Graphics.DrawRectangle(Pens.Black, x * size.Width + Offset.X, y * size.Height + Offset.Y, size.Width, size.Height);
                }
            }
        }

        private void AsymmetricGrid_Load(object sender, EventArgs e)
        {
            Invalidate();
        }
    }

    public class AsymmetricGridView
    {
        const int CELL_SIZE = 32;

        Control control;

        #region Properties
        public Point Position
        {
            get
            {
                return control != null ? control.Location : Point.Empty;
            }
            set
            {
                if (control != null)
                {
                    control.Location = value;
                }
            }
        }

        public Size Size {
            get
            {
                return (control != null) ? control.Size : Size.Empty;
            }
            set
            {
                if (control != null)
                {
                    control.Size = value;
                }
            }
        }

        public Control Control
        {
            get { return control; }
        }
        #endregion

        public AsymmetricGridView(Control control)
        {
            this.control = control;
        }

        public override string ToString() => string.Format("{0}.{1}.{2}", typeof(AsymmetricGridView).Name, Size.Width.ToString(), Size.Height.ToString());
    }
}
