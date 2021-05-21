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
using Souvenir_Classi;

namespace Souvenir_Narzia
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
        List<Articolo> articoli = new List<Articolo>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Articolo a = new Articolo("Felpa_black", 19.99);
            articoli.Add(a);
            lst_articoli.Items.Add(a.Name);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Articolo a = new Articolo("Felpa_white", 19.99);
            articoli.Add(a);
            lst_articoli.Items.Add(a.Name);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Articolo a = new Articolo("Tshirt_black", 9.99);
            articoli.Add(a);
            lst_articoli.Items.Add(a.Name);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Articolo a = new Articolo("Tshirt_white", 9.99);
            articoli.Add(a);
            lst_articoli.Items.Add(a.Name);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Articolo a = new Articolo("Cover_vaporwave", 5.99);
            articoli.Add(a);
            lst_articoli.Items.Add(a.Name);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            new Souvenir_Narzia.Cassa().ShowDialog();
        }
    }
}
