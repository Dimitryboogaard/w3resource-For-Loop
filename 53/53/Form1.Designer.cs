﻿namespace _53
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
            this.tbBinair = new System.Windows.Forms.TextBox();
            this.lblBinair = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbOctaal = new System.Windows.Forms.TextBox();
            this.lblOctaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBinair
            // 
            this.tbBinair.Location = new System.Drawing.Point(56, 12);
            this.tbBinair.Name = "tbBinair";
            this.tbBinair.Size = new System.Drawing.Size(100, 20);
            this.tbBinair.TabIndex = 0;
            // 
            // lblBinair
            // 
            this.lblBinair.AutoSize = true;
            this.lblBinair.Location = new System.Drawing.Point(17, 15);
            this.lblBinair.Name = "lblBinair";
            this.lblBinair.Size = new System.Drawing.Size(33, 13);
            this.lblBinair.TabIndex = 1;
            this.lblBinair.Text = "Binair";
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
            // tbOctaal
            // 
            this.tbOctaal.Location = new System.Drawing.Point(56, 67);
            this.tbOctaal.Name = "tbOctaal";
            this.tbOctaal.Size = new System.Drawing.Size(100, 20);
            this.tbOctaal.TabIndex = 3;
            // 
            // lblOctaal
            // 
            this.lblOctaal.AutoSize = true;
            this.lblOctaal.Location = new System.Drawing.Point(12, 70);
            this.lblOctaal.Name = "lblOctaal";
            this.lblOctaal.Size = new System.Drawing.Size(38, 13);
            this.lblOctaal.TabIndex = 4;
            this.lblOctaal.Text = "Octaal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 108);
            this.Controls.Add(this.lblOctaal);
            this.Controls.Add(this.tbOctaal);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblBinair);
            this.Controls.Add(this.tbBinair);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBinair;
        private System.Windows.Forms.Label lblBinair;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbOctaal;
        private System.Windows.Forms.Label lblOctaal;
    }
}

