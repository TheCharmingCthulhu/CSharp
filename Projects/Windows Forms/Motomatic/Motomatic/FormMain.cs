using Motomatic.Forms;
using Motomatic.Source.Automating;
using System.Windows.Forms;
using System;
using Motomatic.Controls;
using Motomatic.Controls.TabPages;
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
        }

        private void InitializeEventManager()
        {
            // Subscribe to events;
            EventManager.Instance().EventAdd += (ev) =>
            {
                EventChain_CreateNode(ev);
            };
            EventManager.Instance().EventRemove += (ev) =>
            {
                tabControlEventChains.TabPages.RemoveByKey(ev.Name);
            };
            EventManager.Instance().EventListLoad += (events) =>
            {
                events.Sort((a, b) => { return AlphaNumericComparer.Compare(a.Name, b.Name); });
                foreach (var ev in events)
                    EventChain_CreateNode(ev);
            };

            // Initialization;
            EventManager.Instance().LoadEvents();
        }

        private void EventChain_CreateNode(EventChain ev)
        {
            var baseNode = new TreeNode()
            {
                Name = ev.Name,
                Text = ev.Name,
                Tag = ev,
            };

            var eventNode = new TreeNode()
            {
                Name = "+ New Event",
                Text = "+ New Event",
                Tag = "+NewEvent"
            };

            baseNode.Nodes.Add(eventNode);

            treeViewEventManager.Nodes.Insert(0, baseNode);
        }

        private void EventChain_CreateEvent(EventChain ev)
        {
            var eventName = ev.Name + " - Unspecified";

            if (!tabControlEventChains.TabPages.ContainsKey(eventName))
            {
                tabControlEventChains.TabPages.Add(new EventPage()
                {
                    Name = eventName,
                    Text = eventName
                });
            }

            tabControlEventChains.SelectedTab = tabControlEventChains.TabPages[eventName];
        }

        #region <- Treeview ->
        private void treeViewEventManager_MouseMove(object sender, MouseEventArgs e)
        {
            var view = sender as TreeView;

            MouseMoveChangeCursor(view, view.HitTest(e.Location));
        }

        private static void MouseMoveChangeCursor(TreeView view, TreeViewHitTestInfo hitInfo)
        {
            if (hitInfo.Node != null && hitInfo.Location == TreeViewHitTestLocations.Label || hitInfo.Location == TreeViewHitTestLocations.PlusMinus)
            {
                if (hitInfo.Node.Tag != null)
                {
                    if (hitInfo.Node.Tag is string)
                    {
                        switch (hitInfo.Node.Tag.ToString()[0])
                        {
                            case '+':
                                view.HotTracking = true;
                                view.Cursor = Cursors.Hand;
                                break;
                        }
                    }
                    else if (hitInfo.Node.Tag is EventChain)
                    {
                        view.HotTracking = true;
                        view.Cursor = Cursors.Hand;
                    }
                }
            }
            else
            {
                view.HotTracking = false;
                view.Cursor = Cursors.Default;
            }
        }

        private void treeViewEventManager_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!e.Node.IsExpanded) e.Node.Expand();

            if (e.Node.Tag.ToString().Equals("+NewEventChain"))
            {
                if (FormEventChain.Run() == DialogResult.OK)
                {
                    EventManager.Instance().Create(FormEventChain.EventChainName);
                }
            }
            else if (e.Node.Tag.ToString().Equals("+NewEvent"))
                EventChain_CreateEvent(e.Node.Parent.Tag as EventChain);
        }
        #endregion

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            EventManager.Instance().SaveEvents();
        }
    }
}
