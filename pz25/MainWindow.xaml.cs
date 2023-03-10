using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace pz25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1;
        int num2;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void press1Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "1";
        }
        private void press2Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "2";
        }
        private void press3Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "3";
        }
        private void press4Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "4";
        }
        private void press5Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "5";
        }
        private void press6Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "6";
        }
        private void press7Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "7";
        }
        private void press8Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "8";
        }
        private void press9Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "9";
        }
        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "+";
            
        }
        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "-";
        }
        private void umnButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "*";
        }
        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "/";
        }
        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text = Calculation(inputTextBlock.Text);
        }
        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "0";
        }
        private string Calculation(string expression)
        {
            DataTable dt = new DataTable();
            object result = dt.Compute(expression, "");
            return Convert.ToString(result);
        }
    }   
}
