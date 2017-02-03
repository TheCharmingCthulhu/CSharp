using Discardmin.Source;
using System.Windows.Forms;
using System;
using Discardmin.Controls;
using System.Linq;

namespace Discardmin
{
    public partial class FormMain : Form
    {
        DiscardminClient _Client;

        public FormMain()
        {
            InitializeComponent();
            InitializeViews();
        }

        private void InitializeViews()
        {
            textBoxUsername.Text = Properties.Settings.Default.Username;
            textBoxPassword.Text = Properties.Settings.Default.Password;
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

            Cursor = Cursors.WaitCursor;
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
                textBoxAuthorization.Enabled = true;

                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;

                groupBoxServers.Enabled = true;

                Properties.Settings.Default.Username = _Client.Username;
                Properties.Settings.Default.Password = _Client.Password;
                Properties.Settings.Default.Save();

                UpdateServers();
                ToggleConnectionStatus(true);

                Cursor = Cursors.Default;
            };

            _Client.DiscardminDisconnected += () =>
            {
                buttonDisconnect.Enabled = false;
                buttonConnect.Enabled = true;

                textBoxAuthorization.Enabled = false;

                groupBoxServers.Enabled = false;

                ToggleConnectionStatus(false);
                ClearFields();
            };

        }

        private void ClearFields()
        {
            textBoxAuthorization.Clear();
            listViewServers.Items.Clear();
        }

        private void UpdateServers()
        {
            listViewServers.Items.Clear();

            foreach(var server in _Client.Servers)
            {
                var serverItem = new ListViewItem();
                serverItem.Text = server.Id.ToString();
                serverItem.SubItems.Add(server.Name);
                serverItem.Tag = server;

                listViewServers.Items.Add(serverItem);
            }

            listViewServers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewServers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void buttonDisconnect_Click(object sender, System.EventArgs e)
        {
            _Client.Disconnect();            
        }
        #endregion

        #region <- Servers ->
        private void listViewServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = (sender as ListView);
            if (view.SelectedItems.Count > 0)
            {
                groupBoxChannels.Enabled = true;

                var server = view.SelectedItems[0].Tag as Discord.Server;

                tabControlChannels.TabPages.Clear();

                foreach (var channel in server.AllChannels.OrderBy(c => c.Position))
                {
                    var channelView = new FormChannel();
                    channelView.Type = channel.Type;
                    channelView.Dock = DockStyle.Fill;
                    channelView.Channel = channel;

                    var tabPage = new TabPage(channel.Name);
                    tabPage.Controls.Add(channelView);

                    tabControlChannels.TabPages.Add(tabPage);
                }
            }
            else groupBoxChannels.Enabled = false;
        }
        #endregion

        #region <- Channels ->

        #endregion

        private void ToggleConnectionStatus(bool status)
        {
            if (status)
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

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_Client != null) _Client.Disconnect();
        }
    }
}
