using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Challenge362Medium
{
    public partial class Form362Medium : Form
    {
        public Form362Medium()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("((?<=\")[a-zA-Z0-9\\D]+(?=\"))|" +
                "((?<=\\()\\d+(?=,\\s*\\d+\\)))|" +
                "((?<=\\(\\d+,\\s*)\\d+(?=\\))|" +
                "((?<=\\(\\d+,\\s*\\d+\\) )[a-z\\D]+))");
            MatchCollection matches = regex.Matches(TxtInput.Text);

            int width = int.Parse(matches[1].Value);
            int height = int.Parse(matches[2].Value);
            string input = cleanInput(matches[0].Value, height, width);
            char[,] inputMatrix = createCharMatrix(input, height, width);

            string output;
            if (matches[3].Value == "clockwise")
                output = clockwise(inputMatrix, height, width);
            else
                output = CounterClockwise(inputMatrix, height, width);

            TxtOutput.Text = output;
        }

        private string cleanInput(string input, int height, int width)
        {
            input = new string(input.Where(c => char.IsLetterOrDigit(c)).ToArray());

            for (int i = 0, newLength = width * height; i < newLength; i++)
                if (i >= input.Length)
                    input += 'X';

            return input;
        }

        private char[,] createCharMatrix(string input, int height, int width)
        {
            char[,] charMatrix = new char[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    charMatrix[i, j] = char.ToUpper(input[i * width + j]);
                }
            }

            return charMatrix;
        }

        private string clockwise(char[,] inputMatrix, int height, int width)
        {
            int[] marker = new int[] { 0, width - 1 };
            StringBuilder output = new StringBuilder(width * height);

            for (int i = 1; char.IsLetterOrDigit(inputMatrix[marker[0], marker[1]]); i++)
            {
                switch (i)
                {
                    case 1:
                        encryptDown(inputMatrix, marker, output, height, false);
                        break;
                    case 2:
                        encryptLeft(inputMatrix, marker, output, false);
                        break;
                    case 3:
                        encryptUp(inputMatrix, marker, output, false);
                        break;
                    case 4:
                        encryptRight(inputMatrix, marker, output, width, false);
                        break;
                    default:
                        i = 0;
                        break;
                }
            }

            return output.ToString();
        }

        private string CounterClockwise(char[,] inputMatrix, int height, int width)
        {
            int[] marker = new int[] { 0, width - 1 };
            StringBuilder output = new StringBuilder(width * height);

            for (int i = 1; char.IsLetterOrDigit(inputMatrix[marker[0], marker[1]]); i++)
            {
                switch (i)
                {
                    case 1:
                        encryptLeft(inputMatrix, marker, output, true);
                        break;
                    case 2:
                        encryptDown(inputMatrix, marker, output, height, true);
                        break;
                    case 3:
                        encryptRight(inputMatrix, marker, output, width, true);
                        break;
                    case 4:
                        encryptUp(inputMatrix, marker, output, true);
                        break;
                    default:
                        i = 0;
                        break;
                }
            }

            return output.ToString();
        }

        private void encryptDown(char[,] inputMatrix, int[] marker, StringBuilder output, int height, bool counterClockwise)
        {
            while (true)
            {
                output.Append(inputMatrix[marker[0], marker[1]]);
                inputMatrix[marker[0], marker[1]] = ' ';

                if (marker[0] + 1 >= height || !char.IsLetterOrDigit(inputMatrix[marker[0] + 1, marker[1]]))
                {
                    if (counterClockwise)
                        marker[1]++;
                    else
                        marker[1]--;

                    break;
                }
                else
                {
                    marker[0]++;
                }
            }
        }

        private void encryptLeft(char[,] inputMatrix, int[] marker, StringBuilder output, bool counterClockwise)
        {
            while (true)
            {
                output.Append(inputMatrix[marker[0], marker[1]]);
                inputMatrix[marker[0], marker[1]] = ' ';

                if (marker[1] - 1 < 0 || !char.IsLetterOrDigit(inputMatrix[marker[0], marker[1] - 1]))
                {
                    if (counterClockwise)
                        marker[0]++;
                    else
                        marker[0]--;
                    break;
                }
                else
                {
                    marker[1]--;
                }
            }
        }

        private void encryptUp(char[,] inputMatrix, int[] marker, StringBuilder output, bool counterClockwise)
        {
            while (true)
            {
                output.Append(inputMatrix[marker[0], marker[1]]);
                inputMatrix[marker[0], marker[1]] = ' ';

                if (marker[0] - 1 < 0 || !char.IsLetterOrDigit(inputMatrix[marker[0] - 1, marker[1]]))
                {
                    if (counterClockwise)
                        marker[1]--;
                    else
                        marker[1]++;

                    break;
                }
                else
                {
                    marker[0]--;
                }
            }
        }

        private void encryptRight(char[,] inputMatrix, int[] marker, StringBuilder output, int width, bool counterClockwise)
        {
            while (true)
            {
                output.Append(inputMatrix[marker[0], marker[1]]);
                inputMatrix[marker[0], marker[1]] = ' ';

                if (marker[1] + 1 >= width || !char.IsLetterOrDigit(inputMatrix[marker[0], marker[1] + 1]))
                {
                    if (counterClockwise)
                        marker[0]--;
                    else
                        marker[0]++;

                    break;
                }
                else
                {
                    marker[1]++;
                }
            }
        }
    }
}

// "This is an example" (6, 3)