﻿namespace _25
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
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.tbReeks = new System.Windows.Forms.TextBox();
            this.tbSom = new System.Windows.Forms.TextBox();
            this.lblReeks = new System.Windows.Forms.Label();
            this.lblSom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(55, 38);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 0;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(55, 12);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 1;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(12, 15);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 2;
            this.lblInvoer.Text = "Invoer";
            // 
            // tbReeks
            // 
            this.tbReeks.Location = new System.Drawing.Point(55, 67);
            this.tbReeks.Name = "tbReeks";
            this.tbReeks.Size = new System.Drawing.Size(248, 20);
            this.tbReeks.TabIndex = 3;
            // 
            // tbSom
            // 
            this.tbSom.Location = new System.Drawing.Point(55, 93);
            this.tbSom.Name = "tbSom";
            this.tbSom.Size = new System.Drawing.Size(100, 20);
            this.tbSom.TabIndex = 4;
            // 
            // lblReeks
            // 
            this.lblReeks.AutoSize = true;
            this.lblReeks.Location = new System.Drawing.Point(12, 70);
            this.lblReeks.Name = "lblReeks";
            this.lblReeks.Size = new System.Drawing.Size(38, 13);
            this.lblReeks.TabIndex = 5;
            this.lblReeks.Text = "Reeks";
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Location = new System.Drawing.Point(22, 96);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(28, 13);
            this.lblSom.TabIndex = 6;
            this.lblSom.Text = "Som";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 130);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.lblReeks);
            this.Controls.Add(this.tbSom);
            this.Controls.Add(this.tbReeks);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbInvoer);
            this.Controls.Add(this.btnAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.TextBox tbReeks;
        private System.Windows.Forms.TextBox tbSom;
        private System.Windows.Forms.Label lblReeks;
        private System.Windows.Forms.Label lblSom;
    }
}

