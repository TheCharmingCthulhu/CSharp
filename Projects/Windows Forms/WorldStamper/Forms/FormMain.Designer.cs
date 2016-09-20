namespace WorldStamper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Spawn", 0);
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxImages = new System.Windows.Forms.ComboBox();
            this.comboBoxTilesets = new System.Windows.Forms.ComboBox();
            this.tabControlToolkits = new System.Windows.Forms.TabControl();
            this.tabPageTilesets = new System.Windows.Forms.TabPage();
            this.imageBoxTiles = new WorldStamperUI.UI.Toolkit.ImageBox();
            this.panelTilesetsDrawing = new System.Windows.Forms.Panel();
            this.buttonPaint = new System.Windows.Forms.Button();
            this.buttonCursor = new System.Windows.Forms.Button();
            this.tabPageEntities = new System.Windows.Forms.TabPage();
            this.tabControlEntitySections = new System.Windows.Forms.TabControl();
            this.tabPageCore = new System.Windows.Forms.TabPage();
            this.listViewCoreEntities = new System.Windows.Forms.ListView();
            this.imageListCoreEntities = new System.Windows.Forms.ImageList(this.components);
            this.tabPageObjects = new System.Windows.Forms.TabPage();
            this.listViewObjects = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.comboBoxTemplates = new System.Windows.Forms.ComboBox();
            this.comboBoxObjects = new System.Windows.Forms.ComboBox();
            this.statusStripInformation = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusToolMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCellX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCellY = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabsMaps = new ElegantUI.Controls.Tabs();
            this.menuBar.SuspendLayout();
            this.tabControlToolkits.SuspendLayout();
            this.tabPageTilesets.SuspendLayout();
            this.panelTilesetsDrawing.SuspendLayout();
            this.tabPageEntities.SuspendLayout();
            this.tabControlEntitySections.SuspendLayout();
            this.tabPageCore.SuspendLayout();
            this.tabPageObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.statusStripInformation.SuspendLayout();
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
            this.toolStripSeparator2,
            this.menuItemLoad,
            this.menuItemSave,
            this.toolStripSeparator3,
            this.menuItemClose,
            this.menuItemCloseAll,
            this.toolStripSeparator1,
            this.propertiesToolStripMenuItem,
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // menuItemLoad
            // 
            this.menuItemLoad.Name = "menuItemLoad";
            this.menuItemLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemLoad.Size = new System.Drawing.Size(143, 22);
            this.menuItemLoad.Text = "Load";
            this.menuItemLoad.Click += new System.EventHandler(this.menuItemLoad_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSave.Size = new System.Drawing.Size(143, 22);
            this.menuItemSave.Text = "Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(140, 6);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(143, 22);
            this.menuItemClose.Text = "Close";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // menuItemCloseAll
            // 
            this.menuItemCloseAll.Name = "menuItemCloseAll";
            this.menuItemCloseAll.Size = new System.Drawing.Size(143, 22);
            this.menuItemCloseAll.Text = "Close All";
            this.menuItemCloseAll.Click += new System.EventHandler(this.menuItemCloseAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
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
            this.tabControlToolkits.SelectedIndexChanged += new System.EventHandler(this.tabControlToolkits_SelectedIndexChanged);
            // 
            // tabPageTilesets
            // 
            this.tabPageTilesets.Controls.Add(this.imageBoxTiles);
            this.tabPageTilesets.Controls.Add(this.panelTilesetsDrawing);
            this.tabPageTilesets.Controls.Add(this.comboBoxTilesets);
            this.tabPageTilesets.Controls.Add(this.comboBoxImages);
            this.tabPageTilesets.Location = new System.Drawing.Point(4, 22);
            this.tabPageTilesets.Name = "tabPageTilesets";
            this.tabPageTilesets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTilesets.Size = new System.Drawing.Size(172, 393);
            this.tabPageTilesets.TabIndex = 0;
            this.tabPageTilesets.Text = "Tilesets";
            this.tabPageTilesets.UseVisualStyleBackColor = true;
            // 
            // imageBoxTiles
            // 
            this.imageBoxTiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxTiles.ImageHeight = 32;
            this.imageBoxTiles.ImageWidth = 32;
            this.imageBoxTiles.Location = new System.Drawing.Point(6, 93);
            this.imageBoxTiles.Name = "imageBoxTiles";
            this.imageBoxTiles.Size = new System.Drawing.Size(160, 294);
            this.imageBoxTiles.TabIndex = 5;
            this.imageBoxTiles.ImageSelected += new WorldStamperUI.UI.Toolkit.ImageBox.ImageBoxHandler(this.imageBoxTiles_ImageSelected);
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
            this.buttonPaint.Enabled = false;
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
            this.buttonCursor.Enabled = false;
            this.buttonCursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCursor.Image = ((System.Drawing.Image)(resources.GetObject("buttonCursor.Image")));
            this.buttonCursor.Location = new System.Drawing.Point(0, 3);
            this.buttonCursor.Name = "buttonCursor";
            this.buttonCursor.Size = new System.Drawing.Size(24, 24);
            this.buttonCursor.TabIndex = 0;
            this.buttonCursor.UseVisualStyleBackColor = true;
            this.buttonCursor.Click += new System.EventHandler(this.buttonCursor_Click);
            // 
            // tabPageEntities
            // 
            this.tabPageEntities.BackColor = System.Drawing.Color.White;
            this.tabPageEntities.Controls.Add(this.tabControlEntitySections);
            this.tabPageEntities.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntities.Name = "tabPageEntities";
            this.tabPageEntities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntities.Size = new System.Drawing.Size(172, 393);
            this.tabPageEntities.TabIndex = 1;
            this.tabPageEntities.Text = "Entities";
            // 
            // tabControlEntitySections
            // 
            this.tabControlEntitySections.Controls.Add(this.tabPageCore);
            this.tabControlEntitySections.Controls.Add(this.tabPageObjects);
            this.tabControlEntitySections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEntitySections.Location = new System.Drawing.Point(3, 3);
            this.tabControlEntitySections.Name = "tabControlEntitySections";
            this.tabControlEntitySections.SelectedIndex = 0;
            this.tabControlEntitySections.Size = new System.Drawing.Size(166, 387);
            this.tabControlEntitySections.TabIndex = 4;
            // 
            // tabPageCore
            // 
            this.tabPageCore.Controls.Add(this.listViewCoreEntities);
            this.tabPageCore.Location = new System.Drawing.Point(4, 22);
            this.tabPageCore.Name = "tabPageCore";
            this.tabPageCore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCore.Size = new System.Drawing.Size(158, 361);
            this.tabPageCore.TabIndex = 1;
            this.tabPageCore.Text = "Core";
            this.tabPageCore.UseVisualStyleBackColor = true;
            // 
            // listViewCoreEntities
            // 
            this.listViewCoreEntities.Enabled = false;
            this.listViewCoreEntities.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewCoreEntities.LargeImageList = this.imageListCoreEntities;
            this.listViewCoreEntities.Location = new System.Drawing.Point(6, 6);
            this.listViewCoreEntities.Name = "listViewCoreEntities";
            this.listViewCoreEntities.Size = new System.Drawing.Size(146, 349);
            this.listViewCoreEntities.TabIndex = 0;
            this.listViewCoreEntities.UseCompatibleStateImageBehavior = false;
            this.listViewCoreEntities.View = System.Windows.Forms.View.Tile;
            this.listViewCoreEntities.SelectedIndexChanged += new System.EventHandler(this.listViewEntities_SelectedIndexChanged);
            // 
            // imageListCoreEntities
            // 
            this.imageListCoreEntities.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCoreEntities.ImageStream")));
            this.imageListCoreEntities.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCoreEntities.Images.SetKeyName(0, "Walking_32px.png");
            // 
            // tabPageObjects
            // 
            this.tabPageObjects.Controls.Add(this.listViewObjects);
            this.tabPageObjects.Controls.Add(this.pictureBoxPreview);
            this.tabPageObjects.Controls.Add(this.comboBoxTemplates);
            this.tabPageObjects.Controls.Add(this.comboBoxObjects);
            this.tabPageObjects.Location = new System.Drawing.Point(4, 22);
            this.tabPageObjects.Name = "tabPageObjects";
            this.tabPageObjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObjects.Size = new System.Drawing.Size(158, 361);
            this.tabPageObjects.TabIndex = 0;
            this.tabPageObjects.Text = "Objects";
            this.tabPageObjects.UseVisualStyleBackColor = true;
            // 
            // listViewObjects
            // 
            this.listViewObjects.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewObjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewObjects.Enabled = false;
            this.listViewObjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewObjects.HideSelection = false;
            this.listViewObjects.Location = new System.Drawing.Point(6, 37);
            this.listViewObjects.MultiSelect = false;
            this.listViewObjects.Name = "listViewObjects";
            this.listViewObjects.ShowGroups = false;
            this.listViewObjects.Size = new System.Drawing.Size(146, 131);
            this.listViewObjects.TabIndex = 0;
            this.listViewObjects.UseCompatibleStateImageBehavior = false;
            this.listViewObjects.View = System.Windows.Forms.View.Tile;
            this.listViewObjects.SelectedIndexChanged += new System.EventHandler(this.listViewObjects_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 140;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Enabled = false;
            this.pictureBoxPreview.Location = new System.Drawing.Point(6, 201);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(146, 154);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 2;
            this.pictureBoxPreview.TabStop = false;
            // 
            // comboBoxTemplates
            // 
            this.comboBoxTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemplates.Enabled = false;
            this.comboBoxTemplates.FormattingEnabled = true;
            this.comboBoxTemplates.Location = new System.Drawing.Point(6, 174);
            this.comboBoxTemplates.Name = "comboBoxTemplates";
            this.comboBoxTemplates.Size = new System.Drawing.Size(146, 21);
            this.comboBoxTemplates.TabIndex = 3;
            this.comboBoxTemplates.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplates_SelectedIndexChanged);
            // 
            // comboBoxObjects
            // 
            this.comboBoxObjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObjects.Enabled = false;
            this.comboBoxObjects.FormattingEnabled = true;
            this.comboBoxObjects.Location = new System.Drawing.Point(6, 10);
            this.comboBoxObjects.Name = "comboBoxObjects";
            this.comboBoxObjects.Size = new System.Drawing.Size(146, 21);
            this.comboBoxObjects.TabIndex = 1;
            this.comboBoxObjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjects_SelectedIndexChanged);
            // 
            // statusStripInformation
            // 
            this.statusStripInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusToolMode,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusCellX,
            this.toolStripStatusLabel4,
            this.toolStripStatusCellY});
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
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel2.Text = " l ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel3.Text = "X:";
            // 
            // toolStripStatusCellX
            // 
            this.toolStripStatusCellX.Name = "toolStripStatusCellX";
            this.toolStripStatusCellX.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusCellX.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel4.Text = "Y:";
            // 
            // toolStripStatusCellY
            // 
            this.toolStripStatusCellY.Name = "toolStripStatusCellY";
            this.toolStripStatusCellY.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusCellY.Text = "0";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(820, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(820, 366);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabsMaps
            // 
            this.tabsMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsMaps.Location = new System.Drawing.Point(0, 24);
            this.tabsMaps.Name = "tabsMaps";
            this.tabsMaps.SelectedIndex = 0;
            this.tabsMaps.Size = new System.Drawing.Size(828, 395);
            this.tabsMaps.TabIndex = 6;
            this.tabsMaps.SelectedIndexChanged += new System.EventHandler(this.tabsMaps_SelectedIndexChanged);
            // 
            // FormMain
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
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.tabControlToolkits.ResumeLayout(false);
            this.tabPageTilesets.ResumeLayout(false);
            this.panelTilesetsDrawing.ResumeLayout(false);
            this.tabPageEntities.ResumeLayout(false);
            this.tabControlEntitySections.ResumeLayout(false);
            this.tabPageCore.ResumeLayout(false);
            this.tabPageObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.statusStripInformation.ResumeLayout(false);
            this.statusStripInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoad;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
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
        private System.Windows.Forms.TabPage tabPageEntities;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemCloseAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemClose;
        private System.Windows.Forms.ListView listViewObjects;
        private System.Windows.Forms.ComboBox comboBoxObjects;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.ComboBox comboBoxTemplates;
        private System.Windows.Forms.TabControl tabControlEntitySections;
        private System.Windows.Forms.TabPage tabPageObjects;
        private System.Windows.Forms.TabPage tabPageCore;
        private System.Windows.Forms.ListView listViewCoreEntities;
        private System.Windows.Forms.ImageList imageListCoreEntities;
        private WorldStamperUI.UI.Toolkit.ImageBox imageBoxTiles;
        private ElegantUI.Controls.Tabs tabsMaps;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCellX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCellY;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

