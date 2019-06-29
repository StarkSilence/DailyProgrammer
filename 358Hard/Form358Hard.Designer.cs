namespace Challenge358Hard
{
    partial class Form358Hard
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
            this.BtnSolve = new System.Windows.Forms.Button();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnSolve
            // 
            this.BtnSolve.Location = new System.Drawing.Point(12, 508);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(94, 27);
            this.BtnSolve.TabIndex = 1;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            this.BtnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // listOutput
            // 
            this.listOutput.AllowDrop = true;
            this.listOutput.FormattingEnabled = true;
            this.listOutput.HorizontalScrollbar = true;
            this.listOutput.Location = new System.Drawing.Point(207, 12);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(485, 485);
            this.listOutput.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(189, 485);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "";
            this.txtInput.WordWrap = false;
            // 
            // Form358Hard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(699, 541);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.BtnSolve);
            this.MaximumSize = new System.Drawing.Size(715, 580);
            this.MinimumSize = new System.Drawing.Size(715, 580);
            this.Name = "Form358Hard";
            this.Text = "Challenge 358 Hard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.RichTextBox txtInput;
    }
}

