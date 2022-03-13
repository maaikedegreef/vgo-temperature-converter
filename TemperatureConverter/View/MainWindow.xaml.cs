using System;
using System.Collections.Generic;
using System.Globalization;
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

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var kelvin = slider.Value;
            var celsius = kelvin - 273.15;
            var fahrenheit = celsius * 1.8 + 32;

            var kelvinString = kelvin.ToString();
            var fahrenheitString = fahrenheit.ToString();

            fahrenheitTextBox.Text = fahrenheitString;
        }

        public class TemperatureConverter : IValueConverter
        {
            public ITemperatureScale TemperatureScale { get; set; }

            public TemperatureConverter(ITemperatureScale tempScale)
            {
                TemperatureScale = tempScale;
            }

            public TemperatureConverter()
            {

            }

            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return null; // this.TemperatureScale.ConvertFromKelvin((double)value);
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return null; // this.TemperatureScale.ConvertToKelvin((double)value);
            }
        }
    }

    
        

    public class FahrenheitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kelvin = (double)value;
            var fahrenheit = 1.8 * (kelvin - 273) +32;

            return fahrenheit;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fahrenheit = double.Parse((string)value);
            var kelvin = (5/9)*fahrenheit + 459.67;

            return kelvin;
        }
    }

    //onderstaande code zou in aparte klasse TemperatureScale.cs moeten staan
    public interface ITemperatureScale
    {
        string Name { get; }

        double ConvertToKelvin(double temperature);
        double ConvertFromKelvin(double temperature);
    }

    public class KelvinTemperatureScale : ITemperatureScale
    {
        // shortened syntax for getter that consits of a sole return statement
        public string Name => "Kelvin";

        public double ConvertFromKelvin(double temperature)
        {
            return temperature;
        }

        public double ConvertToKelvin(double temperature)
        {
            return temperature;
        }
    }

    public class CelsiusTemperatureScale : ITemperatureScale
    {
        // shortened syntax for getter that consits of a sole return statement
        public string Name => "Celsius";

        public double ConvertFromKelvin(double temperature)
        {
            return temperature - 273.15;
        }

        public double ConvertToKelvin(double temperature)
        {
            return temperature + 273.15;
        }
    }

    public class FahrenheitTemperatureScale : ITemperatureScale
    {
        // shortened syntax for getter that consits of a sole return statement
        public string Name => "Fahrenheit";

        public double ConvertFromKelvin(double temperature)
        {
            return 1.8 * (temperature - 273) + 32; ;
        }

        public double ConvertToKelvin(double temperature)
        {
            return (5 / 9) * temperature + 459.67;
        }
    }
}
