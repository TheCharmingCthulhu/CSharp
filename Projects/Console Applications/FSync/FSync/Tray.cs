using System;
using System.Windows.Forms;

namespace FSync
{
    public partial class Tray : Form
    {
        public Tray()
        {
            InitializeComponent();
        }

        internal static void Run(string message = "")
        {
            var f = new Tray();

            f.notifyIconTray.Visible = true;
            f.notifyIconTray.BalloonTipTitle = "FSync";
            f.notifyIconTray.BalloonTipText = message;

            if (!message.Trim().Equals(""))
                f.notifyIconTray.ShowBalloonTip(1000);

            f.ShowDialog();
        }

        private void notifyIconTray_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            (sender as NotifyIcon).Visible = false;
        }
    }
}
