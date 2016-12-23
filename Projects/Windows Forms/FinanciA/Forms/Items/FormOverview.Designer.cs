namespace FinanciA.Forms.Items
{
    partial class FormOverview
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
            this.metroComboBoxTool = new MetroFramework.Controls.MetroComboBox();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.SuspendLayout();
            // 
            // metroComboBoxTool
            // 
            this.metroComboBoxTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroComboBoxTool.FormattingEnabled = true;
            this.metroComboBoxTool.ItemHeight = 23;
            this.metroComboBoxTool.Items.AddRange(new object[] {
            "Monatsübersicht"});
            this.metroComboBoxTool.Location = new System.Drawing.Point(20, 60);
            this.metroComboBoxTool.Name = "metroComboBoxTool";
            this.metroComboBoxTool.Size = new System.Drawing.Size(510, 29);
            this.metroComboBoxTool.TabIndex = 1;
            this.metroComboBoxTool.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxTool_SelectedIndexChanged);
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroScrollBar1.Location = new System.Drawing.Point(517, 100);
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 231);
            this.metroScrollBar1.TabIndex = 2;
            // 
            // FormOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.metroScrollBar1);
            this.Controls.Add(this.metroComboBoxTool);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FormOverview";
            this.Text = "Übersicht";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormOverview_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBoxTool;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
    }
}