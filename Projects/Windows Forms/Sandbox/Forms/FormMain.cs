using Sandbox.Forms;
using Sandbox.Sources.Interfaces;
using Sandbox.Sources.Stackoverflow;
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

        private void buttonLerp_Click(object sender, EventArgs e)
        {
            ShowForm(() =>
            {
                FormLerp.Run();
            });
        }

        private void btnStackoverflow_Click(object sender, EventArgs e)
        {
            Stacky stack = new Stacky();
        }

        private void buttonCasting_Click(object sender, EventArgs e)
        {
            FormCasting.Run();
        }

        private void buttonValueConversion_Click(object sender, EventArgs e)
        {
            FormValueConversion.Run();
        }

        private Func<int> GetCounter()
        {
            int i = 0;

            return () => { return ++i; };
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            Action x = null;

            x += () => { MessageBox.Show("Method 1 Called!", "Action"); };

            x += () => { MessageBox.Show("Method 2 Called!", "Action"); };

            x?.Invoke();

            var counter = GetCounter();
            MessageBox.Show(counter().ToString(), "Counter");
            MessageBox.Show(counter().ToString(), "Counter");
            MessageBox.Show(counter().ToString(), "Counter");

            var secondCounter = GetCounter();
            MessageBox.Show(secondCounter().ToString(), "Counter");
            MessageBox.Show(secondCounter().ToString(), "Counter");
            MessageBox.Show(secondCounter().ToString(), "Counter");
        }

        private void buttonFixedListbox_Click(object sender, EventArgs e)
        {
            FormFixedListbox.Run();
        }
    }
}
