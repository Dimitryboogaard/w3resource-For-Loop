namespace _28
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
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbPerfectNumbers = new System.Windows.Forms.TextBox();
            this.lblPerfecteGetallen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(105, 12);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbGetal1.TabIndex = 0;
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(105, 38);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbGetal2.TabIndex = 1;
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(58, 15);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(41, 13);
            this.lblGetal1.TabIndex = 2;
            this.lblGetal1.Text = "Getal 1";
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(58, 41);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(41, 13);
            this.lblGetal2.TabIndex = 3;
            this.lblGetal2.Text = "Getal 2";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(105, 64);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 4;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbPerfectNumbers
            // 
            this.tbPerfectNumbers.Location = new System.Drawing.Point(105, 93);
            this.tbPerfectNumbers.Name = "tbPerfectNumbers";
            this.tbPerfectNumbers.Size = new System.Drawing.Size(100, 20);
            this.tbPerfectNumbers.TabIndex = 5;
            // 
            // lblPerfecteGetallen
            // 
            this.lblPerfecteGetallen.AutoSize = true;
            this.lblPerfecteGetallen.Location = new System.Drawing.Point(12, 96);
            this.lblPerfecteGetallen.Name = "lblPerfecteGetallen";
            this.lblPerfecteGetallen.Size = new System.Drawing.Size(87, 13);
            this.lblPerfecteGetallen.TabIndex = 6;
            this.lblPerfecteGetallen.Text = "Perfecte getallen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 147);
            this.Controls.Add(this.lblPerfecteGetallen);
            this.Controls.Add(this.tbPerfectNumbers);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.tbGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbPerfectNumbers;
        private System.Windows.Forms.Label lblPerfecteGetallen;
    }
}

