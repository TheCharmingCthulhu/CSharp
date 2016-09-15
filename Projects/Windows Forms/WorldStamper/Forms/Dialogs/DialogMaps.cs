using System;
using System.Windows.Forms;
using WorldStamper.Forms.Dialogs;
using WorldStamper.Sources.Models;

namespace WorldStamper.Forms
{
    public partial class DialogMaps : DialogBase
    {
        public DialogMaps()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            listViewMaps.Items.Clear();

            var maps = FormMain.View.GetResources<Map>();
            foreach(var map in maps)
            {
                var listItem = new ListViewItem(map.ID.ToString());
                listItem.SubItems.Add(map.Name);
                listItem.SubItems.Add(map.Width.ToString());
                listItem.SubItems.Add(map.Height.ToString());
                listViewMaps.Items.Add(listItem);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Map Files|*.xml;*.json;*.bin;*.zip",
                InitialDirectory = "..\\assets",
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                if (ofd.FileNames.Length > 0)
                    foreach (var file in ofd.FileNames)
                        if (!FormMain.View.LoadMap(file))
                        {
                            MessageBox.Show(string.Format("\"{0}\"\nMap has not been imported.\nError: Duplicate Map found!", file), "Import failed!");

                            return;
                        }

            RefreshList();
            LoadSelectedMaps();
            Close();
        }

        internal static DialogResult Run()
        {
            var f = new DialogMaps();

            return f.ShowDialog();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            LoadSelectedMaps();
        }

        private void LoadSelectedMaps()
        {
            if (listViewMaps.SelectedItems.Count > 0)
            {
                foreach (ListViewItem listViewItem in listViewMaps.SelectedItems)
                    FormMain.View.LoadMap(int.Parse(listViewItem.SubItems[0].Text));

                Close();
            }
        }

        private void listViewMaps_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewMaps.SelectedItems.Count > 0)
                LoadSelectedMaps();
        }

        private void listViewMaps_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                LoadSelectedMaps();
        }
    }
}
