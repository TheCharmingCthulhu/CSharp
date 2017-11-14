using System;
using System.Windows.Forms;
using Expansion.Source;
using Finman.Source.Dialogs;
using Finman.Source;
using System.Collections.Specialized;
using System.Linq;
using System.Collections.ObjectModel;

namespace Finman
{
    public partial class FormMain : Form
    {
        public static StorageSystem AppSettings = new StorageSystem("Finman");
        public static Folder DataFolder;
        public static FinmanManager RootManager;

        const string TAG_FIXCOST = "Fixcost";
        const string TAG_SERVICE = "Service";
        ListView _DataList;

        #region <- Initialization ->
        public FormMain()
        {
            InitializeComponent();

            tabControlData_SelectedIndexChanged(tabControlData, null);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeManager();
            InitializeSettings();

            listViewFixcosts.Tag = TAG_FIXCOST;
            listViewServices.Tag = TAG_SERVICE;
        }

        private void InitializeManager()
        {
            RootManager = new FinmanManager();
            RootManager.Fixcosts.CollectionChanged += Items_CollectionChanged;
            RootManager.Services.CollectionChanged += Items_CollectionChanged;
        }

        private void InitializeSettings()
        {
            DataFolder = AppSettings.RootFolder.AddFolder("Data");

            if (DataFolder.HasFile(TAG_FIXCOST))
            {
                var fixcostItems = DataFolder.GetFile<FixcostItem[]>(TAG_FIXCOST);
                foreach (var fixcostItem in fixcostItems) RootManager.Fixcosts.Add(fixcostItem);
            }

            if (DataFolder.HasFile(TAG_SERVICE))
            {
                var serviceItems = DataFolder.GetFile<ServiceItem[]>(TAG_SERVICE);
                foreach (var serviceItem in serviceItems) RootManager.Services.Add(serviceItem);
            }
        }
        #endregion

        private void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                case NotifyCollectionChangedAction.Remove:
                    switch (_DataList.Tag.ToString())
                    {
                        case TAG_FIXCOST:
                            DataFolder.AddFile(_DataList.Tag.ToString(), RootManager.Fixcosts.ToArray());
                            break;
                        case TAG_SERVICE:
                            DataFolder.AddFile(_DataList.Tag.ToString(), RootManager.Services.ToArray());
                            break;
                    }
                    break;
            }

            if (e.NewItems != null && e.NewItems.Count > 0)
            {
                foreach (var item in e.NewItems)
                {
                    var listItem = new ListViewItem();
                    listItem.Checked = true;

                    if (sender is ObservableCollection<FixcostItem>)
                    {
                        var fixcostItem = item as FixcostItem;

                        listItem.Text = fixcostItem.Name;
                        listItem.SubItems.Add(fixcostItem.Price.ToString("C2"));
                        listItem.Tag = item;

                        listViewFixcosts.Items.Add(listItem);

                        continue;
                    }

                    if (sender is ObservableCollection<ServiceItem>)
                    {
                        var serviceItem = item as ServiceItem;

                        listItem.Text = serviceItem.Name;
                        listItem.SubItems.Add(serviceItem.Price.ToString("C2"));
                        listItem.Tag = item;

                        listViewServices.Items.Add(listItem);

                        continue;
                    }
                }
            }

            _DataList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            UpdateForm();
        }

        private void UpdateForm()
        {
            decimal salary = 0, fixcosts = 0, food = 0;

            foreach (ListViewItem item in listViewServices.Items)
            {
                if (item.Checked) salary += (item.Tag as ServiceItem).Price;
            }

            foreach(ListViewItem item in listViewFixcosts.Items)
            {
                if (item.Checked) fixcosts += (item.Tag as FixcostItem).Price;
            }

            food = (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) * RootManager.DailyAmount);

            textBoxSalary.Text = salary.ToString("C2");
            textBoxFixcosts.Text = string.Format("- {0}", fixcosts.ToString("C2"));
            textBoxSum.Text = (salary - fixcosts).ToString("C2");
            textBoxAllowance.Text = ((salary - fixcosts) - food).ToString("C2");
            textBoxFood.Text = food.ToString("C2");
        }

        #region <- Functions : Toolstrip ->
        private void toolStripButtonItemAdd_Click(object sender, EventArgs e)
        {
            switch(_DataList.Tag.ToString())
            {
                case TAG_FIXCOST:
                    if (DialogItemFixcost.Run() == DialogResult.OK)
                        RootManager.Fixcosts.Add(DialogItemFixcost.Item);
                    break;
                case TAG_SERVICE:
                    if (DialogItemService.Run() == DialogResult.OK)
                        RootManager.Services.Add(DialogItemService.Item);
                    break;
            }
        }

        private void toolStripButtonItemRemove_Click(object sender, EventArgs e)
        {
            if (_DataList.SelectedItems.Count > 0)
            {
                RootManager.Remove(_DataList.SelectedItems[0].Tag);

                _DataList.Items.Remove(_DataList.SelectedItems[0]);
            }
        }
        #endregion

        private void tabControlData_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as TabControl;
            var tabPage = view.SelectedTab;
            if (tabPage != null)
            {
                foreach (var ctrl in tabPage.Controls)
                    if (ctrl is ListView)
                    {
                        _DataList = ctrl as ListView;
                        _DataList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                        break;
                    }
            }
        }

        private void listViewFixcosts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void listViewFixcosts_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateForm();
        }
    }
}
