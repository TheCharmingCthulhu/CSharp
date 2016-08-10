namespace Timebar
{
    partial class Main
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
            this.pToolbar = new System.Windows.Forms.Panel();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.uctSample = new Timebar.ucTimebar();
            this.ucInfo = new Timebar.ucCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.uctSample.SuspendLayout();
            this.SuspendLayout();
            // 
            // pToolbar
            // 
            this.pToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pToolbar.Controls.Add(this.trackBarScale);
            this.pToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pToolbar.Location = new System.Drawing.Point(0, 0);
            this.pToolbar.Name = "pToolbar";
            this.pToolbar.Size = new System.Drawing.Size(1000, 96);
            this.pToolbar.TabIndex = 0;
            // 
            // trackBarScale
            // 
            this.trackBarScale.Location = new System.Drawing.Point(-1, -1);
            this.trackBarScale.Maximum = 8;
            this.trackBarScale.Minimum = 1;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(136, 45);
            this.trackBarScale.TabIndex = 0;
            this.trackBarScale.Value = 1;
            this.trackBarScale.ValueChanged += new System.EventHandler(this.trackBarScale_ValueChanged);
            // 
            // uctSample
            // 
            this.uctSample.AutoScroll = true;
            this.uctSample.Controls.Add(this.ucInfo);
            this.uctSample.Controls.Add(this.panel1);
            this.uctSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctSample.Location = new System.Drawing.Point(0, 96);
            this.uctSample.Name = "uctSample";
            this.uctSample.Size = new System.Drawing.Size(1000, 519);
            this.uctSample.TabIndex = 0;
            this.uctSample.WrapContents = false;
            // 
            // ucInfo
            // 
            this.ucInfo.Caption = "Trigger Finger";
            this.ucInfo.Description = null;
            this.ucInfo.Location = new System.Drawing.Point(3, 3);
            this.ucInfo.Name = "ucInfo";
            this.ucInfo.Size = new System.Drawing.Size(200, 100);
            this.ucInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(209, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 100);
            this.panel1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 615);
            this.Controls.Add(this.uctSample);
            this.Controls.Add(this.pToolbar);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Text = "Timebar Sample";
            this.ResizeEnd += new System.EventHandler(this.Main_ResizeEnd);
            this.pToolbar.ResumeLayout(false);
            this.pToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.uctSample.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucTimebar uctSample;
        private System.Windows.Forms.Panel pToolbar;
        private System.Windows.Forms.TrackBar trackBarScale;
        private ucCard ucInfo;
        private System.Windows.Forms.Panel panel1;
    }
}

