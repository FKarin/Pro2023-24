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

namespace MešanjeBarv
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

        private void sldRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)sldRed.Value;
            byte g = (byte)sldGreen.Value;
            byte b = (byte)sldBlue.Value;
            p1.Fill = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void sldGreen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)sldRed.Value;
            byte g = (byte)sldGreen.Value;
            byte b = (byte)sldBlue.Value;
            p1.Fill = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void sldBlue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)sldRed.Value;
            byte g = (byte)sldGreen.Value;
            byte b = (byte)sldBlue.Value;
            p1.Fill = new SolidColorBrush(Color.FromRgb(r, g, b));
        }
    }
}
