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


        private void ConvertCelciusToFahrenheit(object sender, RoutedEventArgs e)
        {
            double c = double.Parse(celsiusTextBox.Text);
            double f = Math.Round((c * 1.8) + 32, 2);
            string s = f.ToString();
            fahrenheitTextBox.Text = s;
        }

        private void ConvertFahrenheitToKelvin(object sender, RoutedEventArgs e)
        {
            double f = double.Parse(fahrenheitTextBox.Text);
            double k = Math.Round((f + 459.67) * 5 / 9, 2);
            string s = k.ToString();
            kelvinTextBox.Text = s;
        }

        private void ConvertKelvinToCelcius(object sender, RoutedEventArgs e)
        {
            double k = double.Parse(kelvinTextBox.Text);
            double c = Math.Round(k - 273.15, 2);
            string s = c.ToString();
            celsiusTextBox.Text = s;
        }


        private void ConvertFromCelsius(object sender, RoutedEventArgs e)
        {
            ConvertCelciusToFahrenheit(sender, e);
            ConvertFahrenheitToKelvin(sender, e);
        }

        private void ConvertFromFahrenheit(object sender, RoutedEventArgs e)
        {
            ConvertFahrenheitToKelvin(sender, e);
            ConvertKelvinToCelcius(sender, e);
        }

        private void ConvertFromKelvin(object sender, RoutedEventArgs e)
        {
            ConvertKelvinToCelcius(sender, e);
            ConvertCelciusToFahrenheit(sender, e);
        }
    }
}
