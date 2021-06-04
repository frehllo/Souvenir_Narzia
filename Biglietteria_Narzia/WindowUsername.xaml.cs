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
using System.IO;

namespace Biglietteria_Narzia
{
    /// <summary>
    /// Logica di interazione per WindowUsername.xaml
    /// </summary>
    public partial class WindowUsername : Window
    {
        public WindowUsername()
        {
            InitializeComponent();
        }

        public string file = @"username.txt";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader usernamer = new StreamReader(file))
            {
                string line;
                while ((line = usernamer.ReadLine()) != null)
                {
                    if(line == username_txt.Text)
                    {
                        new Biglietteria_Narzia.StampaTicket(username_txt.Text).ShowDialog();
                        this.Close();
                    }else
                    {
                        lbl_error_username.Content = "Account non esistente";
                    }
                }
            }
        }
    }
}
