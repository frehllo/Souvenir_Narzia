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

namespace Restaurant_Narzia
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

        List<string> ordine = new List<string>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ordine.Add("San Benedetto Frizzante");
            lst_ordine.Items.Add("San Benedetto Frizzante");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ordine.Add("Rocchetta Naturale");
            lst_ordine.Items.Add("Rocchetta Naturale");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ordine.Add("Piceno Vino Rosso");
            lst_ordine.Items.Add("Piceno Vino Rosso");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ordine.Add("Coca Cola 1l");
            lst_ordine.Items.Add("Coca Cola 1l");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ordine.Add("Crostino Pomodoro e Olive");
            lst_ordine.Items.Add("Crostino Pomodoro e Olive");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ordine.Add("Crostini Misti");
            lst_ordine.Items.Add("Crostini Misti");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ordine.Add("Tagliere Salami");
            lst_ordine.Items.Add("Tagliere Salami");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ordine.Add("Pappa al pomodoro");
            lst_ordine.Items.Add("Pappa al pomodoro");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ordine.Add("Spaghetti Carbonara");
            lst_ordine.Items.Add("Spaghetti Carbonara");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ordine.Add("Tagliatelle Gamberi e Pomodoro");
            lst_ordine.Items.Add("Tagliatelle Gamberi e Pomodoro");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ordine.Add("Pasta Fredda");
            lst_ordine.Items.Add("Pasta Fredda");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ordine.Add("Tagliatelle al Ragù di Cinghiale");
            lst_ordine.Items.Add("Tagliatelle al Ragù di Cinghiale");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            ordine.Add("Fiorentina");
            lst_ordine.Items.Add("Fiorentina");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            ordine.Add("Arrosticini di Pollo");
            lst_ordine.Items.Add("Arrosticini di Pollo");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            ordine.Add("Grigliata Mista");
            lst_ordine.Items.Add("Grigliata Mista");
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            ordine.Add("Patatine Fritte");
            lst_ordine.Items.Add("Patatine Fritte");
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            lbl_sender.Content = "Send";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            lst_ordine.Items.Clear();
            for(int i = 0; i < ordine.Count; i++)
            {
                ordine.RemoveAt(i);
            }
        }
    }
}
