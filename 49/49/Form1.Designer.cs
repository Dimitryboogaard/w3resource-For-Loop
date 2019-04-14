namespace _49
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
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbAantal = new System.Windows.Forms.TextBox();
            this.tbVerschil = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbSom = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.lblVerschil = new System.Windows.Forms.Label();
            this.lblSom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(62, 12);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(100, 20);
            this.tbStart.TabIndex = 0;
            // 
            // tbAantal
            // 
            this.tbAantal.Location = new System.Drawing.Point(62, 38);
            this.tbAantal.Name = "tbAantal";
            this.tbAantal.Size = new System.Drawing.Size(100, 20);
            this.tbAantal.TabIndex = 1;
            // 
            // tbVerschil
            // 
            this.tbVerschil.Location = new System.Drawing.Point(62, 64);
            this.tbVerschil.Name = "tbVerschil";
            this.tbVerschil.Size = new System.Drawing.Size(100, 20);
            this.tbVerschil.TabIndex = 2;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(62, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 3;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbSom
            // 
            this.tbSom.Location = new System.Drawing.Point(62, 119);
            this.tbSom.Name = "tbSom";
            this.tbSom.Size = new System.Drawing.Size(100, 20);
            this.tbSom.TabIndex = 4;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(27, 12);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(19, 41);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(37, 13);
            this.lblAantal.TabIndex = 6;
            this.lblAantal.Text = "Aantal";
            // 
            // lblVerschil
            // 
            this.lblVerschil.AutoSize = true;
            this.lblVerschil.Location = new System.Drawing.Point(12, 64);
            this.lblVerschil.Name = "lblVerschil";
            this.lblVerschil.Size = new System.Drawing.Size(44, 13);
            this.lblVerschil.TabIndex = 7;
            this.lblVerschil.Text = "Verschil";
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Location = new System.Drawing.Point(27, 122);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(28, 13);
            this.lblSom.TabIndex = 8;
            this.lblSom.Text = "Som";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 157);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.lblVerschil);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.tbSom);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbVerschil);
            this.Controls.Add(this.tbAantal);
            this.Controls.Add(this.tbStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbAantal;
        private System.Windows.Forms.TextBox tbVerschil;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbSom;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Label lblVerschil;
        private System.Windows.Forms.Label lblSom;
    }
}

