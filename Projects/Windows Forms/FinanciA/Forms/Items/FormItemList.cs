using FinanciA.Forms.Fixcosts;
using FinanciA.Source;
using MetroFramework.Forms;
using System.Windows.Forms;
using System;

namespace FinanciA.Forms
{
    public partial class FormItemList : MetroForm
    {
        public CurrencyDataType Type { get; set; }

        public enum CurrencyDataType
        {
            Fixcost,
            Salary,
            Service
        }

        public FormItemList()
        {
            InitializeComponent();
        }

        public static DialogResult Run(Form owner, CurrencyDataType type, string title = "")
        {
            var f = new FormItemList();
            f.Owner = owner;
            f.Type = type;
            f.UpdateItems();
            f.Text = title;

            return f.ShowDialog();
        }

        #region <- ListView : Fixcosts ->
        private void listViewFixcosts_MouseDown(object sender, MouseEventArgs e)
        {
            var view = sender as ListView;
            var hitInfo = view.HitTest(e.Location);

            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks > 1)
                {
                    if (view != null && view.SelectedItems.Count > 0)
                        if (hitInfo != null && hitInfo.Item != null)
                        {
                            listViewFixcosts_EditItem(sender);
                            return;
                        }

                    switch (Type)
                    {
                        case CurrencyDataType.Fixcost:
                            if (FormItemFixcost.Run() == DialogResult.OK)
                            {
                                FormMain.FixcostManager.Items.Add(FormItemFixcost.Item);
                                FormMain.FixcostManager.Save();
                                UpdateItems();
                            }
                            break;
                    }
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (view != null && view.Items.Count > 0)
                {
                    if (hitInfo != null && hitInfo.Item != null) contextMenuStripOptions.Show(view.PointToScreen(e.Location));
                }
            }
        }

        private void listViewFixcosts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listViewFixcosts_RemoveItem(sender);
            }
        }

        private void listViewFixcosts_RemoveItem(object sender)
        {
            var view = sender as ListView;
            if (view != null && view.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Sind Sie sicher das Sie das ausgewählte Element endgültig löschen möchten?", "Löschvorgang", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    FormMain.FixcostManager.Items.Remove(view.SelectedItems[0].Tag as Fixcost);
                    FormMain.FixcostManager.Save();

                    UpdateItems();
                }
            }
        }

        private void listViewFixcosts_EditItem(object sender)
        {
            var view = sender as ListView;
            if (view != null && view.SelectedItems.Count > 0)
            {
                var fixcostItem = view.SelectedItems[0].Tag as Fixcost;

                switch (Type)
                {
                    case CurrencyDataType.Fixcost:
                        if (FormItemFixcost.Run(fixcostItem) == DialogResult.OK)
                        {
                            var index = FormMain.FixcostManager.Items.IndexOf(fixcostItem);
                            FormMain.FixcostManager.Items.RemoveAt(index);
                            FormMain.FixcostManager.Items.Insert(index, FormItemFixcost.Item);
                            FormMain.FixcostManager.Save();
                            UpdateItems();
                        }
                        break;
                }
            }
        }
        #endregion

        private void UpdateItems()
        {
            listViewFixcosts.Items.Clear();

            if (FormMain.FixcostManager == null || FormMain.FixcostManager.Items.Count <= 0)
            {
                metroLabelEmptyLabel.Visible = true;
                return;
            }
            else metroLabelEmptyLabel.Visible = false;

            if (FormMain.FixcostManager != null && FormMain.FixcostManager.Items.Count > 0)
            {
                foreach (var fixcostItem in FormMain.FixcostManager.Items)
                {
                    var listItem = new ListViewItem(fixcostItem.Name);
                    listItem.SubItems.Add(fixcostItem.Description);
                    listItem.SubItems.Add(fixcostItem.Price.ToString("C2"));
                    listItem.Tag = fixcostItem;

                    listViewFixcosts.Items.Add(listItem);
                }

                listViewFixcosts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewFixcosts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void metroLabelEmptyLabel_MouseDown(object sender, MouseEventArgs e)
        {
            listViewFixcosts_MouseDown(listViewFixcosts, e);
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewFixcosts_RemoveItem(listViewFixcosts);
        }

        private void editierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewFixcosts_EditItem(listViewFixcosts);
        }
    }
}
