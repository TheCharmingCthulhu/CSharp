namespace Motomatic
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainerBasePanel = new System.Windows.Forms.SplitContainer();
            this.listViewEventChains = new System.Windows.Forms.ListView();
            this.toolStripToolset = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewEventChain = new System.Windows.Forms.ToolStripButton();
            this.fastColoredTextBoxScript = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBasePanel)).BeginInit();
            this.splitContainerBasePanel.Panel1.SuspendLayout();
            this.splitContainerBasePanel.Panel2.SuspendLayout();
            this.splitContainerBasePanel.SuspendLayout();
            this.toolStripToolset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxScript)).BeginInit();
            this.statusStripInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerBasePanel
            // 
            this.splitContainerBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBasePanel.Location = new System.Drawing.Point(8, 8);
            this.splitContainerBasePanel.Name = "splitContainerBasePanel";
            // 
            // splitContainerBasePanel.Panel1
            // 
            this.splitContainerBasePanel.Panel1.Controls.Add(this.listViewEventChains);
            this.splitContainerBasePanel.Panel1.Controls.Add(this.toolStripToolset);
            // 
            // splitContainerBasePanel.Panel2
            // 
            this.splitContainerBasePanel.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerBasePanel.Panel2.Controls.Add(this.fastColoredTextBoxScript);
            this.splitContainerBasePanel.Panel2.Controls.Add(this.panel1);
            this.splitContainerBasePanel.Panel2.Controls.Add(this.listViewEvents);
            this.splitContainerBasePanel.Size = new System.Drawing.Size(768, 571);
            this.splitContainerBasePanel.SplitterDistance = 218;
            this.splitContainerBasePanel.SplitterWidth = 8;
            this.splitContainerBasePanel.TabIndex = 0;
            // 
            // listViewEventChains
            // 
            this.listViewEventChains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEventChains.Location = new System.Drawing.Point(0, 0);
            this.listViewEventChains.Name = "listViewEventChains";
            this.listViewEventChains.Size = new System.Drawing.Size(218, 546);
            this.listViewEventChains.TabIndex = 2;
            this.listViewEventChains.UseCompatibleStateImageBehavior = false;
            this.listViewEventChains.View = System.Windows.Forms.View.SmallIcon;
            this.listViewEventChains.SelectedIndexChanged += new System.EventHandler(this.listViewEventChains_SelectedIndexChanged);
            // 
            // toolStripToolset
            // 
            this.toolStripToolset.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripToolset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripToolset.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripToolset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewEventChain});
            this.toolStripToolset.Location = new System.Drawing.Point(0, 546);
            this.toolStripToolset.Name = "toolStripToolset";
            this.toolStripToolset.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripToolset.Size = new System.Drawing.Size(218, 25);
            this.toolStripToolset.TabIndex = 1;
            this.toolStripToolset.Text = "toolStrip1";
            // 
            // toolStripButtonNewEventChain
            // 
            this.toolStripButtonNewEventChain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewEventChain.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewEventChain.Image")));
            this.toolStripButtonNewEventChain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewEventChain.Name = "toolStripButtonNewEventChain";
            this.toolStripButtonNewEventChain.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewEventChain.Text = "toolStripButton1";
            this.toolStripButtonNewEventChain.Click += new System.EventHandler(this.toolStripButtonNewEventChain_Click);
            // 
            // fastColoredTextBoxScript
            // 
            this.fastColoredTextBoxScript.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBoxScript.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBoxScript.BackBrush = null;
            this.fastColoredTextBoxScript.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fastColoredTextBoxScript.CharHeight = 14;
            this.fastColoredTextBoxScript.CharWidth = 8;
            this.fastColoredTextBoxScript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxScript.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBoxScript.Enabled = false;
            this.fastColoredTextBoxScript.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBoxScript.IsReplaceMode = false;
            this.fastColoredTextBoxScript.Location = new System.Drawing.Point(0, 158);
            this.fastColoredTextBoxScript.Name = "fastColoredTextBoxScript";
            this.fastColoredTextBoxScript.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxScript.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxScript.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxScript.ServiceColors")));
            this.fastColoredTextBoxScript.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.fastColoredTextBoxScript.Size = new System.Drawing.Size(542, 413);
            this.fastColoredTextBoxScript.TabIndex = 4;
            this.fastColoredTextBoxScript.Zoom = 100;
            this.fastColoredTextBoxScript.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBoxScript_TextChanged);
            this.fastColoredTextBoxScript.Load += new System.EventHandler(this.fastColoredTextBoxScript_Load);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 5);
            this.panel1.TabIndex = 5;
            // 
            // listViewEvents
            // 
            this.listViewEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewEvents.Location = new System.Drawing.Point(0, 0);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(542, 153);
            this.listViewEvents.TabIndex = 3;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.Tile;
            this.listViewEvents.SelectedIndexChanged += new System.EventHandler(this.listViewEvents_SelectedIndexChanged);
            this.listViewEvents.DoubleClick += new System.EventHandler(this.listViewEvents_DoubleClick);
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripInfo.Location = new System.Drawing.Point(8, 579);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(768, 22);
            this.statusStripInfo.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Running: N/A";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.splitContainerBasePanel);
            this.Controls.Add(this.statusStripInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 640);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motomatic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.splitContainerBasePanel.Panel1.ResumeLayout(false);
            this.splitContainerBasePanel.Panel1.PerformLayout();
            this.splitContainerBasePanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBasePanel)).EndInit();
            this.splitContainerBasePanel.ResumeLayout(false);
            this.toolStripToolset.ResumeLayout(false);
            this.toolStripToolset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxScript)).EndInit();
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerBasePanel;
        private System.Windows.Forms.ToolStrip toolStripToolset;
        private System.Windows.Forms.ListView listViewEventChains;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewEventChain;
        private System.Windows.Forms.ListView listViewEvents;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxScript;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

