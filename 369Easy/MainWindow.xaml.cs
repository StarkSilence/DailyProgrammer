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

namespace DP_Challenge_369_Easy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Dictionary<int, char> IntToHexChar = new Dictionary<int, char>()
        {
            {0, '0' },
            {1, '1' },
            {2, '2' },
            {3, '3' },
            {4, '4' },
            {5, '5' },
            {6, '6' },
            {7, '7' },
            {8, '8' },
            {9, '9' },
            {10, 'A' },
            {11, 'B' },
            {12, 'C' },
            {13, 'D' },
            {14, 'E' },
            {15, 'F' }
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonGetHexColor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] rgb = ReadTextBoxes();
                string hex = "#";

                for (int i = 0; i < rgb.Length; i++)
                {
                    hex += rgb[i].ToString("X");
                }

                TextBoxOutput.Text = hex;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private int[] ReadTextBoxes()
        {
            int[] rgbInts = new int[3];
            string[] rgbText = new string[]
            {
                TextBoxRed.Text,
                TextBoxGreen.Text,
                TextBoxBlue.Text
            };

            for (int i = 0; i < rgbText.Length; i++)
            {
                if (!int.TryParse(rgbText[i], out rgbInts[i]))
                    throw new Exception("Could not read text");
                if (rgbInts[i] > 255)
                    throw new Exception("Can not have values greater than 255");
                if (rgbInts[i] < 0)
                    throw new Exception("Can not have values less than 0");
            }

            return rgbInts;
        }

        private string ConvertIntToHex(int intValue)
        {
            string hex = "";
            int divisor = 16;

            while (true)
            {
                if ((double)intValue / divisor >= 16)
                    divisor *= 16;
                else
                    break;
            }

            while (divisor > 0)
            {
                hex += IntToHexChar[intValue / divisor];
                intValue %= divisor;
                divisor /= 16;
            }

            return hex;
        }
    }
}
