﻿namespace Sandbox
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCycles = new System.Windows.Forms.Button();
            this.buttonInterfaces = new System.Windows.Forms.Button();
            this.buttonClock = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonCycles);
            this.flowLayoutPanel1.Controls.Add(this.buttonInterfaces);
            this.flowLayoutPanel1.Controls.Add(this.buttonClock);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(466, 235);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonCycles
            // 
            this.buttonCycles.Location = new System.Drawing.Point(8, 8);
            this.buttonCycles.Name = "buttonCycles";
            this.buttonCycles.Size = new System.Drawing.Size(75, 23);
            this.buttonCycles.TabIndex = 1;
            this.buttonCycles.Text = "Cycles";
            this.buttonCycles.UseVisualStyleBackColor = true;
            this.buttonCycles.Click += new System.EventHandler(this.buttonSequences_Click);
            // 
            // buttonInterfaces
            // 
            this.buttonInterfaces.Location = new System.Drawing.Point(89, 8);
            this.buttonInterfaces.Name = "buttonInterfaces";
            this.buttonInterfaces.Size = new System.Drawing.Size(75, 23);
            this.buttonInterfaces.TabIndex = 1;
            this.buttonInterfaces.Text = "Interfaces";
            this.buttonInterfaces.UseVisualStyleBackColor = true;
            this.buttonInterfaces.Click += new System.EventHandler(this.buttonInterfaces_Click);
            // 
            // buttonClock
            // 
            this.buttonClock.Location = new System.Drawing.Point(170, 8);
            this.buttonClock.Name = "buttonClock";
            this.buttonClock.Size = new System.Drawing.Size(75, 23);
            this.buttonClock.TabIndex = 2;
            this.buttonClock.Text = "Clock";
            this.buttonClock.UseVisualStyleBackColor = true;
            this.buttonClock.Click += new System.EventHandler(this.buttonClock_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 235);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCycles;
        private System.Windows.Forms.Button buttonInterfaces;
        private System.Windows.Forms.Button buttonClock;
    }
}

