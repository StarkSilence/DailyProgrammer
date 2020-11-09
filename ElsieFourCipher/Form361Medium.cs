using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Challenge361Medium2
{
    public partial class Challenge361Medium : Form
    {
        private const string alphabet = "#_23456789abcdefghijklmnopqrstuvwxyz";

        public Challenge361Medium()
        {
            InitializeComponent();
        }

        private void btnEncyrptDecrypt_Click(object sender, EventArgs e)
        {
            if (txtInput.Text[0] == '%')
            {

            }
            else
            {
                Decrypt();
            }
        }

        private void Decrypt()
        {
            string plainText = "%";
            string cipherText = txtInput.Text;
            List<char> key = txtKey.Text.ToList();
            char marker = key[0];
            
            int cipherLength = cipherText.Length;
            for (int i = 0; i < cipherLength; i++)
            {
                int horizontalPos = key.IndexOf(cipherText[i]) % 6 - alphabet.IndexOf(marker) % 6;
                if (horizontalPos < 0) horizontalPos += 6;

                int verticalPos = key.IndexOf(cipherText[i]) / 6 - alphabet.IndexOf(marker) / 6;
                if (verticalPos < 0) verticalPos += 6;

                plainText += key[verticalPos * 6 + horizontalPos];

                char buffer = key[verticalPos * 6 + 5];
                for (int j = 5; j > 0; j--)
                {
                    key[j + verticalPos * 6] = key[j + verticalPos * 6 - 1];
                }
                key[verticalPos * 6] = buffer;

                horizontalPos = key.IndexOf(cipherText[i]) % 6;
                buffer = key[horizontalPos + 30];
                for (int j = 5; j > 0; j--)
                {
                    key[j * 6 + horizontalPos] = key[j * 6 + horizontalPos - 6];
                }
                key[horizontalPos] = buffer;

                horizontalPos = key.IndexOf(marker) % 6 + alphabet.IndexOf(cipherText[i]) % 6;
                if (horizontalPos >= 6) horizontalPos -= 6;

                verticalPos = key.IndexOf(marker) / 6 + alphabet.IndexOf(cipherText[i]) / 6;
                if (verticalPos >= 6) verticalPos -= 6;

                marker = key[verticalPos * 6 + horizontalPos];
            }
            
            txtOutput.Text = plainText;
        }
    }
}
