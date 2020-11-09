using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Challenge239Easy
{
    public partial class Form239Easy : Form
    {
        public Form239Easy()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            listOutput.Items.Clear();
            
            Int32.TryParse(txtInput.Text, out int input);
            if (input == 0)
            {                
                listOutput.Items.Add("Input must be a number.");
            }

            while (input != 1)
            {
                int remainder = input % 3;

                if (remainder == 0)
                {
                    listOutput.Items.Add(input + " 0");
                    input = input / 3;
                }
                else if (remainder == 1)
                {
                    listOutput.Items.Add(input + " -1");
                    input = (input - 1) / 3;
                }
                else if (remainder == 2)
                {
                    listOutput.Items.Add(input + " +1");
                    input = (input + 1) / 3;
                }
            }

            listOutput.Items.Add(input);
        }
    }
}
