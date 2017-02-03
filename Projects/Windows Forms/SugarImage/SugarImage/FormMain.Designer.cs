namespace SugarImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.toolStripToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxWidth = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxHeight = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxText = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.toolStripToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(494, 243);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // toolStripToolbar
            // 
            this.toolStripToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxWidth,
            this.toolStripLabel2,
            this.toolStripTextBoxHeight,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripButtonExport,
            this.toolStripLabel3,
            this.toolStripTextBoxText});
            this.toolStripToolbar.Location = new System.Drawing.Point(0, 243);
            this.toolStripToolbar.Name = "toolStripToolbar";
            this.toolStripToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripToolbar.Size = new System.Drawing.Size(494, 25);
            this.toolStripToolbar.Stretch = true;
            this.toolStripToolbar.TabIndex = 1;
            this.toolStripToolbar.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Width:";
            // 
            // toolStripTextBoxWidth
            // 
            this.toolStripTextBoxWidth.Items.AddRange(new object[] {
            "320",
            "352",
            "480",
            "640",
            "768",
            "800",
            "1024",
            "1152",
            "1280",
            "1360",
            "1366",
            "1440",
            "1600",
            "1680",
            "1920"});
            this.toolStripTextBoxWidth.Name = "toolStripTextBoxWidth";
            this.toolStripTextBoxWidth.Size = new System.Drawing.Size(75, 25);
            this.toolStripTextBoxWidth.Text = "1024";
            this.toolStripTextBoxWidth.Leave += new System.EventHandler(this.toolStripTextBox_Leave);
            this.toolStripTextBoxWidth.TextChanged += new System.EventHandler(this.toolStripTextBox_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel2.Text = "Height:";
            // 
            // toolStripTextBoxHeight
            // 
            this.toolStripTextBoxHeight.Items.AddRange(new object[] {
            "240",
            "480",
            "576",
            "600",
            "768",
            "864",
            "720",
            "768",
            "800",
            "1024",
            "1050",
            "1080"});
            this.toolStripTextBoxHeight.Name = "toolStripTextBoxHeight";
            this.toolStripTextBoxHeight.Size = new System.Drawing.Size(75, 25);
            this.toolStripTextBoxHeight.Text = "768";
            this.toolStripTextBoxHeight.Leave += new System.EventHandler(this.toolStripTextBox_Leave);
            this.toolStripTextBoxHeight.TextChanged += new System.EventHandler(this.toolStripTextBox_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.foregroundToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // foregroundToolStripMenuItem
            // 
            this.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem";
            this.foregroundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.foregroundToolStripMenuItem.Text = "Foreground";
            this.foregroundToolStripMenuItem.Click += new System.EventHandler(this.foregroundToolStripMenuItem_Click);
            // 
            // toolStripButtonExport
            // 
            this.toolStripButtonExport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExport.Image")));
            this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExport.Name = "toolStripButtonExport";
            this.toolStripButtonExport.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExport.Text = "toolStripButton1";
            this.toolStripButtonExport.Click += new System.EventHandler(this.toolStripButtonExport_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel3.Text = "Text:";
            // 
            // toolStripTextBoxText
            // 
            this.toolStripTextBoxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxText.Name = "toolStripTextBoxText";
            this.toolStripTextBoxText.Size = new System.Drawing.Size(140, 16);
            this.toolStripTextBoxText.Text = "Template I";
            this.toolStripTextBoxText.Leave += new System.EventHandler(this.toolStripTextBox_Leave);
            this.toolStripTextBoxText.TextChanged += new System.EventHandler(this.toolStripTextBox_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 268);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.toolStripToolbar);
            this.Name = "FormMain";
            this.Text = "SugarImage";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.toolStripToolbar.ResumeLayout(false);
            this.toolStripToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.ToolStrip toolStripToolbar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxText;
        private System.Windows.Forms.ToolStripButton toolStripButtonExport;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foregroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripTextBoxWidth;
        private System.Windows.Forms.ToolStripComboBox toolStripTextBoxHeight;
    }
}

