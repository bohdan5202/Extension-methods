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

        private void ProcessTask(TextBox inputTxt, TextBox outputTxt, Func<string, string> taskLogic, bool applyRegex = false)
        {
            try
            {
                string s = inputTxt.Text;
                
                if (applyRegex)
                {
                    s = s.Trim();
                    s = Regex.Replace(s, @"\s+", " ");
                }

                if (string.IsNullOrWhiteSpace(s))
                {
                    throw new Exception("Enter one or more words first.");
                }

                outputTxt.Text = taskLogic(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK);
            }
        }

        private void but1_Click(object sender, RoutedEventArgs e) => 
            ProcessTask(txt1, out1, s => s.FirstTask());

        private void but2_Click(object sender, RoutedEventArgs e) => 
            ProcessTask(txt2, out2, s => s.SecondTask());

        private void but3_Click(object sender, RoutedEventArgs e) => 
            ProcessTask(txt3, out3, s => "[ " + string.Join(", ", s.ThirdTask()) + " ]");

        private void but4_Click(object sender, RoutedEventArgs e) => 
            ProcessTask(txt4, out4, s => s.FourthTask().ToString());

        private void but5_Click(object sender, RoutedEventArgs e) => 
            ProcessTask(txt5, out5, s => s.FifthTask<char>().ToString(), applyRegex: true);

        private void ClearFields(TextBox inputTxt, TextBox outputTxt)
        {
            inputTxt.Clear();
            outputTxt.Clear();
        }

        private void clr1_Click(object sender, RoutedEventArgs e) => ClearFields(txt1, out1);
        private void clr2_Click(object sender, RoutedEventArgs e) => ClearFields(txt2, out2);
        private void clr3_Click(object sender, RoutedEventArgs e) => ClearFields(txt3, out3);
        private void clr4_Click(object sender, RoutedEventArgs e) => ClearFields(txt4, out4);
        private void clr5_Click(object sender, RoutedEventArgs e) => ClearFields(txt5, out5);
    }
}
