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

namespace View
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

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {

            double f = double.Parse(fahrenheitTextBox.Text);
            double c = Math.Round((f - 32) * 0.5556,2);
            string s = c.ToString();
            celsiusTextBox.Text = s;
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            double c = double.Parse(celsiusTextBox.Text);
            double f = Math.Round((c * 1.8) + 32, 2);
            string s = f.ToString();
            fahrenheitTextBox.Text = s;
        }
    }
}
