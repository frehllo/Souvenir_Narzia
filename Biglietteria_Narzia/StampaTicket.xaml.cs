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
using System.Windows.Shapes;

namespace Biglietteria_Narzia
{
    /// <summary>
    /// Interaction logic for StampaTicket.xaml
    /// </summary>
    public partial class StampaTicket : Window
    {
        public StampaTicket(string user)
        {
            InitializeComponent();
            string username = user;
            Random r = new Random();
            int i = 0;
            i = r.Next(0, 1000);
            DateTime date = DateTime.Now;
            lbl_user.Content = $"{user}";
            lbl_data_ora.Content = $"{date}";
            lbl_codice.Content = i.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbl_stampa.Content = "Stampato correttamente";
        }
    }
}
