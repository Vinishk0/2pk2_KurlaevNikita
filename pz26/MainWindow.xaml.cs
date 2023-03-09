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

namespace pz26
{
    public partial class MainWindow : Window
    {
        bool ital = false;
        bool bld = false;
        bool und = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (bld)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            if (ital)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            if (und)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
            
            textBox.FontWeight = FontWeights.Bold;
        }
        private void italicc(object sender, RoutedEventArgs e)
        {
            if (!ital)
                ital = true;
            else
                ital = false;
        }
        private void blodd(object sender, RoutedEventArgs e)
        {
            if (!bld)
                bld = true;
            else
                bld = false;
        }
        private void underr(object sender, RoutedEventArgs e)
        {
            if (!und)
                und = true;
            else
                und = false;
        }
    }
}     
