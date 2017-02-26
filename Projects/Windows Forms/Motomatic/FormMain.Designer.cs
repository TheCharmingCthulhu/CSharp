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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.fastColoredTextBoxScript = new FastColoredTextBoxNS.FastColoredTextBox();
            this.listViewScripts = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxScript)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Location = new System.Drawing.Point(12, 210);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(397, 210);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // fastColoredTextBoxScript
            // 
            this.fastColoredTextBoxScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fastColoredTextBoxScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fastColoredTextBoxScript.CharHeight = 14;
            this.fastColoredTextBoxScript.CharWidth = 8;
            this.fastColoredTextBoxScript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxScript.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxScript.IsReplaceMode = false;
            this.fastColoredTextBoxScript.Location = new System.Drawing.Point(193, 12);
            this.fastColoredTextBoxScript.Name = "fastColoredTextBoxScript";
            this.fastColoredTextBoxScript.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxScript.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxScript.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxScript.ServiceColors")));
            this.fastColoredTextBoxScript.Size = new System.Drawing.Size(279, 192);
            this.fastColoredTextBoxScript.TabIndex = 5;
            this.fastColoredTextBoxScript.Zoom = 100;
            this.fastColoredTextBoxScript.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBoxScript_TextChanged);
            // 
            // listViewScripts
            // 
            this.listViewScripts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewScripts.Location = new System.Drawing.Point(12, 12);
            this.listViewScripts.Name = "listViewScripts";
            this.listViewScripts.Size = new System.Drawing.Size(175, 192);
            this.listViewScripts.TabIndex = 6;
            this.listViewScripts.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 241);
            this.Controls.Add(this.listViewScripts);
            this.Controls.Add(this.fastColoredTextBoxScript);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonLoad);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(500, 280);
            this.Name = "FormMain";
            this.Text = "Motomatic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxScript)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonRun;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxScript;
        private System.Windows.Forms.ListView listViewScripts;
    }
}

