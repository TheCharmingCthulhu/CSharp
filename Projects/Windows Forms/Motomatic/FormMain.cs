﻿using FastColoredTextBoxNS;
using Motomatic.Source;
using Motomatic.Source.Automation;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Motomatic
{
    public partial class FormMain : Form
    {
        Worker _worker = new Worker();

        public FormMain()
        {
            InitializeComponent();
            InitializeMotomatic();
        }

        private void InitializeMotomatic()
        {

        }

        #region <- Form ->
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _worker.End();
        }
        private void FormMain_Resize(object sender, System.EventArgs e)
        {

        } 
        #endregion

        private void buttonRun_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Time Required: " + new TimeSpan(Reflexor.Parse(fastColoredTextBoxScript.Text)).ToString());
        }

        #region <- Styles ->
        Style classes = new TextStyle(Brushes.Blue, Brushes.White, FontStyle.Underline);
        Style modules = new TextStyle(Brushes.Goldenrod, Brushes.White, FontStyle.Regular);
        Style parameters = new TextStyle(Brushes.ForestGreen, Brushes.White, FontStyle.Italic);
        #endregion

        private void fastColoredTextBoxScript_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle(classes);
            e.ChangedRange.SetStyle(classes, "([A-z0-9]{1,})->");

            e.ChangedRange.ClearStyle(modules);
            e.ChangedRange.SetStyle(modules, "([A-z0-9]{1,}):");

            e.ChangedRange.ClearStyle(parameters);
            e.ChangedRange.SetStyle(parameters, "([A-z0-9]{1,})[,;]");
        }
    }
}
