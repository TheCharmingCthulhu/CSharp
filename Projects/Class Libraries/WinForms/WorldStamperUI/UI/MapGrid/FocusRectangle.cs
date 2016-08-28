using System.Drawing;

namespace WorldStamperUI.UI.MapGrid
{
    class FocusRectangle
    {
        public Point Location { get; set; } = new Point(-1, -1);
        public Color Color { get; set; } = Color.ForestGreen;
    }
}
