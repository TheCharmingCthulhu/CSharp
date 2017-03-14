namespace Motomatic.Forms
{
    partial class FormEventEditor
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
            this.labelEventName = new System.Windows.Forms.Label();
            this.propertyGridProperties = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // labelEventName
            // 
            this.labelEventName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEventName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventName.Location = new System.Drawing.Point(0, 0);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(304, 28);
            this.labelEventName.TabIndex = 0;
            this.labelEventName.Text = "N / A";
            this.labelEventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // propertyGridProperties
            // 
            this.propertyGridProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridProperties.Location = new System.Drawing.Point(0, 28);
            this.propertyGridProperties.Name = "propertyGridProperties";
            this.propertyGridProperties.Size = new System.Drawing.Size(304, 433);
            this.propertyGridProperties.TabIndex = 1;
            // 
            // FormEventEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 461);
            this.Controls.Add(this.propertyGridProperties);
            this.Controls.Add(this.labelEventName);
            this.Name = "FormEventEditor";
            this.Text = "Event Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.PropertyGrid propertyGridProperties;
    }
}