using Motomatic.Forms;
using Motomatic.Source.Automating;
using System.Windows.Forms;

namespace Motomatic
{
    public partial class FormMain : Form
    {
        EventChain _CurrentEventChain;

        public FormMain()
        {
            InitializeComponent();
            InitializeMotomatic();
        }

        private void InitializeMotomatic()
        {
            EventManager.Instance();
        }

        #region <- Treeview : EventManager ->
        private void treeViewEventManager_MouseMove(object sender, MouseEventArgs e)
        {
            var view = sender as TreeView;

            MouseMoveChangeCursor(view, view.HitTest(e.Location));
        }

        private static void MouseMoveChangeCursor(TreeView view, TreeViewHitTestInfo hitInfo)
        {
            if (hitInfo.Node != null && hitInfo.Location == TreeViewHitTestLocations.Label || hitInfo.Location == TreeViewHitTestLocations.PlusMinus)
            {
                switch (hitInfo.Node.Tag.ToString()[0])
                {
                    case '+':
                        view.HotTracking = true;
                        view.Cursor = Cursors.Hand;
                        break;
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
            if (e.Node.Tag.ToString().Equals("+NewEventChain"))
            {
                if (FormEventChain.Run() == DialogResult.OK)
                {
                    _CurrentEventChain = new EventChain(FormEventChain.EventName);

                    tabControlEventChains.TabPages.Add(_CurrentEventChain.Name);
                }
                //tabControlEventChains.TabPages.Add()
            }
        } 
        #endregion
    }
}
