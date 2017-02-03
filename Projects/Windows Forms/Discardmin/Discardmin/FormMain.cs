using Discardmin.Source;
using System.Windows.Forms;
using System;

namespace Discardmin
{
    public partial class FormMain : Form
    {
        DiscardminClient _Client;

        public FormMain()
        {
            InitializeComponent();
        }

        #region <- Authentication ->
        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            string username = textBoxUsername.Text.Trim(), password = textBoxPassword.Text.Trim();

            if (_Client == null)
            {
                _Client = new DiscardminClient(username, password);

                RegisterEvents();
            }
            else _Client.Login(username, password);
        }

        private void RegisterEvents()
        {
            _Client.DiscardminLoginError += (error) =>
            {
                MessageBox.Show(error.Message, _Client.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            _Client.DiscardminConnected += () =>
            {
                textBoxAuthorization.Text = _Client.Authorization;

                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;

                UpdateServers();
                ToggleConnectionStatus(true);
            };

            _Client.DiscardminDisconnected += () =>
            {
                buttonDisconnect.Enabled = false;
                buttonConnect.Enabled = true;
            };
        }

        private void UpdateServers()
        {
            listViewServers.Items.Clear();

            foreach(var server in _Client.Servers)
            {
                var serverItem = new ListViewItem();
                serverItem.Text = server.Id.ToString();
                serverItem.SubItems.Add(server.Name);

                listViewServers.Items.Add(serverItem);
            }
        }

        private void buttonDisconnect_Click(object sender, System.EventArgs e)
        {
            _Client.Disconnect();            
        }
        #endregion

        private void ToggleConnectionStatus(bool connected = false)
        {
            if (connected)
            {
                labelConnectionStatus.Text = "CONNECTED";
                labelConnectionStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelConnectionStatus.Text = "NOT CONNECTED";
                labelConnectionStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
