using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Challenge238Medium
{
    public partial class Form238Medium : Form
    {
        int turnsLeft = 4;
        string[] words = new string[15];
        string answer;
        int difficulty;
        bool continueGame;

        public Form238Medium()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listOptions.Items.Clear();
            listOptions.Items.Add("Difficulty " + numDifficulty.Value);
            turnsLeft = 4;
            continueGame = true;

            Random rnd = new Random();
            int minDifficulty = 3 + (int)numDifficulty.Value * 2;
            int maxDifficulty = 5 + (int)numDifficulty.Value * 2;
            difficulty = rnd.Next(minDifficulty, maxDifficulty);

            string[] lines = File.ReadAllLines("wordLength" + difficulty + ".txt");

            for (int i = 0; i < difficulty; i++)
            {
                string word = lines[rnd.Next(1, lines.Length)];

                if (listOptions.Items.Contains(word))
                {
                    i--;
                }
                else
                {
                    listOptions.Items.Add(word);
                    words[i] = word;
                }                
            }

            answer = words[rnd.Next(0, difficulty)];
            listOptions.Items.Add("Guess (" + turnsLeft + " left)?");
        }

        private void listOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string guess = listOptions.SelectedItem.ToString();

            if (guess.Contains("Guess ") || guess.Contains("Difficulty "))
            {

            }
            else if (continueGame)
            {
                int numberCorrect = 0;                

                listOptions.Items.Add(listOptions.SelectedItem);
                turnsLeft--;

                for (int i = 0; i < difficulty; i++)
                {
                    if (guess[i] == answer[i])
                    {
                        numberCorrect++;
                    }
                }

                if (numberCorrect == difficulty)
                {
                    listOptions.Items.Add(numberCorrect + "/" + difficulty + " correct");
                    listOptions.Items.Add("You win!");
                    continueGame = false;
                }
                else
                {
                    listOptions.Items.Add(numberCorrect + "/" + difficulty + " correct");
                    
                    if (turnsLeft == 0)
                    {
                        continueGame = false;
                        listOptions.Items.Add("You lost!");
                    }
                    else
                    {
                        listOptions.Items.Add("Guess (" + turnsLeft + " left)?");
                    }
                }
            }            
        }
    }
}
