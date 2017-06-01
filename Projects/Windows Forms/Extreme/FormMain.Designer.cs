namespace Extreme
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
            this.extremeGrid1 = new Extreme.ExtremeGrid();
            this.SuspendLayout();
            // 
            // extremeGrid1
            // 
            this.extremeGrid1.GridSize = 32;
            this.extremeGrid1.Location = new System.Drawing.Point(40, 27);
            this.extremeGrid1.Name = "extremeGrid1";
            this.extremeGrid1.Size = new System.Drawing.Size(256, 256);
            this.extremeGrid1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 389);
            this.Controls.Add(this.extremeGrid1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ExtremeGrid extremeGrid1;
    }
}

