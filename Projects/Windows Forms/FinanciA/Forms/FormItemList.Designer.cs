namespace FinanciA.Forms
{
    partial class FormItemList
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
            this.components = new System.ComponentModel.Container();
            this.listViewObjects = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabelEmptyLabel = new MetroFramework.Controls.MetroLabel();
            this.contextMenuStripOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFixcosts
            // 
            this.listViewObjects.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewObjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewObjects.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewObjects.FullRowSelect = true;
            this.listViewObjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewObjects.HideSelection = false;
            this.listViewObjects.Location = new System.Drawing.Point(20, 60);
            this.listViewObjects.MultiSelect = false;
            this.listViewObjects.Name = "listViewFixcosts";
            this.listViewObjects.Size = new System.Drawing.Size(390, 220);
            this.listViewObjects.TabIndex = 0;
            this.listViewObjects.UseCompatibleStateImageBehavior = false;
            this.listViewObjects.View = System.Windows.Forms.View.Details;
            this.listViewObjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewObjects_KeyDown);
            this.listViewObjects.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewObjects_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Beschreibung";
            this.columnHeader2.Width = 25;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preis";
            // 
            // metroLabelEmptyLabel
            // 
            this.metroLabelEmptyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabelEmptyLabel.Location = new System.Drawing.Point(20, 60);
            this.metroLabelEmptyLabel.Name = "metroLabelEmptyLabel";
            this.metroLabelEmptyLabel.Size = new System.Drawing.Size(390, 220);
            this.metroLabelEmptyLabel.TabIndex = 1;
            this.metroLabelEmptyLabel.Text = "Leer Doppelklick zum Hinzufügen";
            this.metroLabelEmptyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelEmptyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroLabelEmptyLabel_MouseDown);
            // 
            // contextMenuStripOptions
            // 
            this.contextMenuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editierenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.contextMenuStripOptions.Name = "contextMenuStripOptions";
            this.contextMenuStripOptions.Size = new System.Drawing.Size(121, 48);
            // 
            // editierenToolStripMenuItem
            // 
            this.editierenToolStripMenuItem.Name = "editierenToolStripMenuItem";
            this.editierenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editierenToolStripMenuItem.Text = "Editieren";
            this.editierenToolStripMenuItem.Click += new System.EventHandler(this.editierenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // FormItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.Controls.Add(this.metroLabelEmptyLabel);
            this.Controls.Add(this.listViewObjects);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormItemList";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Items";
            this.contextMenuStripOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewObjects;
        private MetroFramework.Controls.MetroLabel metroLabelEmptyLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem editierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
    }
}