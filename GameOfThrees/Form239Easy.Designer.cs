namespace Challenge239Easy
{
    partial class Form239Easy
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
            this.listOutput = new System.Windows.Forms.ListBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Control;
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(199, 20);
            this.txtInput.TabIndex = 0;
            // 
            // listOutput
            // 
            this.listOutput.BackColor = System.Drawing.SystemColors.Control;
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(12, 69);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(171, 147);
            this.listOutput.TabIndex = 1;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(12, 39);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(100, 25);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // FrmChallenge239Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(218, 231);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "FrmChallenge239Easy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.Button btnSolve;
    }
}

