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
            this.uctSample = new Timebar.ucTimebar();
            this.button42 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.uctSample.SuspendLayout();
            this.SuspendLayout();
            // 
            // uctSample
            // 
            this.uctSample.AutoScroll = true;
            this.uctSample.Controls.Add(this.button42);
            this.uctSample.Controls.Add(this.button1);
            this.uctSample.Controls.Add(this.button2);
            this.uctSample.Controls.Add(this.button3);
            this.uctSample.Controls.Add(this.button4);
            this.uctSample.Controls.Add(this.button5);
            this.uctSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctSample.Location = new System.Drawing.Point(0, 0);
            this.uctSample.Name = "uctSample";
            this.uctSample.Size = new System.Drawing.Size(960, 615);
            this.uctSample.TabIndex = 0;
            this.uctSample.WrapContents = false;
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(3, 3);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(512, 32);
            this.button42.TabIndex = 41;
            this.button42.Text = "button42";
            this.button42.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(512, 32);
            this.button1.TabIndex = 42;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1039, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(512, 32);
            this.button2.TabIndex = 43;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1557, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(512, 32);
            this.button3.TabIndex = 44;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2075, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(512, 32);
            this.button4.TabIndex = 45;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2593, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(512, 32);
            this.button5.TabIndex = 46;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 615);
            this.Controls.Add(this.uctSample);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Text = "Timebar Sample";
            this.ResizeEnd += new System.EventHandler(this.Main_ResizeEnd);
            this.uctSample.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucTimebar uctSample;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

