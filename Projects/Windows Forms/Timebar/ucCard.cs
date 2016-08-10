using System.Drawing;
using System.Windows.Forms;

namespace Timebar
{
    class ucCard : Panel
    {
        public string Caption { get; set; }
        public string Description { get; set; }

        public ucCard()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SuspendLayout();

            e.Graphics.FillRectangle(Brushes.LightGray, e.ClipRectangle);
            e.Graphics.DrawLine(Pens.DarkGray, 0, e.ClipRectangle.Height - 1, e.ClipRectangle.Width, e.ClipRectangle.Height - 1);

            e.Graphics.DrawString(Caption, new Font(DefaultFont.Name, DefaultFont.Size, FontStyle.Underline), Brushes.Black, new Point(10, 5));

            base.OnPaint(e);

            ResumeLayout();
        }
    }
}
