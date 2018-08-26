using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DesignBox.Source.Controls
{
    public partial class HertzView : UserControl
    {
        public double Frequency { get; set; } = 1.0;
        public double Time { get; set; } = 1.0;

        public HertzView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = 0.0;

            if (double.TryParse(textBox1.Text, out value))
            {
                Frequency = value;
            }

            if (double.TryParse(textBox2.Text, out value))
            {
                Time = value;
            }

            Refresh();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel view) {
                double waves = 90 * Frequency;
                double change = Math.Round((e.ClipRectangle.Width / waves), 2);

                for (double i = 0; i < waves; i++)
                {
                    double amplitude = Math.Cos(i / 10);

                    e.Graphics.DrawLine(Pens.Black, 
                        Convert.ToSingle(change * i),
                        e.ClipRectangle.Height / 2 + (e.ClipRectangle.Height / 4) * Convert.ToSingle(amplitude), 
                        Convert.ToSingle(change * i) + 1,
                        e.ClipRectangle.Height / 2 + (e.ClipRectangle.Height / 4) * Convert.ToSingle(amplitude) + 1);

                    //e.Graphics.DrawLine(Pens.Black,
                    //    Convert.ToSingle(change * i),
                    //    (e.ClipRectangle.Height / 2) + (e.ClipRectangle.Height / 2) * Convert.ToSingle(amplitude),
                    //    Convert.ToSingle(change * i) + 1,
                    //    (e.ClipRectangle.Height / 2) + (e.ClipRectangle.Height / 2) * Convert.ToSingle(amplitude) + 1);
                }
            }
        }
    }
}
