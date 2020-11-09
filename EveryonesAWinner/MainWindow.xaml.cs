using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Text.RegularExpressions;

namespace Challenge358Medium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ScoresFilePath = @"scores.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, List<string>> LosersToWinners = new Dictionary<string, List<string>>();
            HashSet<string> Winners = new HashSet<string> { "Villanova" };

            string[] games = File.ReadAllLines(ScoresFilePath);

            SortMatches(LosersToWinners, games);
            TextOutput.Text = GetWinners(LosersToWinners, Winners).ToString();
        }

        private void SortMatches(Dictionary<string, List<string>> LosersToWinners, string[] games)
        {
            string[] match = new string[4];
            int[] scores = new int[2];

            for (int i = 0; i < games.Length; i++)
            {
                match = games[i].Split('|');

                scores[0] = int.Parse(match[1]);
                scores[1] = int.Parse(match[3]);
                if (scores[1] > scores[0])
                    throw new Exception("Score 1 greater than score 0");

                if (LosersToWinners.ContainsKey(match[2]))
                {
                    LosersToWinners[match[2]].Add(match[0]);
                }
                else
                {
                    LosersToWinners[match[2]] = new List<string> { match[0] };
                }
            }
        }

        private int GetWinners(Dictionary<string, List<string>> LosersToWinners, HashSet<string> Winners)
        {
            int winnersCount;
            List<string> lastWinners = Winners.ToList();
            List<string> newWinners = new List<string>();

            do
            {
                winnersCount = Winners.Count;

                for (int i = 0; i < lastWinners.Count; i++)
                {
                    lastWinners[i] = lastWinners[i].Trim();

                    if (LosersToWinners.ContainsKey(lastWinners[i]))
                    {
                        foreach (string newWinner in LosersToWinners[lastWinners[i]])
                        {
                            newWinners.Add(newWinner);
                        }

                        LosersToWinners.Remove(lastWinners[i]);
                    }
                }

                foreach (string newWinner in newWinners)
                {
                    Winners.Add(newWinner);
                }

                lastWinners = newWinners;
                newWinners = new List<string>();

            } while (winnersCount != Winners.Count);

            return winnersCount;
        }
    }
}
