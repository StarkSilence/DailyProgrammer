namespace Challenge356Medium
{
    partial class Form356Medium
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
            this.BtnFindSum = new System.Windows.Forms.Button();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.numericInput = new System.Windows.Forms.NumericUpDown();
            this.BtnFindPrimes = new System.Windows.Forms.Button();
            this.listPrimes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFindSum
            // 
            this.BtnFindSum.Location = new System.Drawing.Point(12, 38);
            this.BtnFindSum.Name = "BtnFindSum";
            this.BtnFindSum.Size = new System.Drawing.Size(106, 24);
            this.BtnFindSum.TabIndex = 1;
            this.BtnFindSum.Text = "Find Summands";
            this.BtnFindSum.UseVisualStyleBackColor = true;
            this.BtnFindSum.Click += new System.EventHandler(this.BtnFindSum_Click);
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(12, 68);
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ReadOnly = true;
            this.TxtOutput.Size = new System.Drawing.Size(230, 20);
            this.TxtOutput.TabIndex = 2;
            // 
            // numericInput
            // 
            this.numericInput.Location = new System.Drawing.Point(12, 12);
            this.numericInput.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericInput.Name = "numericInput";
            this.numericInput.Size = new System.Drawing.Size(230, 20);
            this.numericInput.TabIndex = 4;
            this.numericInput.ThousandsSeparator = true;
            // 
            // BtnFindPrimes
            // 
            this.BtnFindPrimes.Location = new System.Drawing.Point(141, 38);
            this.BtnFindPrimes.Name = "BtnFindPrimes";
            this.BtnFindPrimes.Size = new System.Drawing.Size(101, 24);
            this.BtnFindPrimes.TabIndex = 5;
            this.BtnFindPrimes.Text = "Find Primes";
            this.BtnFindPrimes.UseVisualStyleBackColor = true;
            this.BtnFindPrimes.Click += new System.EventHandler(this.BtnFindPrimes_Click);
            // 
            // listPrimes
            // 
            this.listPrimes.FormattingEnabled = true;
            this.listPrimes.Location = new System.Drawing.Point(12, 94);
            this.listPrimes.Name = "listPrimes";
            this.listPrimes.ScrollAlwaysVisible = true;
            this.listPrimes.Size = new System.Drawing.Size(230, 160);
            this.listPrimes.TabIndex = 6;
            // 
            // Challenge356Medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.listPrimes);
            this.Controls.Add(this.BtnFindPrimes);
            this.Controls.Add(this.numericInput);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.BtnFindSum);
            this.Name = "Challenge356Medium";
            this.Text = "Challenge 356 Medium";
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnFindSum;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.NumericUpDown numericInput;
        private System.Windows.Forms.Button BtnFindPrimes;
        private System.Windows.Forms.ListBox listPrimes;
    }
}

