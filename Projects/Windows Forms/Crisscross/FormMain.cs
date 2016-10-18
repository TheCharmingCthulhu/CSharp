using Crisscross.Source.Service;
using Crisscross.Source.Webservice;
using System;
using System.Windows.Forms;

namespace Crisscross
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            var service = new HelloService();
            var server = new CrisscrossService(service);

            (sender as Button).Enabled = false;
        }
    }
}
