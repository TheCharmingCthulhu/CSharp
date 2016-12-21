namespace FinanciA.Forms.Fixcosts
{
    partial class FormItemFixcost
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
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.metroLabelPrice = new MetroFramework.Controls.MetroLabel();
            this.metroButtonOk = new MetroFramework.Controls.MetroButton();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImage.Location = new System.Drawing.Point(224, 106);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // metroLabelPrice
            // 
            this.metroLabelPrice.AutoSize = true;
            this.metroLabelPrice.Location = new System.Drawing.Point(73, 151);
            this.metroLabelPrice.Name = "metroLabelPrice";
            this.metroLabelPrice.Size = new System.Drawing.Size(40, 19);
            this.metroLabelPrice.TabIndex = 3;
            this.metroLabelPrice.Text = "Preis:";
            // 
            // metroButtonOk
            // 
            this.metroButtonOk.Location = new System.Drawing.Point(23, 176);
            this.metroButtonOk.Name = "metroButtonOk";
            this.metroButtonOk.Size = new System.Drawing.Size(265, 23);
            this.metroButtonOk.TabIndex = 4;
            this.metroButtonOk.Text = "OK";
            this.metroButtonOk.Click += new System.EventHandler(this.metroButtonOk_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(116, 87);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 59);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            this.textBoxDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFixcostItem_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Beschreibung:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(65, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(118, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(169, 16);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFixcostItem_KeyDown);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(116, 153);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(102, 16);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFixcostItem_KeyDown);
            // 
            // FormItemFixcost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(304, 222);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.metroButtonOk);
            this.Controls.Add(this.metroLabelPrice);
            this.Controls.Add(this.pictureBoxImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormItemFixcost";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "N/A";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFixcostItem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private MetroFramework.Controls.MetroLabel metroLabelPrice;
        private MetroFramework.Controls.MetroButton metroButtonOk;
        private System.Windows.Forms.TextBox textBoxDescription;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}