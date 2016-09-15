namespace WorldStamper.Forms.Dialogs
{
    partial class DialogResources
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
            this.listBoxResources = new System.Windows.Forms.ListBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxResources
            // 
            this.listBoxResources.FormattingEnabled = true;
            this.listBoxResources.Location = new System.Drawing.Point(12, 12);
            this.listBoxResources.Name = "listBoxResources";
            this.listBoxResources.Size = new System.Drawing.Size(353, 95);
            this.listBoxResources.TabIndex = 0;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoEllipsis = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 115);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(353, 32);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "<DESCRIPTION>\r\n\r\n\r\n";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(209, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(290, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DialogResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 185);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.listBoxResources);
            this.Name = "DialogResources";
            this.Text = "<TITLE>";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResources;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}