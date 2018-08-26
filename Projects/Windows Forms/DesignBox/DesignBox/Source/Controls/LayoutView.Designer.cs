namespace DesignBox.Source.Controls
{
    partial class LayoutView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutView));
            this.tlpTable = new DesignBox.Source.Controls.LayoutViewTablePanel();
            this.tsCommander = new System.Windows.Forms.ToolStrip();
            this.tsbtnInsertColumn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnInsertRow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnToolbar = new System.Windows.Forms.ToolStripButton();
            this.pToolbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.tsCommander.SuspendLayout();
            this.pToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTable
            // 
            this.tlpTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpTable.ColumnCount = 1;
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTable.Location = new System.Drawing.Point(0, 25);
            this.tlpTable.Name = "tlpTable";
            this.tlpTable.RowCount = 1;
            this.tlpTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTable.Size = new System.Drawing.Size(311, 223);
            this.tlpTable.TabIndex = 0;
            // 
            // tsCommander
            // 
            this.tsCommander.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCommander.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnInsertColumn,
            this.tsbtnInsertRow,
            this.toolStripSeparator1,
            this.tsbtnToolbar});
            this.tsCommander.Location = new System.Drawing.Point(0, 0);
            this.tsCommander.Name = "tsCommander";
            this.tsCommander.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsCommander.Size = new System.Drawing.Size(311, 25);
            this.tsCommander.TabIndex = 0;
            // 
            // tsbtnInsertColumn
            // 
            this.tsbtnInsertColumn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnInsertColumn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInsertColumn.Image")));
            this.tsbtnInsertColumn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInsertColumn.Name = "tsbtnInsertColumn";
            this.tsbtnInsertColumn.Size = new System.Drawing.Size(23, 22);
            this.tsbtnInsertColumn.Text = "toolStripButton1";
            this.tsbtnInsertColumn.Click += new System.EventHandler(this.tsbtnInsertColumn_Click);
            // 
            // tsbtnInsertRow
            // 
            this.tsbtnInsertRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnInsertRow.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInsertRow.Image")));
            this.tsbtnInsertRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInsertRow.Name = "tsbtnInsertRow";
            this.tsbtnInsertRow.Size = new System.Drawing.Size(23, 22);
            this.tsbtnInsertRow.Text = "toolStripButton2";
            this.tsbtnInsertRow.Click += new System.EventHandler(this.tsbtnInsertRow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnToolbar
            // 
            this.tsbtnToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnToolbar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnToolbar.Image")));
            this.tsbtnToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnToolbar.Name = "tsbtnToolbar";
            this.tsbtnToolbar.Size = new System.Drawing.Size(23, 22);
            this.tsbtnToolbar.Text = "toolStripButton1";
            this.tsbtnToolbar.Click += new System.EventHandler(this.tsbtnToolbar_Click);
            // 
            // pToolbar
            // 
            this.pToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.pToolbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pToolbar.Controls.Add(this.lblCell);
            this.pToolbar.Controls.Add(this.label1);
            this.pToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pToolbar.Location = new System.Drawing.Point(0, 248);
            this.pToolbar.Name = "pToolbar";
            this.pToolbar.Size = new System.Drawing.Size(311, 64);
            this.pToolbar.TabIndex = 0;
            this.pToolbar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cell:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(34, 1);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(27, 13);
            this.lblCell.TabIndex = 0;
            this.lblCell.Text = "N/A";
            // 
            // LayoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpTable);
            this.Controls.Add(this.pToolbar);
            this.Controls.Add(this.tsCommander);
            this.Name = "LayoutView";
            this.Size = new System.Drawing.Size(311, 312);
            this.tsCommander.ResumeLayout(false);
            this.tsCommander.PerformLayout();
            this.pToolbar.ResumeLayout(false);
            this.pToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsCommander;
        private System.Windows.Forms.ToolStripButton tsbtnInsertColumn;
        private System.Windows.Forms.ToolStripButton tsbtnInsertRow;
        private LayoutViewTablePanel tlpTable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnToolbar;
        private System.Windows.Forms.Panel pToolbar;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.Label label1;
    }
}
