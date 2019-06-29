using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Challenge355Easy
{
    public partial class Form355Easy : Form
    {
        private string[] alphabet = new string[]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        public Form355Easy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = TxtOutput.Text;
            int split = input.IndexOf(" ");
            string codeword = input.Substring(0, split);
            string toEncrypt = input.Substring(split + 1, (input.Length - split) - 1);
            string output = codeword + " ";

            for (int i = 0; i <= toEncrypt.Length - 1; i++)
            {
                string letterEncrypt = toEncrypt.Substring(i, 1);
                string letterCodeword;

                if (i > codeword.Length - 1)
                {
                    int j = i - codeword.Length;

                    while (j > codeword.Length - 1)
                    {
                        j -= (codeword.Length);
                    }

                    letterCodeword = codeword.Substring(j, 1);
                }
                else
                {
                    letterCodeword = codeword.Substring(i, 1);
                }

                int offset = Array.IndexOf(alphabet, letterEncrypt);

                if (offset + Array.IndexOf(alphabet, letterCodeword) > alphabet.Length - 1)
                {
                    offset -= alphabet.Length;
                }

                output += alphabet[offset + Array.IndexOf(alphabet, letterCodeword)];

                TxtInput.Text = output;
            }
        }
    }
}
