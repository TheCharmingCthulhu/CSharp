using FinanciA.Source;
using MetroFramework.Forms;
using System.Windows.Forms;
using System;
using FinanciA.Forms.Fixcosts.Items;
using FinanciA.Forms.Items;
using System.Collections.Generic;
using System.Linq;

namespace FinanciA.Forms
{
    public partial class FormItemList : MetroForm
    {
        public CurrencyDataType Type { get; set; }

        public enum CurrencyDataType
        {
            Fixcost,
            Salary,
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

        #region <- ListView : Objects ->
        private void listViewObjects_MouseDown(object sender, MouseEventArgs e)
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
                            listViewObjects_EditItem(sender);
                            return;
                        }

                    switch (Type)
                    {
                        case CurrencyDataType.Fixcost:
                            if (FormItemFixcost.Run() == DialogResult.OK) FormMain.FixcostManager.AppendItem(FormItemFixcost.Item);
                            break;

                        case CurrencyDataType.Salary:
                            if (FormItemSalary.Run() == DialogResult.OK) FormMain.SalaryManager.AppendItem(FormItemSalary.Item);
                            break;
                    }

                    UpdateItems();
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

        private void listViewObjects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listViewObjects_RemoveItem(sender);
            }
        }

        private void listViewObjects_RemoveItem(object sender)
        {
            var view = sender as ListView;
            if (view != null && view.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Sind Sie sicher das Sie das ausgewählte Element endgültig löschen möchten?", "Löschvorgang", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    switch (Type)
                    {
                        case CurrencyDataType.Fixcost:
                            FormMain.FixcostManager.RemoveItem(view.SelectedItems[0].Tag as Fixcost);
                            break;

                        case CurrencyDataType.Salary:
                            FormMain.SalaryManager.RemoveItem(view.SelectedItems[0].Tag as Salary);
                            break;
                    }

                    UpdateItems();
                }
            }
        }

        private void listViewObjects_EditItem(object sender)
        {
            var view = sender as ListView;
            if (view != null && view.SelectedItems.Count > 0)
            {
                switch (Type)
                {
                    case CurrencyDataType.Fixcost:
                        var fixcostItem = view.SelectedItems[0].Tag as Fixcost;
                        if (fixcostItem != null && FormItemFixcost.Run(fixcostItem) == DialogResult.OK)
                            FormMain.FixcostManager.ReplaceItem(fixcostItem, FormItemFixcost.Item);
                        break;

                    case CurrencyDataType.Salary:
                        var salaryItem = view.SelectedItems[0].Tag as Salary;
                        if (salaryItem != null && FormItemSalary.Run(salaryItem) == DialogResult.OK)
                            FormMain.SalaryManager.ReplaceItem(salaryItem, FormItemSalary.Item);
                        break;
                }

                UpdateItems();
            }
        }
        #endregion

        private void UpdateItems()
        {
            listViewObjects.Clear();

            List<CurrencyDataItem> items = null;

            switch (Type)
            {
                case CurrencyDataType.Fixcost:
                    items = FormMain.FixcostManager.Items.ToList<CurrencyDataItem>();

                    listViewObjects.Columns.Add("Name");
                    listViewObjects.Columns.Add("Beschreibung");
                    listViewObjects.Columns.Add("Preis");
                    break;

                case CurrencyDataType.Salary:
                    items = FormMain.SalaryManager.Items.ToList<CurrencyDataItem>();

                    listViewObjects.Columns.Add("Beschreibung");
                    listViewObjects.Columns.Add("Gehalt");
                    listViewObjects.Columns.Add("Datum");
                    break;
            }

            if (items.Count <= 0)
            {
                metroLabelEmptyLabel.Visible = true;
                return;
            }
            else metroLabelEmptyLabel.Visible = false;

            foreach (var item in items)
            {
                var listItem = new ListViewItem();

                switch (Type)
                {
                    case CurrencyDataType.Fixcost:
                        listItem.Text = item.Name;
                        listItem.SubItems.Add(item.Description);
                        listItem.SubItems.Add(item.Price.ToString("C2"));
                        break;

                    case CurrencyDataType.Salary:
                        var dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, (item as Salary).Payment);

                        listItem.Text = item.Description;
                        listItem.SubItems.Add(item.Price.ToString("C2"));
                        listItem.SubItems.Add(dateTime.ToLongDateString());
                        break;
                }

                listItem.Tag = item;
                listViewObjects.Items.Add(listItem);
            }

            listViewObjects.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewObjects.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void metroLabelEmptyLabel_MouseDown(object sender, MouseEventArgs e)
        {
            listViewObjects_MouseDown(listViewObjects, e);
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewObjects_RemoveItem(listViewObjects);
        }

        private void editierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewObjects_EditItem(listViewObjects);
        }
    }
}
