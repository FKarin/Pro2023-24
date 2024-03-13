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

namespace KalkulatorV4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rezultat = 0;
            if (radSeštej.IsChecked == true)
                rezultat = double.Parse(txtPrvo.Text) + double.Parse(txtDrugo.Text);
            if (radOdštej.IsChecked == true)
                rezultat = double.Parse(txtPrvo.Text) - double.Parse(txtDrugo.Text);
            if (radMnoži.IsChecked == true)
                rezultat = double.Parse(txtPrvo.Text) * double.Parse(txtDrugo.Text);
            if (radDeli.IsChecked == true)
                rezultat = double.Parse(txtPrvo.Text) / double.Parse(txtDrugo.Text);
            txtRezultat.Text = rezultat + "";
            if (chkNegativno.IsChecked == true)
            {
                if (double.Parse(txtRezultat.Text) < 0)
                    txtRezultat.Background = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
