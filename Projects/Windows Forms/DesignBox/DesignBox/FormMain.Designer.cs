namespace DesignBox
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tctrlFrames = new System.Windows.Forms.TabControl();
            this.tsToolset = new System.Windows.Forms.ToolStrip();
            this.tscbUserControls = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCreateTab = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDeleteTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pgrdControl = new System.Windows.Forms.PropertyGrid();
            this.tsToolset.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrlFrames
            // 
            this.tctrlFrames.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tctrlFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlFrames.Location = new System.Drawing.Point(0, 0);
            this.tctrlFrames.Name = "tctrlFrames";
            this.tctrlFrames.SelectedIndex = 0;
            this.tctrlFrames.Size = new System.Drawing.Size(534, 416);
            this.tctrlFrames.TabIndex = 0;
            this.tctrlFrames.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tctrlFrames_Selecting);
            // 
            // tsToolset
            // 
            this.tsToolset.CanOverflow = false;
            this.tsToolset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsToolset.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsToolset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbUserControls,
            this.toolStripSeparator1,
            this.tsbtnCreateTab,
            this.tsbtnDeleteTab,
            this.toolStripSeparator3});
            this.tsToolset.Location = new System.Drawing.Point(0, 416);
            this.tsToolset.Name = "tsToolset";
            this.tsToolset.Size = new System.Drawing.Size(784, 25);
            this.tsToolset.TabIndex = 1;
            // 
            // tscbUserControls
            // 
            this.tscbUserControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbUserControls.Name = "tscbUserControls";
            this.tscbUserControls.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnCreateTab
            // 
            this.tsbtnCreateTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCreateTab.Image = global::DesignBox.Properties.Resources.application_form_add;
            this.tsbtnCreateTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCreateTab.Name = "tsbtnCreateTab";
            this.tsbtnCreateTab.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCreateTab.Text = "toolStripButton2";
            this.tsbtnCreateTab.Click += new System.EventHandler(this.tsbtnCreateTab_Click);
            // 
            // tsbtnDeleteTab
            // 
            this.tsbtnDeleteTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDeleteTab.Image = global::DesignBox.Properties.Resources.application_form_delete;
            this.tsbtnDeleteTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDeleteTab.Name = "tsbtnDeleteTab";
            this.tsbtnDeleteTab.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDeleteTab.Text = "toolStripButton1";
            this.tsbtnDeleteTab.Click += new System.EventHandler(this.tsbtnDeleteTab_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // pgrdControl
            // 
            this.pgrdControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pgrdControl.Location = new System.Drawing.Point(534, 0);
            this.pgrdControl.Name = "pgrdControl";
            this.pgrdControl.Size = new System.Drawing.Size(250, 416);
            this.pgrdControl.TabIndex = 4;
            this.pgrdControl.ToolbarVisible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tctrlFrames);
            this.Controls.Add(this.pgrdControl);
            this.Controls.Add(this.tsToolset);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tsToolset.ResumeLayout(false);
            this.tsToolset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlFrames;
        private System.Windows.Forms.ToolStrip tsToolset;
        private System.Windows.Forms.ToolStripComboBox tscbUserControls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnCreateTab;
        private System.Windows.Forms.ToolStripButton tsbtnDeleteTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.PropertyGrid pgrdControl;
    }
}

