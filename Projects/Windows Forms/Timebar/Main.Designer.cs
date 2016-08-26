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
            this.btnAddCard = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uctSample = new Timebar.ucTimebar();
            this.ucInfo = new Timebar.ucCard();
            this.pToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.uctSample.SuspendLayout();
            this.SuspendLayout();
            // 
            // pToolbar
            // 
            this.pToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pToolbar.Controls.Add(this.label2);
            this.pToolbar.Controls.Add(this.textBoxDescription);
            this.pToolbar.Controls.Add(this.label1);
            this.pToolbar.Controls.Add(this.textBoxName);
            this.pToolbar.Controls.Add(this.btnAddCard);
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
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(11, 66);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(75, 23);
            this.btnAddCard.TabIndex = 1;
            this.btnAddCard.Text = "Add Card";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(92, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(145, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(243, 68);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(287, 20);
            this.textBoxDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description:";
            // 
            // uctSample
            // 
            this.uctSample.AutoScroll = true;
            this.uctSample.Controls.Add(this.ucInfo);
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
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
    }
}

