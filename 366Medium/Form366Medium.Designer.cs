namespace Challenge366Medium
{
    partial class Form366Medium
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
            this.btnFindFunnel = new System.Windows.Forms.Button();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.btnFindLongestFunnel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(152, 20);
            this.txtInput.TabIndex = 2;
            // 
            // btnFindFunnel
            // 
            this.btnFindFunnel.Location = new System.Drawing.Point(12, 38);
            this.btnFindFunnel.Name = "btnFindFunnel";
            this.btnFindFunnel.Size = new System.Drawing.Size(152, 23);
            this.btnFindFunnel.TabIndex = 3;
            this.btnFindFunnel.Text = "Funnel";
            this.btnFindFunnel.UseVisualStyleBackColor = true;
            this.btnFindFunnel.Click += new System.EventHandler(this.btnFindFunnel_Click);
            // 
            // listOutput
            // 
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(12, 67);
            this.listOutput.Name = "listOutput";
            this.listOutput.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listOutput.Size = new System.Drawing.Size(152, 212);
            this.listOutput.TabIndex = 4;
            // 
            // btnFindLongestFunnel
            // 
            this.btnFindLongestFunnel.Location = new System.Drawing.Point(12, 285);
            this.btnFindLongestFunnel.Name = "btnFindLongestFunnel";
            this.btnFindLongestFunnel.Size = new System.Drawing.Size(152, 23);
            this.btnFindLongestFunnel.TabIndex = 5;
            this.btnFindLongestFunnel.Text = "Find Longest Funnel";
            this.btnFindLongestFunnel.UseVisualStyleBackColor = true;
            this.btnFindLongestFunnel.Click += new System.EventHandler(this.btnFindLongestFunnel_Click);
            // 
            // Challenge366Medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 322);
            this.Controls.Add(this.btnFindLongestFunnel);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.btnFindFunnel);
            this.Controls.Add(this.txtInput);
            this.Name = "Challenge366Medium";
            this.Text = "Challenge 366 Medium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnFindFunnel;
        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.Button btnFindLongestFunnel;
    }
}

