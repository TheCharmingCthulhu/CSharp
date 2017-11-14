namespace Designer.Source.Controls
{
    partial class DynamicPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DynamicPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "DynamicPanel";
            this.Size = new System.Drawing.Size(32, 32);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DynamicPanel_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DynamicPanel_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
