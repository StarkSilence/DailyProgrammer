using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Challenge363Medium
{
    public partial class Form363Medium : Form
    {
        private const string HyphenationPatternsFilePath = @"tex-hyphenation-patterns.txt";
        
        private class TrieNode
        {
            public string Word { get; private set; } = null;
            public IDictionary<char, TrieNode> SubNodes { get; set; } = new Dictionary<char, TrieNode>();

            public void SetWord(string word)
            {
                if (Word == null) Word = word;
                else throw new Exception("Word already set");
            }
        }
        
        public Form363Medium()
        {
            InitializeComponent();
        }

        private void btnHyphenate_Click(object sender, EventArgs e)
        {
            Dictionary<char, TrieNode> PatternTrie = CreateTrie();
            string input = "." + txtInput.Text + ".";

            Hyphenate(PatternTrie, input);
        }

        private void BtnHyphenateAll_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Dictionary<char, TrieNode> PatternTrie = CreateTrie();
            string[] words = File.ReadAllLines(@"enable1.txt");

            for (int i = 0, numOfWords = words.Length; i < numOfWords; i++)
            {
                Hyphenate(PatternTrie, words[i]);
            }

            stopwatch.Stop();
            txtOutput.Text = stopwatch.ElapsedMilliseconds.ToString();
        }

        private void Hyphenate(Dictionary<char, TrieNode> PatternTrie, string input)
        {
            int[] hyphens = new int[input.Length - 2];

            for (int i = 0, wordLength = input.Length; i < wordLength - 2; i++)
            {
                int maxSubstringLength = wordLength - i >= 8 ? 8 : wordLength - i;

                for (int j = 1; j <= maxSubstringLength; j++)
                {
                    string substringToReplace = input.Substring(i, j);
                    string substring = SearchTrie(PatternTrie, substringToReplace);

                    if (substring != null)
                    {
                        hyphens = getNumbersFromMatch(hyphens, substring, i);
                    }
                }
            }

            string output = input.Trim('.');

            output = InsertHyphens(output, hyphens);

            txtOutput.Text = output;
        }

        private int[] getNumbersFromMatch(int[] hyphens, string match, int offset)
        {
            int numCount = 0;

            for (int i = 0; i < match.Length; i++)
            {
                if (char.IsDigit(match[i]) && (int) char.GetNumericValue(match[i]) > hyphens[offset + i - numCount])
                {
                    hyphens[offset + i - numCount] = (int) char.GetNumericValue(match[i]);
                    numCount++;
                }
            }

            return hyphens;
        }

        private string InsertHyphens(string input, int[] hyphens)
        {
            int hyphenCount = 0;

            for (int i = 0; i < hyphens.Length - 1; i++)
            {
                if (hyphens[i] % 2 == 1)
                {
                    input = input.Insert(i + hyphenCount - 1, "-");
                    hyphenCount++;
                }
            }

            return input;
        }

        private Dictionary<char, TrieNode> CreateTrie()
        {
            string[] hyphenationPatterns = File.ReadAllLines(HyphenationPatternsFilePath);
            Dictionary<char, TrieNode> PatternTrie = new Dictionary<char, TrieNode>();

            for (int i = 0, numberOfPatterns = hyphenationPatterns.Length; i < numberOfPatterns; i++)
            {
                string wordNoNumbers = new string(hyphenationPatterns[i].Where(c => !char.IsDigit(c)).ToArray());

                CreateTrieNodes(PatternTrie, wordNoNumbers).SetWord(hyphenationPatterns[i]);
            }

            return PatternTrie;
        }

        private TrieNode CreateTrieNodes(Dictionary<char, TrieNode> PatternTrie, string word)
        {
            TrieNode trieNode;

            int index = 0;
            if (PatternTrie.ContainsKey(word[index]))
            {
                trieNode = PatternTrie[word[index]];
            }
            else
            {
                PatternTrie.Add(word[index], new TrieNode());
                trieNode = PatternTrie[word[index]];
            }

            for (int i = index + 1, wordLength = word.Length; i < wordLength; i++)
            {
                if (trieNode.SubNodes.ContainsKey(word[i]))
                {
                    trieNode = trieNode.SubNodes[word[i]];
                }
                else
                {
                    trieNode.SubNodes.Add(word[i], new TrieNode());
                    trieNode = trieNode.SubNodes[word[i]];
                }
            }

            return trieNode;
        }

        private string SearchTrie(Dictionary<char, TrieNode> PatternTrie, string word)
        {
            TrieNode trieNode = PatternTrie[word[0]];

            for (int i = 1; i < word.Length; i++)
            {
                if (!trieNode.SubNodes.ContainsKey(word[i])) return null;
                trieNode = trieNode.SubNodes[word[i]];
            }

            return trieNode.Word;
        }
    }
}
