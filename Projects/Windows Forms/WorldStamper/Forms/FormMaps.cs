using System;
using System.Windows.Forms;
using WorldStamper.Sources.Models;

namespace WorldStamper.Forms
{
    public partial class FormMaps : FormBase
    {
        public FormMaps()
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
                            MessageBox.Show(string.Format("Map: \"{0}\" has not been imported.\nError: Duplicate found!", file), 
                                "Map import failed!");

                            return;
                        }

            RefreshList();

            buttonAccept_Click(buttonAccept, e);
        }

        internal static DialogResult Run()
        {
            var f = new FormMaps();

            return f.ShowDialog();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (listViewMaps.SelectedItems.Count > 0)
            {
                FormMain.View.LoadMap(int.Parse(listViewMaps.SelectedItems[0].SubItems[0].Text));

                Close();
            }
        }

        private void listViewMaps_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewMaps.SelectedItems.Count > 0)
                buttonAccept_Click(buttonAccept, e);
        }
    }
}
