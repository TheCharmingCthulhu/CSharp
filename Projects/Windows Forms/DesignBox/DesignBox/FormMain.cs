using DesignBox.Source;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DesignBox
{
    public partial class FormMain : Form
    {
        DBControl _Control;

        #region Properties
        public List<DBControl> UserControls { get; set; }

        public DBControl Control
        {
            get
            {
                return _Control;
            }
            set
            {
                _Control = value;

                // Eigenschaftsfenster setzen ..
                pgrdControl.SelectedObject = _Control;
            }
        }

        #endregion

        public FormMain()
        {
            InitializeComponent();
            InitializeResources();
            InitializeToolset();
            InitializePropertyGrid();
        }

        private void InitializePropertyGrid()
        {

        }

        private void InitializeResources()
        {
            // Lädt alle custom controls -> "Source.Controls.*.cs" ..
            UserControls = DBControls.GetCustomControls();
        }

        private void InitializeToolset()
        {
            if (UserControls != null)
            {
                foreach(var ctrl in UserControls)
                {
                    if (ctrl != null)
                    {
                        tscbUserControls.Items.Add(ctrl.Name);
                    }
                }
            }
        }

        private void AddControl(DBControl dbctrl)
        {
            // Erstellt eine neuen TabPage mit dem wunsch 'Usercontrol'
            TabPage page = new TabPage
            {
                Text = dbctrl.Name,
                BorderStyle = BorderStyle.Fixed3D,
                BackColor = SystemColors.ButtonShadow
            };

            UserControl ctrl = dbctrl.Create();
            ctrl.Dock = DockStyle.Fill;

            page.Tag = dbctrl;
            page.Controls.Add(ctrl);

            tctrlFrames.Controls.Add(page);
            tctrlFrames.SelectedTab = page;

            Control = dbctrl;
        }

        #region - Events
        private void FormMain_Load(object sender, System.EventArgs e)
        {

        }

        private void tsbtnCreateTab_Click(object sender, System.EventArgs e)
        {
            if (tscbUserControls.SelectedItem != null)
            {
                string controlName = tscbUserControls.SelectedItem as string;

                DBControl dbctrl = UserControls.Find(x => x.Name.Equals(controlName));

                if (dbctrl != null)
                {
                    AddControl(dbctrl);
                }
            }
        }

        private void tsbtnDeleteTab_Click(object sender, System.EventArgs e)
        {
            if (tctrlFrames.SelectedTab != null)
            {
                tctrlFrames.Controls.Remove(tctrlFrames.SelectedTab);

                Control = null;
            }
        }

        private void tctrlFrames_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (sender is TabControl ctrl)
            {
                if (ctrl.SelectedIndex > -1)
                {
                    Control = ctrl.TabPages[ctrl.SelectedIndex].Tag as DBControl;
                }
            }
        }
        #endregion
    }
}
