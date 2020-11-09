using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Challenge356Medium
{
    public partial class Form356Medium : Form
    {
        public Form356Medium()
        {
            InitializeComponent();
        }

        private void BtnFindSum_Click(object sender, EventArgs e)
        {
            int input = (int)numericInput.Value;

            if (input % 2 == 0)
            {
                TxtOutput.Text = "Input must be odd.";
            }
            else
            {
                IList<int> primes = new List<int>();

                for (int i = 2; i < input; i++)
                {
                    bool prime = true;

                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime)
                    {
                        primes.Add(i);
                    }
                }

                bool foundSummands = false;
                int summandOne = 0;
                int summandTwo = 0;
                int summandThree = 0;

                for (int i = primes.Count - 1; i >= 0; i--)
                {
                    summandOne = primes[i];

                    for (int j = 0; j <= primes.Count - 1; j++)
                    {
                        summandTwo = primes[j];

                        for (int k = 0; k <= primes.Count - 1; k++)
                        {
                            summandThree = primes[k];

                            if (summandOne + summandTwo + summandThree == input)
                            {
                                foundSummands = true;
                                break;
                            }
                        }

                        if (foundSummands)
                        {
                            break;
                        }
                    }

                    if (foundSummands)
                    {
                        break;
                    }
                }

                TxtOutput.Text = "The summands are: " + summandOne + ", " + summandTwo + ", " + summandThree;
            }
        }

        private void BtnFindPrimes_Click(object sender, EventArgs e)
        {
            int input = (int)numericInput.Value;
            IList<int> primes = new List<int>();

            for (int i = 2; i < input; i++)
            {
                bool prime = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    primes.Add(i);
                }
            }

            for (int i = 0; i < primes.Count; i++)
            {
                listPrimes.Items.Add(primes[i]);
            }
        }
    }
}
