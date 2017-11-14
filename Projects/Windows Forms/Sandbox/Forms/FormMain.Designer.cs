namespace Sandbox
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
            this.buttonLerp = new System.Windows.Forms.Button();
            this.btnStackoverflow = new System.Windows.Forms.Button();
            this.buttonCasting = new System.Windows.Forms.Button();
            this.buttonValueConversion = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.buttonFixedListbox = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonCycles);
            this.flowLayoutPanel1.Controls.Add(this.buttonInterfaces);
            this.flowLayoutPanel1.Controls.Add(this.buttonClock);
            this.flowLayoutPanel1.Controls.Add(this.buttonLerp);
            this.flowLayoutPanel1.Controls.Add(this.btnStackoverflow);
            this.flowLayoutPanel1.Controls.Add(this.buttonCasting);
            this.flowLayoutPanel1.Controls.Add(this.buttonValueConversion);
            this.flowLayoutPanel1.Controls.Add(this.buttonAction);
            this.flowLayoutPanel1.Controls.Add(this.buttonFixedListbox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(466, 217);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonCycles
            // 
            this.buttonCycles.Location = new System.Drawing.Point(8, 8);
            this.buttonCycles.Name = "buttonCycles";
            this.buttonCycles.Size = new System.Drawing.Size(75, 21);
            this.buttonCycles.TabIndex = 1;
            this.buttonCycles.Text = "Cycles";
            this.buttonCycles.UseVisualStyleBackColor = true;
            this.buttonCycles.Click += new System.EventHandler(this.buttonSequences_Click);
            // 
            // buttonInterfaces
            // 
            this.buttonInterfaces.Location = new System.Drawing.Point(89, 8);
            this.buttonInterfaces.Name = "buttonInterfaces";
            this.buttonInterfaces.Size = new System.Drawing.Size(75, 21);
            this.buttonInterfaces.TabIndex = 1;
            this.buttonInterfaces.Text = "Interfaces";
            this.buttonInterfaces.UseVisualStyleBackColor = true;
            this.buttonInterfaces.Click += new System.EventHandler(this.buttonInterfaces_Click);
            // 
            // buttonClock
            // 
            this.buttonClock.Location = new System.Drawing.Point(170, 8);
            this.buttonClock.Name = "buttonClock";
            this.buttonClock.Size = new System.Drawing.Size(75, 21);
            this.buttonClock.TabIndex = 2;
            this.buttonClock.Text = "Clock";
            this.buttonClock.UseVisualStyleBackColor = true;
            this.buttonClock.Click += new System.EventHandler(this.buttonClock_Click);
            // 
            // buttonLerp
            // 
            this.buttonLerp.Location = new System.Drawing.Point(251, 8);
            this.buttonLerp.Name = "buttonLerp";
            this.buttonLerp.Size = new System.Drawing.Size(75, 21);
            this.buttonLerp.TabIndex = 3;
            this.buttonLerp.Text = "Lerp";
            this.buttonLerp.UseVisualStyleBackColor = true;
            this.buttonLerp.Click += new System.EventHandler(this.buttonLerp_Click);
            // 
            // btnStackoverflow
            // 
            this.btnStackoverflow.Location = new System.Drawing.Point(332, 8);
            this.btnStackoverflow.Name = "btnStackoverflow";
            this.btnStackoverflow.Size = new System.Drawing.Size(88, 21);
            this.btnStackoverflow.TabIndex = 1;
            this.btnStackoverflow.Text = "Stackoverflow";
            this.btnStackoverflow.UseVisualStyleBackColor = true;
            this.btnStackoverflow.Click += new System.EventHandler(this.btnStackoverflow_Click);
            // 
            // buttonCasting
            // 
            this.buttonCasting.Location = new System.Drawing.Point(8, 35);
            this.buttonCasting.Name = "buttonCasting";
            this.buttonCasting.Size = new System.Drawing.Size(75, 21);
            this.buttonCasting.TabIndex = 4;
            this.buttonCasting.Text = "Casting";
            this.buttonCasting.UseVisualStyleBackColor = true;
            this.buttonCasting.Click += new System.EventHandler(this.buttonCasting_Click);
            // 
            // buttonValueConversion
            // 
            this.buttonValueConversion.Location = new System.Drawing.Point(89, 35);
            this.buttonValueConversion.Name = "buttonValueConversion";
            this.buttonValueConversion.Size = new System.Drawing.Size(75, 21);
            this.buttonValueConversion.TabIndex = 5;
            this.buttonValueConversion.Text = "ValueConversion";
            this.buttonValueConversion.UseVisualStyleBackColor = true;
            this.buttonValueConversion.Click += new System.EventHandler(this.buttonValueConversion_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(170, 35);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(75, 21);
            this.buttonAction.TabIndex = 6;
            this.buttonAction.Text = "Actions";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonFixedListbox
            // 
            this.buttonFixedListbox.Location = new System.Drawing.Point(251, 35);
            this.buttonFixedListbox.Name = "buttonFixedListbox";
            this.buttonFixedListbox.Size = new System.Drawing.Size(75, 21);
            this.buttonFixedListbox.TabIndex = 7;
            this.buttonFixedListbox.Text = "Fixed Listbox";
            this.buttonFixedListbox.UseVisualStyleBackColor = true;
            this.buttonFixedListbox.Click += new System.EventHandler(this.buttonFixedListbox_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 217);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Button buttonLerp;
        private System.Windows.Forms.Button btnStackoverflow;
        private System.Windows.Forms.Button buttonCasting;
        private System.Windows.Forms.Button buttonValueConversion;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Button buttonFixedListbox;
    }
}

