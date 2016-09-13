using Sandbox.Forms;
using Sandbox.Sources.Interfaces;
using System;
using System.Windows.Forms;

namespace Sandbox
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSequences_Click(object sender, EventArgs e)
        {
            ShowForm(() =>
            {
                FormSequences.Run();
            });
        }

        private void ShowForm(Action callback)
        {
            Hide();

            callback?.Invoke();

            Show();
        }

        private void buttonInterfaces_Click(object sender, EventArgs e)
        {
            IItem x = new Shape();
            (x as Shape).GetArea();
            x.GetArea();
        }

        private void buttonClock_Click(object sender, EventArgs e)
        {
            ShowForm(() =>
            {
                FormClock.Run();
            });
        }
    }
}
