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

        private void Seštej()
        {
            int rezultat = int.Parse(txtPrvo.Text) + int.Parse(txtDrugo.Text);
            txtRezultat.Text = rezultat + "";
        }

        private void Odštej()
        {
            int rezultat = int.Parse(txtPrvo.Text) - int.Parse(txtDrugo.Text);
            txtRezultat.Text = rezultat + "";
        }

        private void Množi()
        {
            int rezultat = int.Parse(txtPrvo.Text) * int.Parse(txtDrugo.Text);
            txtRezultat.Text = rezultat + "";
        }

        private void Deli()
        {
            int rezultat = int.Parse(txtPrvo.Text) / int.Parse(txtDrugo.Text);
            txtRezultat.Text = rezultat + "";
        }

        private void AliJeNegativno()
        {
            if (int.Parse(txtRezultat.Text) < 0)
                txtRezultat.Background = new SolidColorBrush(Colors.Red);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (radSeštej.IsChecked == true)
                Seštej();
            if (radOdštej.IsChecked == true)
                Odštej();
            if (radMnoži.IsChecked == true)
                Množi();
            if (radDeli.IsChecked == true)
                Deli();
            if (chkNegativno.IsChecked == true)
                AliJeNegativno();
        }
    }
}
