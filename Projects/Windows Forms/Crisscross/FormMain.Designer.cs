namespace Crisscross
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.listBoxTerminal = new System.Windows.Forms.ListBox();
            this.textBoxCommandline = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(600, 184);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // listBoxTerminal
            // 
            this.listBoxTerminal.FormattingEnabled = true;
            this.listBoxTerminal.Location = new System.Drawing.Point(299, 12);
            this.listBoxTerminal.Name = "listBoxTerminal";
            this.listBoxTerminal.Size = new System.Drawing.Size(376, 147);
            this.listBoxTerminal.TabIndex = 1;
            // 
            // textBoxCommandline
            // 
            this.textBoxCommandline.Location = new System.Drawing.Point(299, 158);
            this.textBoxCommandline.Name = "textBoxCommandline";
            this.textBoxCommandline.Size = new System.Drawing.Size(376, 20);
            this.textBoxCommandline.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 329);
            this.Controls.Add(this.textBoxCommandline);
            this.Controls.Add(this.listBoxTerminal);
            this.Controls.Add(this.buttonRun);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.ListBox listBoxTerminal;
        private System.Windows.Forms.TextBox textBoxCommandline;
    }
}

