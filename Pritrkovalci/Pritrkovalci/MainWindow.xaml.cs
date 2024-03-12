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

namespace Pritrkovalci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] zvoniki = { "Vipavski križ", "Renče", "Koper", "Nova Gorica" };
        private string[] metode = { "Plain Bob", "Kent Treble Bob", "Crawfard Little Court", "Old Oxford Delight" };
        public MainWindow()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            cboZvoniki.Items.Clear();
            lstMetode.Items.Clear();
            //napolni combobox sboZvoniki
            foreach(string a in zvoniki)
                cboZvoniki.Items.Add(a);

            foreach (string a in metode)
            {
                CheckBox metoda = new CheckBox();
                metoda.Margin = new Thickness(0,0,0,10);
                metoda.Content = a;
                lstMetode.Items.Add(metoda);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtIme.Text + " " + txtPriimek.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Reset();
        }
    }
}
