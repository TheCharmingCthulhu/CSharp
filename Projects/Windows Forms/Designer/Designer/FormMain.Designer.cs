namespace Designer
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
            this.dynamicPanel1 = new Designer.Source.Controls.DynamicPanel();
            this.SuspendLayout();
            // 
            // dynamicPanel1
            // 
            this.dynamicPanel1.Location = new System.Drawing.Point(352, 12);
            this.dynamicPanel1.Name = "dynamicPanel1";
            this.dynamicPanel1.Size = new System.Drawing.Size(32, 32);
            this.dynamicPanel1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 332);
            this.Controls.Add(this.dynamicPanel1);
            this.Name = "FormMain";
            this.Text = "Designer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Source.Controls.DynamicPanel dynamicPanel1;
    }
}

