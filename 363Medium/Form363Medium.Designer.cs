namespace Challenge363Medium
{
    partial class Form363Medium
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnHyphenate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.BtnHyphenateAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 25);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(187, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnHyphenate
            // 
            this.btnHyphenate.Location = new System.Drawing.Point(12, 51);
            this.btnHyphenate.Name = "btnHyphenate";
            this.btnHyphenate.Size = new System.Drawing.Size(100, 23);
            this.btnHyphenate.TabIndex = 1;
            this.btnHyphenate.Text = "Hyphenate";
            this.btnHyphenate.UseVisualStyleBackColor = true;
            this.btnHyphenate.Click += new System.EventHandler(this.btnHyphenate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 93);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(187, 20);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.WordWrap = false;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(9, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(34, 13);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Input:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(9, 77);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output:";
            // 
            // BtnHyphenateAll
            // 
            this.BtnHyphenateAll.Location = new System.Drawing.Point(118, 51);
            this.BtnHyphenateAll.Name = "BtnHyphenateAll";
            this.BtnHyphenateAll.Size = new System.Drawing.Size(81, 23);
            this.BtnHyphenateAll.TabIndex = 5;
            this.BtnHyphenateAll.Text = "Hyphenate All";
            this.BtnHyphenateAll.UseVisualStyleBackColor = true;
            this.BtnHyphenateAll.Click += new System.EventHandler(this.BtnHyphenateAll_Click);
            // 
            // Challenge363Medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 125);
            this.Controls.Add(this.BtnHyphenateAll);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnHyphenate);
            this.Controls.Add(this.txtInput);
            this.Name = "Challenge363Medium";
            this.Text = "Challenge 363 Medium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnHyphenate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button BtnHyphenateAll;
    }
}

