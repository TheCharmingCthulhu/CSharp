using System;
using System.Windows.Forms;

namespace WorldStamper.Forms
{
    public partial class FormNewMap : FormBase
    {
        const int DEFAULT_WIDTH = 20;
        const int DEFAULT_HEIGHT = 20;

        public static string MapName { get; set; }

        public static int MapWidth { get; set; } = 20;

        public static int MapHeight { get; set; } = 20;

        public FormNewMap()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView()
        {
            numericUpDownWidth.Value = MapWidth;
            numericUpDownHeight.Value = MapHeight;
        }

        public static DialogResult Run(string name = "", int width = DEFAULT_WIDTH, int height = DEFAULT_HEIGHT)
        {
            var f = new FormNewMap();

            f.textBoxName.Text = name;
            f.numericUpDownWidth.Value = width;
            f.numericUpDownHeight.Value = height;

            return f.ShowDialog();
        }

        private void textBoxName_TextChanged(object sender, System.EventArgs e)
        {
            var view = (sender as TextBox);

            if (!view.Text.Trim().Equals(""))
                MapName = view.Text.Trim();
        }

        private void numeric_ValueChanged(object sender, System.EventArgs e)
        {
            var view = (sender as NumericUpDown);

            switch (Convert.ToInt32(view.Tag))
            {
                case 0:
                    MapWidth = (int)view.Value;
                    break;
                case 1:
                    MapHeight = (int)view.Value;
                    break;
            }
        }
    }
}
