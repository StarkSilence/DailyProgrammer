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

namespace _376Medium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void IntTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
                return;

            bool shiftHeld = (Keyboard.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift;
            bool isNumberRowKey = e.Key >= Key.D0 && e.Key <= Key.D9;
            bool isNumberPadKey = e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9;

            if (shiftHeld || !(isNumberRowKey || isNumberPadKey))
                e.Handled = true;
        }

        private void ButtonFindLeaps_Click(object sender, RoutedEventArgs e)
        {
            if (!long.TryParse(TextBoxFirstYear.Text, out long firstYear))
            {
                MessageBox.Show("First year too high");
                return;
            }
            if (!long.TryParse(TextBoxSecondYear.Text, out long secondYear))
            {
                MessageBox.Show("Second year too high");
                return;
            }
            if (firstYear > secondYear)
            {
                MessageBox.Show("Second year can not be before the first");
                return;
            }

            var leapYearCount = GetLeapYearCount(firstYear, secondYear);
            TextBlockOutput.Text = leapYearCount.ToString();
        }

        long GetLeapYearCount(long firstYear, long secondYear)
        {
            var difference = secondYear - firstYear;

            var leapYearCount = difference;
            leapYearCount += (firstYear - 1) % 4;
            leapYearCount /= 4;

            var leapYearSkips = difference;
            leapYearSkips += (firstYear - 1) % 100;
            leapYearSkips /= 100;

            var leapYearSkipExceptions = GetSkipExceptions(200) + GetSkipExceptions(600);

            return leapYearCount - (leapYearSkips - leapYearSkipExceptions);

            long GetSkipExceptions(long remainder)
            {
                var firstYearSkips = ((firstYear - remainder - 1) / 900);
                var secondYearSkips = ((secondYear - remainder) / 900);

                return secondYearSkips - firstYearSkips;
            }
        }
    }
}
