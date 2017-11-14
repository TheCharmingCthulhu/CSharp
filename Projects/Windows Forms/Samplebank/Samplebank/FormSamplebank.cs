using System.Windows.Forms;
using System;
using Samplebank.Source;
using Samplebank.Source.Models;
using FsqLite.Source;
using System.Data;

namespace Samplebank
{
    public partial class FormSamplebank : Form
    {
        public static Database Database { get; private set; } = new Database();

        public FormSamplebank()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            // # TABLES
            Database.Tables.Create(Types.APP_TABLE_SAMPLES, typeof(Sample));
        }

        private void FormSamplebank_Load(object sender, System.EventArgs e)
        {
            if (Database.ExecuteQuery(Types.APP_TABLE_SAMPLES))
                UpdateListView();
        }

        private void UpdateListView()
        {
            listViewSamples.Clear();

            var table = Database.Tables.Get(Types.APP_TABLE_SAMPLES);

            foreach (Column column in table.Columns)
                listViewSamples.Columns.Add(column.Name);

            foreach (Row row in table.Rows)
            {
                var items = row.ToStringArray();
                var item = new ListViewItem();
                item.Text = items[0];

                for (int i = 1; i < table.Columns.Count; i++)
                    item.SubItems.Add(items[i]);

                listViewSamples.Items.Add(item);
            }

            listViewSamples.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void buttonImportSamples_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "Wave Files (*.wav, *.wave)|*.wav;*.wave"
            };

            if (opf.ShowDialog() == DialogResult.OK)
            {
                var table = Database.Tables.Get(Types.APP_TABLE_SAMPLES);

                foreach (var path in opf.FileNames)
                    table.Insert(new Sample(path));

                Database.ExecuteInsert(Types.APP_TABLE_SAMPLES);

                UpdateListView();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            if (listViewSamples.SelectedItems.Count > 0)
                foreach (ListViewItem item in listViewSamples.SelectedItems)
                    return;
        }

        private void listViewSamples_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var view = sender as ListView;

            //if (view.SelectedItems.Count > 0)
            //    if (view.SelectedItems[0].Tag is Sample)
            //    {
            //        string indexes = "";
            //        bool cutoff = false;

            //        for (int i = 0; i < view.SelectedItems.Count; i++)
            //        {
            //            //indexes += (view.SelectedItems[i].Tag as Sample).ID.ToString() + ",";

            //            if (i > 3)
            //            {
            //                cutoff = true;
            //                break;
            //            }
            //        }

            //        indexes = indexes.Remove(indexes.Length - 1);

            //        tsLblSampleIndex.Text = "Index:" + indexes + ((cutoff) ? "..." : "");
            //    }
        }
    }
}
