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
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
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
            // trackBarZoom
            // 
            this.trackBarZoom.AutoSize = false;
            this.trackBarZoom.LargeChange = 32;
            this.trackBarZoom.Location = new System.Drawing.Point(40, 289);
            this.trackBarZoom.Maximum = 256;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(104, 33);
            this.trackBarZoom.SmallChange = 32;
            this.trackBarZoom.TabIndex = 2;
            this.trackBarZoom.TickFrequency = 32;
            this.trackBarZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "16";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarZoom);
            this.Controls.Add(this.extremeGrid1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ExtremeGrid extremeGrid1;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.Label label1;
    }
}

