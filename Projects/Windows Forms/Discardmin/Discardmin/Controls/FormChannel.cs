using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discardmin.Controls
{
    public partial class FormChannel : UserControl
    {
        public int PageIndex { get; set; } = 1;

        Discord.Channel _Channel;

        public Discord.Channel Channel
        {
            get
            {
                return _Channel;
            }

            set
            {
                _Channel = value;

                UpdateMessages();
            }
        }

        public Discord.ChannelType Type { get; set; }

        public FormChannel()
        {
            InitializeComponent();
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void toolStripButtonPrevious_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private async Task<Discord.Message[]> GetMessages(int page)
        {
            var message = (await _Channel.DownloadMessages()).OrderBy(m => m.Timestamp).Last();
            var messages = new List<Discord.Message>();

            for (int i = 0; i < page; i++)
            {
                if (i == page - 1)
                {
                    messages.Add(message);
                    messages.AddRange((await _Channel.DownloadMessages(relativeMessageId: message.Id)).ToList());
                    messages = messages.OrderBy(m => m.Timestamp).ToList();
                }
                else
                    message = (await _Channel.DownloadMessages(relativeMessageId: message.Id)).OrderBy(m => m.Timestamp).First();
            }

            return messages.OrderBy(m => m.Timestamp).ToArray();
        }

        private DateTime WithoutSeconds(DateTime timestamp)
        {
            return new DateTime(timestamp.Year, timestamp.Month, timestamp.Day, timestamp.Hour, timestamp.Minute, 0);
        }

        private async void UpdateMessages()
        {
            listViewMessages.Items.Clear();

            var messages = await GetMessages(PageIndex);
            var timestamps = messages.Select(m => WithoutSeconds(m.Timestamp))
                .Distinct()
                .ToList();

            foreach (var timestamp in timestamps)
            {
                var groupItem = new ListViewGroup();
                groupItem.Name = timestamp.ToString();
                groupItem.Header = timestamp.ToString();

                listViewMessages.Groups.Add(groupItem);
            }

            foreach (var message in messages)
            {
                var messageItem = new ListViewItem();
                messageItem.SubItems.Add(message.ToString());
                messageItem.Tag = message;
                messageItem.Group = listViewMessages.Groups[WithoutSeconds(message.Timestamp).ToString()];

                listViewMessages.Items.Add(messageItem);
            }

            listViewMessages.TopItem = listViewMessages.Items[listViewMessages.Items.Count - 1];
            listViewMessages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void NextPage()
        {
            PageIndex++;

            UpdateMessages();
        }

        public void PreviousPage()
        {
            if (PageIndex - 1 > 0) PageIndex--;

            UpdateMessages();
        }

        private async void DeleteMessages()
        {
            if (listViewMessages.CheckedItems.Count > 0)
                foreach (ListViewItem message in listViewMessages.CheckedItems)
                {
                    await (message.Tag as Discord.Message).Delete();
                    await Task.Delay(TimeSpan.FromMilliseconds(500));
                }

            UpdateMessages();
        }

        private void toolStripButtonApply_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxActions.SelectedIndex > -1)
            {
                switch (toolStripTextBoxActions.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        DeleteMessages();
                        break;
                }
            }
        }
    }
}
