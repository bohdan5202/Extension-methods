using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using static System.Net.Mime.MediaTypeNames;

namespace lab5
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

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                 string s = txt1.Text;
                if (string.IsNullOrWhiteSpace(s))
                {
                    throw new Exception("Enter one or more words first.");
                }

                string result = s.FirstTask();
                out1.Text = result;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK);
            }

        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = txt2.Text;
                if (string.IsNullOrWhiteSpace(s))
                {
                    throw new Exception("Enter one or more words first.");
                }

                string result = s.SecondTask();
                out2.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK);
            }
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = txt3.Text;
                if (string.IsNullOrWhiteSpace(s))
                {
                    throw new Exception("Enter one or more words first.");
                }
                int[] result = s.ThirdTask();
                out3.Text = "[ " + string.Join(", ", result) + " ]";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK);
            }
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = txt4.Text;
                if (string.IsNullOrWhiteSpace(s))
                {
                    throw new Exception("Enter one or more words first.");
                }
                Boolean result = s.FourthTask();
                out4.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK);
            }
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = txt5.Text.Trim();
                s = Regex.Replace(s, @"\s+", " ");

                if (string.IsNullOrWhiteSpace(s))
                {
                    throw new Exception("Enter one or more words first.");
                }
                Char result = s.FifthTask<char>();
                out5.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK);
            }
        }

        private void clr1_Click(object sender, RoutedEventArgs e)
        {
            txt1.Clear();
            out1.Clear();
        }

        private void clr2_Click(object sender, RoutedEventArgs e)
        {
            txt2.Clear();
            out2.Clear();
        }

        private void clr3_Click(object sender, RoutedEventArgs e)
        {
            txt3.Clear();
            out3.Clear();
        }

        private void clr4_Click(object sender, RoutedEventArgs e)
        {
            txt4.Clear();
            out4.Clear();
        }

        private void clr5_Click(object sender, RoutedEventArgs e)
        {
            txt5.Clear();
            out5.Clear();
        }
    }
}
