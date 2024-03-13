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

namespace WPFVaja
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

        private void sldStotice1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int stotice = (int)sldStotice1.Value * 100;
            int desetice = (int)sldDesetice1.Value * 10;
            int enice = (int)sldEnice1.Value;
            int rezultat = stotice + desetice + enice;
            txtPrvo.Text = rezultat + "";
        }

        private void sldDesetice1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int stotice = (int)sldStotice1.Value * 100;
            int desetice = (int)sldDesetice1.Value * 10;
            int enice = (int)sldEnice1.Value;
            int rezultat = stotice + desetice + enice;
            txtPrvo.Text = rezultat + "";
        }

        private void sldEnice1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int stotice = (int)sldStotice1.Value * 100;
            int desetice = (int)sldDesetice1.Value * 10;
            int enice = (int)sldEnice1.Value;
            int rezultat = stotice + desetice + enice;
            txtPrvo.Text = rezultat + "";
        }

        private void sldStotice2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int stotice = (int)sldStotice2.Value * 100;
            int desetice = (int)sldDesetice2.Value * 10;
            int enice = (int)sldEnice2.Value;
            int rezultat = stotice + desetice + enice;
            txtDrugo.Text = rezultat + "";
        }

        private void sldDesetice2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int stotice = (int)sldStotice2.Value * 100;
            int desetice = (int)sldDesetice2.Value * 10;
            int enice = (int)sldEnice2.Value;
            int rezultat = stotice + desetice + enice;
            txtDrugo.Text = rezultat + "";
        }

        private void sldEnice2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int stotice = (int)sldStotice2.Value * 100;
            int desetice = (int)sldDesetice2.Value * 10;
            int enice = (int)sldEnice2.Value;
            int rezultat = stotice + desetice + enice;
            txtDrugo.Text = rezultat + "";
        }

        private void btnIzračunaj_Click(object sender, RoutedEventArgs e)
        {
            int prvo = int.Parse(txtPrvo.Text);
            int drugo = int.Parse(txtDrugo.Text);
            int rezultat = prvo + drugo;
            txtRezultat.Text = rezultat + "";
        }
    }
}
