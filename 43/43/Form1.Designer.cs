namespace _43
{
    partial class Form1
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
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbUitkomst = new System.Windows.Forms.TextBox();
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(66, 12);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbGetal1.TabIndex = 0;
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(19, 15);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(41, 13);
            this.lblGetal1.TabIndex = 1;
            this.lblGetal1.Text = "Getal 1";
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(66, 38);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbGetal2.TabIndex = 2;
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(19, 41);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(41, 13);
            this.lblGetal2.TabIndex = 3;
            this.lblGetal2.Text = "Getal 2";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(66, 64);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 4;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbUitkomst
            // 
            this.tbUitkomst.Location = new System.Drawing.Point(66, 90);
            this.tbUitkomst.Name = "tbUitkomst";
            this.tbUitkomst.Size = new System.Drawing.Size(100, 20);
            this.tbUitkomst.TabIndex = 5;
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.AutoSize = true;
            this.lblUitkomst.Location = new System.Drawing.Point(12, 93);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(48, 13);
            this.lblUitkomst.TabIndex = 6;
            this.lblUitkomst.Text = "Uitkomst";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 128);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.tbUitkomst);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Controls.Add(this.tbGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbUitkomst;
        private System.Windows.Forms.Label lblUitkomst;
    }
}

