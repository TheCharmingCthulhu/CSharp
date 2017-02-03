using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discardmin.Controls
{
    public partial class FormChannel : UserControl
    {
        public int MessagesPageIndex { get; set; } = 0;

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
            var index = 0;
            Discord.Message[] messages = null;

            do
            {
                messages = (await _Channel.DownloadMessages(relativeMessageId: (messages != null && messages.Length > 0) ? messages.Last().Id : ((await _Channel.DownloadMessages()).OrderBy(m => m.Timestamp).Last().Id)))
                    .OrderBy(m => m.Timestamp)
                    .ToArray();

                index++;
            } while (index < page);

            return messages.OrderBy(m => m.Timestamp).ToArray();
        }

        private async void UpdateMessages()
        {
            checkedListBoxMessages.Items.Clear();

            foreach(var message in await GetMessages(0))
            {
                checkedListBoxMessages.Items.Add(message, false);
            }

            checkedListBoxMessages.TopIndex = checkedListBoxMessages.Items.Count - 1;
        }

        public void NextPage()
        {
            MessagesPageIndex++;

            UpdateMessages();
        }

        public void PreviousPage()
        {
            if (MessagesPageIndex - 1 > -1) MessagesPageIndex--;

            UpdateMessages();
        }
    }
}
