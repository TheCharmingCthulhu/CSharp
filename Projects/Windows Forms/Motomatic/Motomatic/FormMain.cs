using Motomatic.Forms;
using Motomatic.Source.Automating;
using System.Windows.Forms;
using System;
using Motomatic.Source.Utilities.Comparator;

namespace Motomatic
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeMotomatic();
        }

        private void InitializeMotomatic()
        {
            InitializeEventManager();
            Debug();
        }

        private void Debug()
        {
        }

        private void InitializeEventManager()
        {
            // Subscribe to events;
            EventManager.Instance().EventAdd += (evChain) =>
            {
                EventChain_CreateItem(evChain);
            };
            EventManager.Instance().EventRemove += (evChain) =>
            {

            };
            EventManager.Instance().EventListLoad += (evChains) =>
            {
                evChains.Sort((a, b) => { return AlphaNumericComparer.Compare(a.Name, b.Name); });

                foreach (var evChain in evChains)
                    EventChain_CreateItem(evChain);
            };

            // Initialization;
            EventManager.Instance().LoadEvents();
        }

        private void EventChain_CreateItem(EventChain evChain)
        {
            var lvItem = new ListViewItem();

            lvItem.Text = evChain.Name;
            lvItem.Tag = evChain;

            listViewEventChains.Items.Add(lvItem);
        }

        private void Event_CreateItem(EventChain evChain)
        {
            listViewEvents.Clear();

            foreach (var ev in evChain.Events)
            {
                var lvItem = new ListViewItem();

                lvItem.Text = ev.ToString();
                lvItem.Tag = ev;

                listViewEvents.Items.Add(lvItem);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            EventManager.Instance().SaveEvents();
        }

        private void listViewEventChains_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as ListView;

            var evChain = GetSelectedEventChain();
            if (evChain != null) 
                Event_CreateItem(view.SelectedItems[0].Tag as EventChain);
        }

        #region <- Toolset ->
        private void toolStripButtonNewEventChain_Click(object sender, EventArgs e)
        {
            if (FormEventChain.Run() == DialogResult.OK)
            {
                var ev = EventManager.Instance().Create(FormEventChain.EventChainName);
            }
        }
        #endregion

        private EventChain GetSelectedEventChain()
        {
            return listViewEventChains.SelectedItems.Count > 0 ? listViewEventChains.SelectedItems[0].Tag as EventChain : null;
        }

        private Event GetSelectedEvent()
        {
            return listViewEvents.SelectedItems.Count > 0 ? listViewEvents.SelectedItems[0].Tag as Event : null;
        }

        private void listViewEvents_DoubleClick(object sender, EventArgs e)
        {
            var ev = GetSelectedEvent();
            if (ev != null)
            {
                if (FormEventEditor.Run(ev.ToString(), ev) == DialogResult.OK)
                {

                }
            }
        }

        private void listViewEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as ListView;
            fastColoredTextBoxScript.Enabled = view.SelectedItems.Count > 0;

            var ev = GetSelectedEvent();
            if (ev != null)
                fastColoredTextBoxScript.Text = ev.Script != null ? ev.Script : "";
        }

        private void fastColoredTextBoxScript_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            var ev = GetSelectedEvent();
            if (ev != null)
            {
                ev.Script = e.ChangedRange.Text;
            }
        }

        private void fastColoredTextBoxScript_Load(object sender, EventArgs e)
        {

        }
    }
}
