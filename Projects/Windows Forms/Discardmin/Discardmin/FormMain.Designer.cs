namespace Discardmin
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxAuthorization = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBoxChannels = new System.Windows.Forms.GroupBox();
            this.listViewServers = new System.Windows.Forms.ListView();
            this.columnHeaderServerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderServerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBoxAdministration = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxChannels.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBoxAdministration.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(9, 32);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(189, 20);
            this.textBoxUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelConnectionStatus);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxAuthorization);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(9, 71);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(189, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxAuthorization
            // 
            this.textBoxAuthorization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthorization.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxAuthorization.Enabled = false;
            this.textBoxAuthorization.Location = new System.Drawing.Point(204, 32);
            this.textBoxAuthorization.Name = "textBoxAuthorization";
            this.textBoxAuthorization.ReadOnly = true;
            this.textBoxAuthorization.Size = new System.Drawing.Size(397, 20);
            this.textBoxAuthorization.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Authorization Code:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(204, 69);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Login";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBoxChannels
            // 
            this.groupBoxChannels.Controls.Add(this.listViewServers);
            this.groupBoxChannels.Controls.Add(this.toolStrip1);
            this.groupBoxChannels.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxChannels.Enabled = false;
            this.groupBoxChannels.Location = new System.Drawing.Point(10, 110);
            this.groupBoxChannels.Name = "groupBoxChannels";
            this.groupBoxChannels.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxChannels.Size = new System.Drawing.Size(611, 221);
            this.groupBoxChannels.TabIndex = 3;
            this.groupBoxChannels.TabStop = false;
            this.groupBoxChannels.Text = "Servers";
            // 
            // listViewServers
            // 
            this.listViewServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderServerName,
            this.columnHeaderServerId});
            this.listViewServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewServers.Location = new System.Drawing.Point(10, 23);
            this.listViewServers.Name = "listViewServers";
            this.listViewServers.Size = new System.Drawing.Size(591, 163);
            this.listViewServers.TabIndex = 0;
            this.listViewServers.UseCompatibleStateImageBehavior = false;
            this.listViewServers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderServerName
            // 
            this.columnHeaderServerName.DisplayIndex = 1;
            this.columnHeaderServerName.Text = "Name";
            this.columnHeaderServerName.Width = 25;
            // 
            // columnHeaderServerId
            // 
            this.columnHeaderServerId.DisplayIndex = 0;
            this.columnHeaderServerId.Text = "Id";
            this.columnHeaderServerId.Width = 25;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(10, 186);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(591, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBoxAdministration
            // 
            this.groupBoxAdministration.Controls.Add(this.tabControl1);
            this.groupBoxAdministration.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAdministration.Enabled = false;
            this.groupBoxAdministration.Location = new System.Drawing.Point(10, 331);
            this.groupBoxAdministration.Name = "groupBoxAdministration";
            this.groupBoxAdministration.Size = new System.Drawing.Size(611, 162);
            this.groupBoxAdministration.TabIndex = 2;
            this.groupBoxAdministration.TabStop = false;
            this.groupBoxAdministration.Text = "Administration";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 143);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 117);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(285, 69);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 7;
            this.buttonDisconnect.Text = "Logout";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.labelConnectionStatus.Location = new System.Drawing.Point(497, 71);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(108, 18);
            this.labelConnectionStatus.TabIndex = 8;
            this.labelConnectionStatus.Text = "NOT CONNECTED";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(648, 401);
            this.Controls.Add(this.groupBoxAdministration);
            this.Controls.Add(this.groupBoxChannels);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Discardmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxChannels.ResumeLayout(false);
            this.groupBoxChannels.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxAdministration.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuthorization;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxChannels;
        private System.Windows.Forms.ListView listViewServers;
        private System.Windows.Forms.ColumnHeader columnHeaderServerName;
        private System.Windows.Forms.ColumnHeader columnHeaderServerId;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBoxAdministration;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelConnectionStatus;
    }
}

