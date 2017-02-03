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
            this.groupBoxAuthentication = new System.Windows.Forms.GroupBox();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthorization = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxServers = new System.Windows.Forms.GroupBox();
            this.listViewServers = new System.Windows.Forms.ListView();
            this.columnHeaderServerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderServerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxChannels = new System.Windows.Forms.GroupBox();
            this.tabControlChannels = new System.Windows.Forms.TabControl();
            this.groupBoxAuthentication.SuspendLayout();
            this.groupBoxServers.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBoxChannels.SuspendLayout();
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
            // groupBoxAuthentication
            // 
            this.groupBoxAuthentication.Controls.Add(this.labelConnectionStatus);
            this.groupBoxAuthentication.Controls.Add(this.buttonDisconnect);
            this.groupBoxAuthentication.Controls.Add(this.buttonConnect);
            this.groupBoxAuthentication.Controls.Add(this.label3);
            this.groupBoxAuthentication.Controls.Add(this.textBoxAuthorization);
            this.groupBoxAuthentication.Controls.Add(this.textBoxPassword);
            this.groupBoxAuthentication.Controls.Add(this.label2);
            this.groupBoxAuthentication.Controls.Add(this.label1);
            this.groupBoxAuthentication.Controls.Add(this.textBoxUsername);
            this.groupBoxAuthentication.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAuthentication.Location = new System.Drawing.Point(10, 10);
            this.groupBoxAuthentication.Name = "groupBoxAuthentication";
            this.groupBoxAuthentication.Size = new System.Drawing.Size(645, 100);
            this.groupBoxAuthentication.TabIndex = 2;
            this.groupBoxAuthentication.TabStop = false;
            this.groupBoxAuthentication.Text = "Authentication";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.labelConnectionStatus.Location = new System.Drawing.Point(531, 71);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(108, 18);
            this.labelConnectionStatus.TabIndex = 8;
            this.labelConnectionStatus.Text = "NOT CONNECTED";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Authorization Code:";
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
            this.textBoxAuthorization.Size = new System.Drawing.Size(431, 20);
            this.textBoxAuthorization.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // groupBoxServers
            // 
            this.groupBoxServers.Controls.Add(this.listViewServers);
            this.groupBoxServers.Controls.Add(this.toolStrip1);
            this.groupBoxServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxServers.Enabled = false;
            this.groupBoxServers.Location = new System.Drawing.Point(10, 110);
            this.groupBoxServers.Name = "groupBoxServers";
            this.groupBoxServers.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxServers.Size = new System.Drawing.Size(645, 221);
            this.groupBoxServers.TabIndex = 3;
            this.groupBoxServers.TabStop = false;
            this.groupBoxServers.Text = "Servers";
            // 
            // listViewServers
            // 
            this.listViewServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderServerId,
            this.columnHeaderServerName});
            this.listViewServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewServers.FullRowSelect = true;
            this.listViewServers.HideSelection = false;
            this.listViewServers.Location = new System.Drawing.Point(10, 23);
            this.listViewServers.Name = "listViewServers";
            this.listViewServers.Size = new System.Drawing.Size(625, 163);
            this.listViewServers.TabIndex = 0;
            this.listViewServers.UseCompatibleStateImageBehavior = false;
            this.listViewServers.View = System.Windows.Forms.View.Details;
            this.listViewServers.SelectedIndexChanged += new System.EventHandler(this.listViewServers_SelectedIndexChanged);
            // 
            // columnHeaderServerId
            // 
            this.columnHeaderServerId.Text = "Id";
            this.columnHeaderServerId.Width = 25;
            // 
            // columnHeaderServerName
            // 
            this.columnHeaderServerName.Text = "Name";
            this.columnHeaderServerName.Width = 25;
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
            this.toolStrip1.Size = new System.Drawing.Size(625, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // groupBoxChannels
            // 
            this.groupBoxChannels.Controls.Add(this.tabControlChannels);
            this.groupBoxChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxChannels.Enabled = false;
            this.groupBoxChannels.Location = new System.Drawing.Point(10, 331);
            this.groupBoxChannels.Name = "groupBoxChannels";
            this.groupBoxChannels.Size = new System.Drawing.Size(645, 310);
            this.groupBoxChannels.TabIndex = 2;
            this.groupBoxChannels.TabStop = false;
            this.groupBoxChannels.Text = "Channels";
            // 
            // tabControlChannels
            // 
            this.tabControlChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlChannels.Location = new System.Drawing.Point(3, 16);
            this.tabControlChannels.Name = "tabControlChannels";
            this.tabControlChannels.SelectedIndex = 0;
            this.tabControlChannels.Size = new System.Drawing.Size(639, 291);
            this.tabControlChannels.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(665, 651);
            this.Controls.Add(this.groupBoxChannels);
            this.Controls.Add(this.groupBoxServers);
            this.Controls.Add(this.groupBoxAuthentication);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discardmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBoxAuthentication.ResumeLayout(false);
            this.groupBoxAuthentication.PerformLayout();
            this.groupBoxServers.ResumeLayout(false);
            this.groupBoxServers.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxChannels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAuthentication;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuthorization;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxServers;
        private System.Windows.Forms.ListView listViewServers;
        private System.Windows.Forms.ColumnHeader columnHeaderServerName;
        private System.Windows.Forms.ColumnHeader columnHeaderServerId;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBoxChannels;
        private System.Windows.Forms.TabControl tabControlChannels;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelConnectionStatus;
    }
}

