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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("+ New Event Chain");
            this.splitContainerBasePanel = new System.Windows.Forms.SplitContainer();
            this.treeViewEventManager = new System.Windows.Forms.TreeView();
            this.tabControlEventChains = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBasePanel)).BeginInit();
            this.splitContainerBasePanel.Panel1.SuspendLayout();
            this.splitContainerBasePanel.Panel2.SuspendLayout();
            this.splitContainerBasePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerBasePanel
            // 
            this.splitContainerBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBasePanel.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBasePanel.Name = "splitContainerBasePanel";
            // 
            // splitContainerBasePanel.Panel1
            // 
            this.splitContainerBasePanel.Panel1.Controls.Add(this.treeViewEventManager);
            // 
            // splitContainerBasePanel.Panel2
            // 
            this.splitContainerBasePanel.Panel2.Controls.Add(this.tabControlEventChains);
            this.splitContainerBasePanel.Size = new System.Drawing.Size(784, 601);
            this.splitContainerBasePanel.SplitterDistance = 226;
            this.splitContainerBasePanel.SplitterWidth = 8;
            this.splitContainerBasePanel.TabIndex = 0;
            // 
            // treeViewEventManager
            // 
            this.treeViewEventManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewEventManager.HideSelection = false;
            this.treeViewEventManager.HotTracking = true;
            this.treeViewEventManager.Location = new System.Drawing.Point(0, 0);
            this.treeViewEventManager.Name = "treeViewEventManager";
            treeNode1.Name = "nodeInsertEvent";
            treeNode1.Tag = "+NewEventChain";
            treeNode1.Text = "+ New Event Chain";
            this.treeViewEventManager.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewEventManager.Size = new System.Drawing.Size(226, 601);
            this.treeViewEventManager.TabIndex = 0;
            this.treeViewEventManager.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewEventManager_NodeMouseClick);
            this.treeViewEventManager.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeViewEventManager_MouseMove);
            // 
            // tabControlEventChains
            // 
            this.tabControlEventChains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEventChains.Location = new System.Drawing.Point(0, 0);
            this.tabControlEventChains.Name = "tabControlEventChains";
            this.tabControlEventChains.SelectedIndex = 0;
            this.tabControlEventChains.Size = new System.Drawing.Size(550, 601);
            this.tabControlEventChains.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.splitContainerBasePanel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 640);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motomatic";
            this.splitContainerBasePanel.Panel1.ResumeLayout(false);
            this.splitContainerBasePanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBasePanel)).EndInit();
            this.splitContainerBasePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerBasePanel;
        private System.Windows.Forms.TreeView treeViewEventManager;
        private System.Windows.Forms.TabControl tabControlEventChains;
    }
}

