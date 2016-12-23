namespace FinanciA
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelSalary = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFixcosts = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDateTime = new MetroFramework.Controls.MetroLabel();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.tileExplorerToolset = new FinanciA.Controls.TileExplorer();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAllowance = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Monatsgehalt:";
            // 
            // metroLabelSalary
            // 
            this.metroLabelSalary.AutoSize = true;
            this.metroLabelSalary.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelSalary.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelSalary.Location = new System.Drawing.Point(164, 60);
            this.metroLabelSalary.Name = "metroLabelSalary";
            this.metroLabelSalary.Size = new System.Drawing.Size(44, 25);
            this.metroLabelSalary.TabIndex = 1;
            this.metroLabelSalary.Text = "N/A";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(60, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Fixkosten:";
            // 
            // metroLabelFixcosts
            // 
            this.metroLabelFixcosts.AutoSize = true;
            this.metroLabelFixcosts.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelFixcosts.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelFixcosts.Location = new System.Drawing.Point(164, 85);
            this.metroLabelFixcosts.Name = "metroLabelFixcosts";
            this.metroLabelFixcosts.Size = new System.Drawing.Size(44, 25);
            this.metroLabelFixcosts.TabIndex = 3;
            this.metroLabelFixcosts.Text = "N/A";
            // 
            // metroLabelDateTime
            // 
            this.metroLabelDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabelDateTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelDateTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelDateTime.Location = new System.Drawing.Point(20, 250);
            this.metroLabelDateTime.Name = "metroLabelDateTime";
            this.metroLabelDateTime.Size = new System.Drawing.Size(560, 25);
            this.metroLabelDateTime.TabIndex = 4;
            this.metroLabelDateTime.Text = "00.00.2016 00:00:00";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // tileExplorerToolset
            // 
            this.tileExplorerToolset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileExplorerToolset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tileExplorerToolset.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.tileExplorerToolset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tileExplorerToolset.Location = new System.Drawing.Point(20, 275);
            this.tileExplorerToolset.Name = "tileExplorerToolset";
            this.tileExplorerToolset.Size = new System.Drawing.Size(560, 127);
            this.tileExplorerToolset.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(54, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Freibetrag:";
            // 
            // metroLabelAllowance
            // 
            this.metroLabelAllowance.AutoSize = true;
            this.metroLabelAllowance.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAllowance.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelAllowance.Location = new System.Drawing.Point(164, 110);
            this.metroLabelAllowance.Name = "metroLabelAllowance";
            this.metroLabelAllowance.Size = new System.Drawing.Size(44, 25);
            this.metroLabelAllowance.TabIndex = 7;
            this.metroLabelAllowance.Text = "N/A";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 422);
            this.Controls.Add(this.metroLabelAllowance);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabelDateTime);
            this.Controls.Add(this.tileExplorerToolset);
            this.Controls.Add(this.metroLabelFixcosts);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabelSalary);
            this.Controls.Add(this.metroLabel1);
            this.MinimumSize = new System.Drawing.Size(600, 196);
            this.Name = "FormMain";
            this.Text = "FinanciA";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelSalary;
        private Controls.TileExplorer tileExplorerToolset;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabelFixcosts;
        private MetroFramework.Controls.MetroLabel metroLabelDateTime;
        private System.Windows.Forms.Timer timerUpdate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabelAllowance;
    }
}

