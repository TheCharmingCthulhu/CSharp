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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxImages = new System.Windows.Forms.ComboBox();
            this.comboBoxTilesets = new System.Windows.Forms.ComboBox();
            this.tabControlToolkits = new System.Windows.Forms.TabControl();
            this.tabPageTilesets = new System.Windows.Forms.TabPage();
            this.panelTilesetsDrawing = new System.Windows.Forms.Panel();
            this.buttonPaint = new System.Windows.Forms.Button();
            this.buttonCursor = new System.Windows.Forms.Button();
            this.imageBoxTiles = new WorldStamperUI.UI.Toolkit.ImageBox();
            this.tabPageEntities = new System.Windows.Forms.TabPage();
            this.statusStripInformation = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusToolMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabsMaps = new ElegantUI.Controls.Tabs();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuBar.SuspendLayout();
            this.tabControlToolkits.SuspendLayout();
            this.tabPageTilesets.SuspendLayout();
            this.panelTilesetsDrawing.SuspendLayout();
            this.statusStripInformation.SuspendLayout();
            this.tabsMaps.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(828, 24);
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
            this.menuItemNew.Size = new System.Drawing.Size(143, 22);
            this.menuItemNew.Text = "New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.menuItemLoad_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuItemExit.Size = new System.Drawing.Size(143, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // comboBoxImages
            // 
            this.comboBoxImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImages.Enabled = false;
            this.comboBoxImages.FormattingEnabled = true;
            this.comboBoxImages.Location = new System.Drawing.Point(6, 66);
            this.comboBoxImages.Name = "comboBoxImages";
            this.comboBoxImages.Size = new System.Drawing.Size(160, 21);
            this.comboBoxImages.TabIndex = 2;
            this.comboBoxImages.SelectedIndexChanged += new System.EventHandler(this.comboBoxImages_SelectedIndexChanged);
            // 
            // comboBoxTilesets
            // 
            this.comboBoxTilesets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTilesets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTilesets.Enabled = false;
            this.comboBoxTilesets.FormattingEnabled = true;
            this.comboBoxTilesets.Location = new System.Drawing.Point(6, 39);
            this.comboBoxTilesets.Name = "comboBoxTilesets";
            this.comboBoxTilesets.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTilesets.TabIndex = 3;
            this.comboBoxTilesets.SelectedIndexChanged += new System.EventHandler(this.comboBoxTilesets_SelectedIndexChanged);
            // 
            // tabControlToolkits
            // 
            this.tabControlToolkits.Controls.Add(this.tabPageTilesets);
            this.tabControlToolkits.Controls.Add(this.tabPageEntities);
            this.tabControlToolkits.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlToolkits.Location = new System.Drawing.Point(828, 0);
            this.tabControlToolkits.Name = "tabControlToolkits";
            this.tabControlToolkits.SelectedIndex = 0;
            this.tabControlToolkits.Size = new System.Drawing.Size(180, 419);
            this.tabControlToolkits.TabIndex = 4;
            // 
            // tabPageTilesets
            // 
            this.tabPageTilesets.Controls.Add(this.panelTilesetsDrawing);
            this.tabPageTilesets.Controls.Add(this.comboBoxTilesets);
            this.tabPageTilesets.Controls.Add(this.comboBoxImages);
            this.tabPageTilesets.Controls.Add(this.imageBoxTiles);
            this.tabPageTilesets.Location = new System.Drawing.Point(4, 22);
            this.tabPageTilesets.Name = "tabPageTilesets";
            this.tabPageTilesets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTilesets.Size = new System.Drawing.Size(172, 393);
            this.tabPageTilesets.TabIndex = 0;
            this.tabPageTilesets.Text = "Tilesets";
            this.tabPageTilesets.UseVisualStyleBackColor = true;
            // 
            // panelTilesetsDrawing
            // 
            this.panelTilesetsDrawing.Controls.Add(this.buttonPaint);
            this.panelTilesetsDrawing.Controls.Add(this.buttonCursor);
            this.panelTilesetsDrawing.Location = new System.Drawing.Point(6, 6);
            this.panelTilesetsDrawing.Name = "panelTilesetsDrawing";
            this.panelTilesetsDrawing.Size = new System.Drawing.Size(160, 30);
            this.panelTilesetsDrawing.TabIndex = 4;
            // 
            // buttonPaint
            // 
            this.buttonPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaint.Image")));
            this.buttonPaint.Location = new System.Drawing.Point(30, 3);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(24, 24);
            this.buttonPaint.TabIndex = 1;
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // buttonCursor
            // 
            this.buttonCursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCursor.Image = ((System.Drawing.Image)(resources.GetObject("buttonCursor.Image")));
            this.buttonCursor.Location = new System.Drawing.Point(0, 3);
            this.buttonCursor.Name = "buttonCursor";
            this.buttonCursor.Size = new System.Drawing.Size(24, 24);
            this.buttonCursor.TabIndex = 0;
            this.buttonCursor.UseVisualStyleBackColor = true;
            this.buttonCursor.Click += new System.EventHandler(this.buttonCursor_Click);
            // 
            // imageBoxTiles
            // 
            this.imageBoxTiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxTiles.BackColor = System.Drawing.Color.White;
            this.imageBoxTiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxTiles.Enabled = false;
            this.imageBoxTiles.ImageHeight = 32;
            this.imageBoxTiles.ImageWidth = 32;
            this.imageBoxTiles.Location = new System.Drawing.Point(6, 93);
            this.imageBoxTiles.Name = "imageBoxTiles";
            this.imageBoxTiles.Size = new System.Drawing.Size(160, 294);
            this.imageBoxTiles.TabIndex = 0;
            this.imageBoxTiles.ImageSelected += new WorldStamperUI.UI.Toolkit.ImageBox.ImageBoxHandler(this.imageBoxTiles_ImageSelected);
            // 
            // tabPageEntities
            // 
            this.tabPageEntities.BackColor = System.Drawing.Color.White;
            this.tabPageEntities.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntities.Name = "tabPageEntities";
            this.tabPageEntities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntities.Size = new System.Drawing.Size(172, 393);
            this.tabPageEntities.TabIndex = 1;
            this.tabPageEntities.Text = "Entities";
            // 
            // statusStripInformation
            // 
            this.statusStripInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusToolMode});
            this.statusStripInformation.Location = new System.Drawing.Point(0, 419);
            this.statusStripInformation.Name = "statusStripInformation";
            this.statusStripInformation.Size = new System.Drawing.Size(1008, 22);
            this.statusStripInformation.SizingGrip = false;
            this.statusStripInformation.TabIndex = 5;
            this.statusStripInformation.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "Tool:";
            // 
            // toolStripStatusToolMode
            // 
            this.toolStripStatusToolMode.Name = "toolStripStatusToolMode";
            this.toolStripStatusToolMode.Size = new System.Drawing.Size(0, 17);
            // 
            // tabsMaps
            // 
            this.tabsMaps.Controls.Add(this.tabPage1);
            this.tabsMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsMaps.Location = new System.Drawing.Point(0, 24);
            this.tabsMaps.Name = "tabsMaps";
            this.tabsMaps.SelectedIndex = 0;
            this.tabsMaps.Size = new System.Drawing.Size(828, 395);
            this.tabsMaps.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 441);
            this.Controls.Add(this.tabsMaps);
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
            this.statusStripInformation.ResumeLayout(false);
            this.statusStripInformation.PerformLayout();
            this.tabsMaps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private WorldStamperUI.UI.Toolkit.ImageBox imageBoxTiles;
        private System.Windows.Forms.ComboBox comboBoxTilesets;
        private System.Windows.Forms.ComboBox comboBoxImages;
        private System.Windows.Forms.TabControl tabControlToolkits;
        private System.Windows.Forms.TabPage tabPageTilesets;
        private System.Windows.Forms.StatusStrip statusStripInformation;
        private System.Windows.Forms.Panel panelTilesetsDrawing;
        private System.Windows.Forms.Button buttonCursor;
        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusToolMode;
        private ElegantUI.Controls.Tabs tabsMaps;
        private System.Windows.Forms.TabPage tabPageEntities;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

