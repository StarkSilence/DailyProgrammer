namespace Challenge238Medium
{
    partial class Form238Medium
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
            this.numDifficulty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.listOptions = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // numDifficulty
            // 
            this.numDifficulty.Location = new System.Drawing.Point(15, 25);
            this.numDifficulty.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDifficulty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDifficulty.Name = "numDifficulty";
            this.numDifficulty.Size = new System.Drawing.Size(50, 20);
            this.numDifficulty.TabIndex = 0;
            this.numDifficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Difficulty:";
            // 
            // listOptions
            // 
            this.listOptions.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOptions.FormattingEnabled = true;
            this.listOptions.Location = new System.Drawing.Point(12, 51);
            this.listOptions.Name = "listOptions";
            this.listOptions.Size = new System.Drawing.Size(144, 329);
            this.listOptions.TabIndex = 2;
            this.listOptions.SelectedIndexChanged += new System.EventHandler(this.listOptions_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(68, 19);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 26);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FrmChallenge238Medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 391);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.listOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDifficulty);
            this.Name = "FrmChallenge238Medium";
            this.Text = "Challenge 238 Medium";
            ((System.ComponentModel.ISupportInitialize)(this.numDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listOptions;
        private System.Windows.Forms.Button btnGenerate;
    }
}

