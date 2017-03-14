namespace Motomatic.Controls.TabPages
{
    partial class EventPageBody
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventPageBody));
            this.flowLayoutPanelEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxEventImage = new System.Windows.Forms.PictureBox();
            this.labelEventInfo = new System.Windows.Forms.Label();
            this.fastColoredTextBoxScript = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.toolStripToolset = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxScript)).BeginInit();
            this.panelImage.SuspendLayout();
            this.toolStripToolset.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelEvents
            // 
            this.flowLayoutPanelEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelEvents.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelEvents.Name = "flowLayoutPanelEvents";
            this.flowLayoutPanelEvents.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanelEvents.Size = new System.Drawing.Size(525, 120);
            this.flowLayoutPanelEvents.TabIndex = 0;
            this.flowLayoutPanelEvents.WrapContents = false;
            // 
            // pictureBoxEventImage
            // 
            this.pictureBoxEventImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxEventImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEventImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxEventImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEventImage.Image")));
            this.pictureBoxEventImage.Location = new System.Drawing.Point(200, 5);
            this.pictureBoxEventImage.Name = "pictureBoxEventImage";
            this.pictureBoxEventImage.Size = new System.Drawing.Size(125, 80);
            this.pictureBoxEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEventImage.TabIndex = 2;
            this.pictureBoxEventImage.TabStop = false;
            // 
            // labelEventInfo
            // 
            this.labelEventInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEventInfo.Location = new System.Drawing.Point(0, 205);
            this.labelEventInfo.Name = "labelEventInfo";
            this.labelEventInfo.Size = new System.Drawing.Size(525, 20);
            this.labelEventInfo.TabIndex = 3;
            this.labelEventInfo.Text = "label1";
            this.labelEventInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.fastColoredTextBoxScript.AutoScrollMinSize = new System.Drawing.Size(211, 14);
            this.fastColoredTextBoxScript.BackBrush = null;
            this.fastColoredTextBoxScript.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fastColoredTextBoxScript.CharHeight = 14;
            this.fastColoredTextBoxScript.CharWidth = 8;
            this.fastColoredTextBoxScript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxScript.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBoxScript.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBoxScript.IsReplaceMode = false;
            this.fastColoredTextBoxScript.Location = new System.Drawing.Point(0, 225);
            this.fastColoredTextBoxScript.Name = "fastColoredTextBoxScript";
            this.fastColoredTextBoxScript.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxScript.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxScript.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxScript.ServiceColors")));
            this.fastColoredTextBoxScript.Size = new System.Drawing.Size(525, 113);
            this.fastColoredTextBoxScript.TabIndex = 4;
            this.fastColoredTextBoxScript.Text = "; Script: \"Unspecified\"";
            this.fastColoredTextBoxScript.Zoom = 100;
            // 
            // panelImage
            // 
            this.panelImage.AutoSize = true;
            this.panelImage.Controls.Add(this.pictureBoxEventImage);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImage.Location = new System.Drawing.Point(0, 120);
            this.panelImage.Name = "panelImage";
            this.panelImage.Padding = new System.Windows.Forms.Padding(200, 5, 200, 0);
            this.panelImage.Size = new System.Drawing.Size(525, 85);
            this.panelImage.TabIndex = 5;
            // 
            // toolStripToolset
            // 
            this.toolStripToolset.CanOverflow = false;
            this.toolStripToolset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripToolset.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripToolset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripToolset.Location = new System.Drawing.Point(0, 338);
            this.toolStripToolset.Name = "toolStripToolset";
            this.toolStripToolset.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripToolset.Size = new System.Drawing.Size(525, 25);
            this.toolStripToolset.TabIndex = 6;
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // EventPageBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fastColoredTextBoxScript);
            this.Controls.Add(this.labelEventInfo);
            this.Controls.Add(this.toolStripToolset);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.flowLayoutPanelEvents);
            this.Name = "EventPageBody";
            this.Size = new System.Drawing.Size(525, 363);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxScript)).EndInit();
            this.panelImage.ResumeLayout(false);
            this.toolStripToolset.ResumeLayout(false);
            this.toolStripToolset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEvents;
        private System.Windows.Forms.PictureBox pictureBoxEventImage;
        private System.Windows.Forms.Label labelEventInfo;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxScript;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.ToolStrip toolStripToolset;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
