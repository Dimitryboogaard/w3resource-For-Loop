namespace _48
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
            this.tbVan = new System.Windows.Forms.TextBox();
            this.tbTot = new System.Windows.Forms.TextBox();
            this.lblVan = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbReeks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbVan
            // 
            this.tbVan.Location = new System.Drawing.Point(44, 12);
            this.tbVan.Name = "tbVan";
            this.tbVan.Size = new System.Drawing.Size(100, 20);
            this.tbVan.TabIndex = 0;
            // 
            // tbTot
            // 
            this.tbTot.Location = new System.Drawing.Point(44, 38);
            this.tbTot.Name = "tbTot";
            this.tbTot.Size = new System.Drawing.Size(100, 20);
            this.tbTot.TabIndex = 1;
            // 
            // lblVan
            // 
            this.lblVan.AutoSize = true;
            this.lblVan.Location = new System.Drawing.Point(12, 15);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(26, 13);
            this.lblVan.TabIndex = 2;
            this.lblVan.Text = "Van";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(12, 45);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(23, 13);
            this.lblTot.TabIndex = 3;
            this.lblTot.Text = "Tot";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(44, 64);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 4;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbReeks
            // 
            this.tbReeks.Location = new System.Drawing.Point(44, 93);
            this.tbReeks.Name = "tbReeks";
            this.tbReeks.Size = new System.Drawing.Size(256, 20);
            this.tbReeks.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 138);
            this.Controls.Add(this.tbReeks);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblVan);
            this.Controls.Add(this.tbTot);
            this.Controls.Add(this.tbVan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVan;
        private System.Windows.Forms.TextBox tbTot;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbReeks;
    }
}

