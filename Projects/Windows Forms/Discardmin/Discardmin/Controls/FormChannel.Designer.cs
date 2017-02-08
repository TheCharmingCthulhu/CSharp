namespace Discardmin.Controls
{
    partial class FormChannel
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChannel));
            this.tabControlAdministration = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.columnHeaderCheckbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxActions = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonApply = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControlAdministration.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdministration
            // 
            this.tabControlAdministration.Controls.Add(this.tabPage2);
            this.tabControlAdministration.Controls.Add(this.tabPage1);
            this.tabControlAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdministration.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdministration.Name = "tabControlAdministration";
            this.tabControlAdministration.SelectedIndex = 0;
            this.tabControlAdministration.Size = new System.Drawing.Size(423, 361);
            this.tabControlAdministration.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewMessages);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(415, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewMessages
            // 
            this.listViewMessages.CheckBoxes = true;
            this.listViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCheckbox,
            this.columnHeaderMessage});
            this.listViewMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMessages.FullRowSelect = true;
            this.listViewMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMessages.HideSelection = false;
            this.listViewMessages.Location = new System.Drawing.Point(3, 3);
            this.listViewMessages.MultiSelect = false;
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(409, 304);
            this.listViewMessages.TabIndex = 1;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCheckbox
            // 
            this.columnHeaderCheckbox.Text = "";
            // 
            // columnHeaderMessage
            // 
            this.columnHeaderMessage.Text = "Message";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButtonPrevious,
            this.toolStripButtonNext,
            this.toolStripSeparator1,
            this.toolStripTextBoxActions,
            this.toolStripButtonApply});
            this.toolStrip2.Location = new System.Drawing.Point(3, 307);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(409, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButtonPrevious
            // 
            this.toolStripButtonPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrevious.Image")));
            this.toolStripButtonPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrevious.Name = "toolStripButtonPrevious";
            this.toolStripButtonPrevious.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrevious.Text = "toolStripButton2";
            this.toolStripButtonPrevious.Click += new System.EventHandler(this.toolStripButtonPrevious_Click);
            // 
            // toolStripButtonNext
            // 
            this.toolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNext.Image")));
            this.toolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNext.Name = "toolStripButtonNext";
            this.toolStripButtonNext.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNext.Text = "toolStripButton4";
            this.toolStripButtonNext.Click += new System.EventHandler(this.toolStripButtonNext_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBoxActions
            // 
            this.toolStripTextBoxActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripTextBoxActions.Items.AddRange(new object[] {
            "Pin",
            "Delete"});
            this.toolStripTextBoxActions.Name = "toolStripTextBoxActions";
            this.toolStripTextBoxActions.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonApply
            // 
            this.toolStripButtonApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonApply.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonApply.Image")));
            this.toolStripButtonApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonApply.Name = "toolStripButtonApply";
            this.toolStripButtonApply.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonApply.Text = "toolStripButton3";
            this.toolStripButtonApply.Click += new System.EventHandler(this.toolStripButtonApply_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(415, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(3, 307);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(409, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlAdministration);
            this.Name = "FormChannel";
            this.Size = new System.Drawing.Size(423, 361);
            this.tabControlAdministration.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdministration;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrevious;
        private System.Windows.Forms.ToolStripButton toolStripButtonApply;
        private System.Windows.Forms.ToolStripButton toolStripButtonNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripTextBoxActions;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.ColumnHeader columnHeaderMessage;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckbox;
    }
}
