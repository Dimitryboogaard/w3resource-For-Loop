namespace _26
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
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbReeks = new System.Windows.Forms.TextBox();
            this.lblReeks = new System.Windows.Forms.Label();
            this.tbSom = new System.Windows.Forms.TextBox();
            this.lblSom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(56, 12);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(13, 15);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 1;
            this.lblInvoer.Text = "Invoer";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(56, 38);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 2;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbReeks
            // 
            this.tbReeks.Location = new System.Drawing.Point(56, 64);
            this.tbReeks.Name = "tbReeks";
            this.tbReeks.Size = new System.Drawing.Size(353, 20);
            this.tbReeks.TabIndex = 3;
            // 
            // lblReeks
            // 
            this.lblReeks.AutoSize = true;
            this.lblReeks.Location = new System.Drawing.Point(12, 67);
            this.lblReeks.Name = "lblReeks";
            this.lblReeks.Size = new System.Drawing.Size(38, 13);
            this.lblReeks.TabIndex = 4;
            this.lblReeks.Text = "Reeks";
            // 
            // tbSom
            // 
            this.tbSom.Location = new System.Drawing.Point(56, 90);
            this.tbSom.Name = "tbSom";
            this.tbSom.Size = new System.Drawing.Size(100, 20);
            this.tbSom.TabIndex = 5;
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Location = new System.Drawing.Point(22, 93);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(28, 13);
            this.lblSom.TabIndex = 6;
            this.lblSom.Text = "Som";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 128);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.tbSom);
            this.Controls.Add(this.lblReeks);
            this.Controls.Add(this.tbReeks);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbReeks;
        private System.Windows.Forms.Label lblReeks;
        private System.Windows.Forms.TextBox tbSom;
        private System.Windows.Forms.Label lblSom;
    }
}

