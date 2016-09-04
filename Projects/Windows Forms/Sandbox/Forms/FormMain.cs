using Sandbox.Sources.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
