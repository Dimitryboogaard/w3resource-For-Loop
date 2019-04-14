namespace _51
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
            this.tbOctaal = new System.Windows.Forms.TextBox();
            this.lblOctaal = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbDecimaal = new System.Windows.Forms.TextBox();
            this.lblDecimaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbOctaal
            // 
            this.tbOctaal.Location = new System.Drawing.Point(66, 12);
            this.tbOctaal.Name = "tbOctaal";
            this.tbOctaal.Size = new System.Drawing.Size(100, 20);
            this.tbOctaal.TabIndex = 0;
            // 
            // lblOctaal
            // 
            this.lblOctaal.AutoSize = true;
            this.lblOctaal.Location = new System.Drawing.Point(25, 15);
            this.lblOctaal.Name = "lblOctaal";
            this.lblOctaal.Size = new System.Drawing.Size(38, 13);
            this.lblOctaal.TabIndex = 1;
            this.lblOctaal.Text = "Octaal";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(66, 38);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 2;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbDecimaal
            // 
            this.tbDecimaal.Location = new System.Drawing.Point(69, 67);
            this.tbDecimaal.Name = "tbDecimaal";
            this.tbDecimaal.Size = new System.Drawing.Size(100, 20);
            this.tbDecimaal.TabIndex = 3;
            // 
            // lblDecimaal
            // 
            this.lblDecimaal.AutoSize = true;
            this.lblDecimaal.Location = new System.Drawing.Point(12, 70);
            this.lblDecimaal.Name = "lblDecimaal";
            this.lblDecimaal.Size = new System.Drawing.Size(51, 13);
            this.lblDecimaal.TabIndex = 4;
            this.lblDecimaal.Text = "Decimaal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 105);
            this.Controls.Add(this.lblDecimaal);
            this.Controls.Add(this.tbDecimaal);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblOctaal);
            this.Controls.Add(this.tbOctaal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOctaal;
        private System.Windows.Forms.Label lblOctaal;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbDecimaal;
        private System.Windows.Forms.Label lblDecimaal;
    }
}

