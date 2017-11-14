namespace Samplebank
{
    partial class FormSamplebank
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSamplebank));
            this.listViewSamples = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonImportSamples = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tsLblSampleIndex = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnTruncate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSamples
            // 
            this.listViewSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSamples.FullRowSelect = true;
            this.listViewSamples.HideSelection = false;
            this.listViewSamples.Location = new System.Drawing.Point(0, 25);
            this.listViewSamples.Name = "listViewSamples";
            this.listViewSamples.Size = new System.Drawing.Size(502, 295);
            this.listViewSamples.TabIndex = 0;
            this.listViewSamples.UseCompatibleStateImageBehavior = false;
            this.listViewSamples.View = System.Windows.Forms.View.Details;
            this.listViewSamples.SelectedIndexChanged += new System.EventHandler(this.listViewSamples_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonImportSamples);
            this.panel1.Location = new System.Drawing.Point(517, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 320);
            this.panel1.TabIndex = 2;
            // 
            // buttonImportSamples
            // 
            this.buttonImportSamples.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonImportSamples.Location = new System.Drawing.Point(0, 0);
            this.buttonImportSamples.Name = "buttonImportSamples";
            this.buttonImportSamples.Size = new System.Drawing.Size(190, 23);
            this.buttonImportSamples.TabIndex = 0;
            this.buttonImportSamples.Text = "Import Samples";
            this.buttonImportSamples.UseVisualStyleBackColor = true;
            this.buttonImportSamples.Click += new System.EventHandler(this.buttonImportSamples_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnDelete,
            this.toolStripSeparator1,
            this.tsLblSampleIndex,
            this.toolStripSeparator2,
            this.tsBtnTruncate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(502, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelete.Image")));
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDelete.Text = "toolStripButton1";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewSamples);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Location = new System.Drawing.Point(12, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 320);
            this.panel2.TabIndex = 4;
            // 
            // tsLblSampleIndex
            // 
            this.tsLblSampleIndex.Name = "tsLblSampleIndex";
            this.tsLblSampleIndex.Size = new System.Drawing.Size(63, 22);
            this.tsLblSampleIndex.Text = "Index: N/A";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnTruncate
            // 
            this.tsBtnTruncate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnTruncate.Enabled = false;
            this.tsBtnTruncate.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnTruncate.Image")));
            this.tsBtnTruncate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnTruncate.Name = "tsBtnTruncate";
            this.tsBtnTruncate.Size = new System.Drawing.Size(23, 22);
            this.tsBtnTruncate.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FormSamplebank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormSamplebank";
            this.Text = "Samplebank";
            this.Load += new System.EventHandler(this.FormSamplebank_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSamples;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonImportSamples;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsLblSampleIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnTruncate;
    }
}

