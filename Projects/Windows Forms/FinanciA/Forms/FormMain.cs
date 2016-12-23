using MetroFramework.Forms;
using FinanciA.Source;
using FinanciA.Forms;
using System;
using System.Diagnostics;
using FinanciA.Forms.Items;

namespace FinanciA
{
    public partial class FormMain : MetroForm
    {
        public static FixcostManager FixcostManager = new FixcostManager();
        public static SalaryManager SalaryManager = new SalaryManager();

        public FormMain(string[] args)
        {
            InitializeComponent();

            ParseArguments(args);
        }

        private void ParseArguments(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0].ToLower().Equals("--overview"))
                {
                    FormOverview.Run();
                    Environment.Exit(0);
                }
            }
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            InitializePages();
            UpdateStatistics();
            UpdateTime();
        }

        private void UpdateStatistics()
        {
            metroLabelFixcosts.Text = FixcostManager.GetSum().ToString("C2");
            metroLabelSalary.Text = SalaryManager.GetSum().ToString("C2");
            metroLabelAllowance.Text = (SalaryManager.GetSum() - FixcostManager.GetSum()).ToString("C2");
        }

        private void UpdateTime()
        {
            metroLabelDateTime.Text = string.Format("{0} - {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
        }

        private void InitializePages()
        {
            tileExplorerToolset.InsertPage();
            tileExplorerToolset.Pages[0].GetPageItem(0).Caption = "Fixkosten";
            tileExplorerToolset.Pages[0].GetPageItem(0).Method = (pageItem) =>
            {
                FormItemList.Run(this, FormItemList.CurrencyDataType.Fixcost, pageItem.Caption);

                UpdateStatistics();
            };

            tileExplorerToolset.Pages[0].GetPageItem(1).Caption = "Gehalt";
            tileExplorerToolset.Pages[0].GetPageItem(1).Method = (pageItem) =>
            {
                FormItemList.Run(this, FormItemList.CurrencyDataType.Salary, pageItem.Caption);

                UpdateStatistics();
            };

            tileExplorerToolset.Pages[0].GetPageItem(2).Caption = "Überblick";
            tileExplorerToolset.Pages[0].GetPageItem(2).Method = (pageItem) =>
            {
                FormOverview.Run();

                UpdateStatistics();
            };

            tileExplorerToolset.Pages[0].GetPageItem(3).Caption = "Einstellungen";
            tileExplorerToolset.Pages[0].GetPageItem(3).Method = (pageItem) =>
            {

                UpdateStatistics();
            };

            tileExplorerToolset.UpdateView();
        }

        private void timerUpdate_Tick(object sender, System.EventArgs e)
        {
            UpdateTime();
        }
    }
}
