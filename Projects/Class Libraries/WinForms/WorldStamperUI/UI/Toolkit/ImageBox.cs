using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WorldStamperUI.UI.Toolkit
{
    public class ImageBox : UserControl
    {
        List<Image> _tiles = new List<Image>();

        public ImageBox()
        {

        }

        #region <- Functions ->
        public void AddTile(Image tile)
        {

        } 
        #endregion

        #region <- Usercontrol ->
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawFrame(e);

            base.OnPaint(e);
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
