namespace WorldStamper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControlMaps = new System.Windows.Forms.TabControl();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tileBox1 = new WorldStamperUI.UI.Toolkit.ImageBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControlToolkits = new System.Windows.Forms.TabControl();
            this.tabPageTilesets = new System.Windows.Forms.TabPage();
            this.panelTilesetsDrawing = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStripInformation = new System.Windows.Forms.StatusStrip();
            this.menuBar.SuspendLayout();
            this.tabControlToolkits.SuspendLayout();
            this.tabPageTilesets.SuspendLayout();
            this.panelTilesetsDrawing.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMaps
            // 
            this.tabControlMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMaps.Location = new System.Drawing.Point(0, 24);
            this.tabControlMaps.Name = "tabControlMaps";
            this.tabControlMaps.SelectedIndex = 0;
            this.tabControlMaps.Size = new System.Drawing.Size(444, 255);
            this.tabControlMaps.TabIndex = 1;
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(444, 24);
            this.menuBar.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.menuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemNew.Size = new System.Drawing.Size(141, 22);
            this.menuItemNew.Text = "New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuItemExit.Size = new System.Drawing.Size(141, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // tileBox1
            // 
            this.tileBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileBox1.Location = new System.Drawing.Point(6, 93);
            this.tileBox1.Name = "tileBox1";
            this.tileBox1.Size = new System.Drawing.Size(160, 154);
            this.tileBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // tabControlToolkits
            // 
            this.tabControlToolkits.Controls.Add(this.tabPageTilesets);
            this.tabControlToolkits.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlToolkits.Location = new System.Drawing.Point(444, 0);
            this.tabControlToolkits.Name = "tabControlToolkits";
            this.tabControlToolkits.SelectedIndex = 0;
            this.tabControlToolkits.Size = new System.Drawing.Size(180, 279);
            this.tabControlToolkits.TabIndex = 4;
            // 
            // tabPageTilesets
            // 
            this.tabPageTilesets.Controls.Add(this.panelTilesetsDrawing);
            this.tabPageTilesets.Controls.Add(this.comboBox2);
            this.tabPageTilesets.Controls.Add(this.comboBox1);
            this.tabPageTilesets.Controls.Add(this.tileBox1);
            this.tabPageTilesets.Location = new System.Drawing.Point(4, 22);
            this.tabPageTilesets.Name = "tabPageTilesets";
            this.tabPageTilesets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTilesets.Size = new System.Drawing.Size(172, 253);
            this.tabPageTilesets.TabIndex = 0;
            this.tabPageTilesets.Text = "Tilesets";
            this.tabPageTilesets.UseVisualStyleBackColor = true;
            // 
            // panelTilesetsDrawing
            // 
            this.panelTilesetsDrawing.Controls.Add(this.button2);
            this.panelTilesetsDrawing.Controls.Add(this.button1);
            this.panelTilesetsDrawing.Location = new System.Drawing.Point(6, 6);
            this.panelTilesetsDrawing.Name = "panelTilesetsDrawing";
            this.panelTilesetsDrawing.Size = new System.Drawing.Size(160, 30);
            this.panelTilesetsDrawing.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(30, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusStripInformation
            // 
            this.statusStripInformation.Location = new System.Drawing.Point(0, 279);
            this.statusStripInformation.Name = "statusStripInformation";
            this.statusStripInformation.Size = new System.Drawing.Size(624, 22);
            this.statusStripInformation.SizingGrip = false;
            this.statusStripInformation.TabIndex = 5;
            this.statusStripInformation.Text = "statusStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 301);
            this.Controls.Add(this.tabControlMaps);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.tabControlToolkits);
            this.Controls.Add(this.statusStripInformation);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuBar;
            this.MinimumSize = new System.Drawing.Size(640, 340);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.tabControlToolkits.ResumeLayout(false);
            this.tabPageTilesets.ResumeLayout(false);
            this.panelTilesetsDrawing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMaps;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private WorldStamperUI.UI.Toolkit.ImageBox tileBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControlToolkits;
        private System.Windows.Forms.TabPage tabPageTilesets;
        private System.Windows.Forms.StatusStrip statusStripInformation;
        private System.Windows.Forms.Panel panelTilesetsDrawing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

