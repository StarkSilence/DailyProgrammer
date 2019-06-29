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

namespace Challenge366Medium
{
    public partial class Form366Medium : Form
    {
        private const string wordFile = @"enable1.txt";
        private readonly HashSet<string> words = new HashSet<string>(File.ReadAllLines(wordFile));
        Thread funnelThread;

        public Form366Medium()
        {
            InitializeComponent();
        }

        private void btnFindFunnel_Click(object sender, EventArgs e)
        {
            if (funnelThread == null || !funnelThread.IsAlive)
            {
                listOutput.Items.Clear();
                listOutput.Items.Add("1 " + txtInput.Text);

                funnelThread = new Thread(() => findFunnel(txtInput.Text, 2)) { IsBackground = true };
                funnelThread.Start();
            }
        }

        private void btnFindLongestFunnel_Click(object sender, EventArgs e)
        {
            if (funnelThread == null || !funnelThread.IsAlive)
            {
                listOutput.Items.Clear();

                funnelThread = new Thread(findLongestFunnel) { IsBackground = true };
                funnelThread.Start();
            }
        }

        private void findLongestFunnel()
        {
            string[] file = File.ReadAllLines(wordFile);
            List<string> longestFunnel = new List<string>();
            List<string> funnelList = new List<string>();

            for (int i = 0, length = file.Length; i < length; i++)
            {
                funnelList.Clear();
                funnelList.Add(file[i]);
                funnelList = findFunnel(file[i], funnelList);

                if (funnelList.Count > longestFunnel.Count)
                {
                    longestFunnel = funnelList.ToList();
                }
            }

            foreach (string item in longestFunnel)
            {
                addText(item);
            }
        }

        private void findFunnel(string current, int count)
        {
            for (int i = 0, length = current.Length; i < length; i++)
            {
                string next = current.Remove(i, 1);

                if (words.Contains(next))
                {
                    addText(count + " " + next);
                    findFunnel(next, count + 1);
                }
            }
        }

        private List<string> findFunnel(string current, List<string> funnelList)
        {
            List<string> localFunneList = new List<string>(funnelList);

            for (int i = 0, length = current.Length; i < length; i++)
            {
                string next = current.Remove(i, 1);
                
                if (words.Contains(next))
                {
                    List<string> newFunnelList = new List<string>(localFunneList);
                    newFunnelList.Add(next);

                    newFunnelList = findFunnel(next, newFunnelList);

                    if (newFunnelList.Count > funnelList.Count)
                    {
                        funnelList = newFunnelList;
                    }
                }
            }

            return funnelList;
        }

        private void addText(string text)
        {
            Action action = () => listOutput.Items.Add(text);
            this.Invoke(action);
        }
    }
}
