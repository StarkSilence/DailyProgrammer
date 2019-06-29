namespace Challenge354Medium
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
            this.btnFindDucciSequence = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFindDucciSequence
            // 
            this.btnFindDucciSequence.Location = new System.Drawing.Point(3, 38);
            this.btnFindDucciSequence.Name = "btnFindDucciSequence";
            this.btnFindDucciSequence.Size = new System.Drawing.Size(146, 24);
            this.btnFindDucciSequence.TabIndex = 0;
            this.btnFindDucciSequence.Text = "Find Ducci Sequence";
            this.btnFindDucciSequence.UseVisualStyleBackColor = true;
            this.btnFindDucciSequence.Click += new System.EventHandler(this.btnFindDucciSequence_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(3, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(146, 20);
            this.txtInput.TabIndex = 1;
            // 
            // listOutput
            // 
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(3, 68);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(146, 173);
            this.listOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 249);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnFindDucciSequence);
            this.Name = "Form1";
            this.Text = "Challenge 364 Medium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDucciSequence;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox listOutput;
    }
}

