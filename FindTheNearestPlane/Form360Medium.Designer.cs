namespace Challenge360Medium
{
    partial class Form360Medium
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
            this.BtnFind = new System.Windows.Forms.Button();
            this.TxtLatitude = new System.Windows.Forms.TextBox();
            this.ListOutput = new System.Windows.Forms.ListBox();
            this.ComboNorthSouth = new System.Windows.Forms.ComboBox();
            this.TxtLongitude = new System.Windows.Forms.TextBox();
            this.ComboEastWest = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(12, 65);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(100, 25);
            this.BtnFind.TabIndex = 0;
            this.BtnFind.Text = "Find Plane";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // TxtLatitude
            // 
            this.TxtLatitude.Location = new System.Drawing.Point(12, 13);
            this.TxtLatitude.Name = "TxtLatitude";
            this.TxtLatitude.Size = new System.Drawing.Size(123, 20);
            this.TxtLatitude.TabIndex = 1;
            this.TxtLatitude.Text = "0";
            // 
            // ListOutput
            // 
            this.ListOutput.FormattingEnabled = true;
            this.ListOutput.Location = new System.Drawing.Point(12, 96);
            this.ListOutput.Name = "ListOutput";
            this.ListOutput.Size = new System.Drawing.Size(164, 95);
            this.ListOutput.TabIndex = 2;
            // 
            // ComboNorthSouth
            // 
            this.ComboNorthSouth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNorthSouth.FormattingEnabled = true;
            this.ComboNorthSouth.Items.AddRange(new object[] {
            "N",
            "S"});
            this.ComboNorthSouth.Location = new System.Drawing.Point(141, 12);
            this.ComboNorthSouth.Name = "ComboNorthSouth";
            this.ComboNorthSouth.Size = new System.Drawing.Size(35, 21);
            this.ComboNorthSouth.TabIndex = 3;
            // 
            // TxtLongitude
            // 
            this.TxtLongitude.Location = new System.Drawing.Point(12, 39);
            this.TxtLongitude.Name = "TxtLongitude";
            this.TxtLongitude.Size = new System.Drawing.Size(123, 20);
            this.TxtLongitude.TabIndex = 4;
            this.TxtLongitude.Text = "0";
            // 
            // ComboEastWest
            // 
            this.ComboEastWest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEastWest.FormattingEnabled = true;
            this.ComboEastWest.Items.AddRange(new object[] {
            "E",
            "W"});
            this.ComboEastWest.Location = new System.Drawing.Point(141, 39);
            this.ComboEastWest.Name = "ComboEastWest";
            this.ComboEastWest.Size = new System.Drawing.Size(35, 21);
            this.ComboEastWest.TabIndex = 5;
            // 
            // Challenge360Medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 206);
            this.Controls.Add(this.ComboEastWest);
            this.Controls.Add(this.TxtLongitude);
            this.Controls.Add(this.ComboNorthSouth);
            this.Controls.Add(this.ListOutput);
            this.Controls.Add(this.TxtLatitude);
            this.Controls.Add(this.BtnFind);
            this.Name = "Challenge360Medium";
            this.Text = "Challenge 360 Medium - Find the Nearest Aeroplane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.TextBox TxtLatitude;
        private System.Windows.Forms.ListBox ListOutput;
        private System.Windows.Forms.ComboBox ComboNorthSouth;
        private System.Windows.Forms.TextBox TxtLongitude;
        private System.Windows.Forms.ComboBox ComboEastWest;
    }
}

