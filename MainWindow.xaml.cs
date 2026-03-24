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
                txt1.Text = result;
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
                txt2.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK);
            }
        }

       
    }
}
