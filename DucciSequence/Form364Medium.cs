using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Challenge354Medium
{
    public partial class Form1 : Form
    {
        Thread startFindThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindDucciSequence_Click(object sender, EventArgs e)
        {
            if (startFindThread == null || startFindThread.ThreadState == ThreadState.Stopped)
            {
                listOutput.Items.Clear();

                startFindThread = new Thread(startFind) { IsBackground = true };
                startFindThread.Start();
            }
        }

        private void startFind()
        {
            string[] inputString = txtInput.Text.TrimStart('(').TrimEnd(')').Split(',');
            int[] input = inputString.Select(i => int.Parse(i)).ToArray();
            int count = 1;

            addSequence(input);
            findDucciSequence(input, ref count);
            addCount(count);
        }

        private void findDucciSequence(int[] input, ref int count)
        {
            int[] inputCopy;
            HashSet<int[]> known = new HashSet<int[]>();

            while (input.Sum() != 0 && !known.Any(i => i.SequenceEqual(input.ToArray())))
            {
                count++;
                known.Add(input.ToArray());
                inputCopy = input.ToArray();

                for (int i = 0, length = input.Length; i < length - 1; i++)
                {
                    input[i] = Math.Abs(inputCopy[i] - inputCopy[i + 1]);
                }
                input[input.Length - 1] = Math.Abs(inputCopy[inputCopy.Length - 1] - inputCopy[0]);

                addSequence(input);
            }
        }

        private void addSequence(int[] output)
        {
            string[] outputArray = output.Select(i => i.ToString()).ToArray();
            string outputString = "[" + string.Join("; ", outputArray) + "]";

            Action action = (() => listOutput.Items.Add(outputString));
            this.Invoke(action);
        }

        private void addCount(int count)
        {
            Action action = (() => listOutput.Items.Add(count.ToString() + " steps"));
            this.Invoke(action);
        }
    }
}
