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
using Biglietteria_Classi;
using System.IO;

namespace Biglietteria_Narzia
{
    /// <summary>
    /// Logica di interazione per WindowAddAccount.xaml
    /// </summary>
    public partial class WindowAddAccount : Window
    {
        public WindowAddAccount()
        {
            InitializeComponent();
        }
        string file = @"username.txt";
        string name;
        string surname;
        string username;
        string password;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_n.Text == "")
                {
                    MessageBox.Show("Name Box is null");
                }
                if (txt_c.Text == "")
                {
                    MessageBox.Show("Surname Box is null");
                }
                if (txt_username.Text == "")
                {
                    MessageBox.Show("Username Box is null");
                }
                if (txt_pass.Text == "")
                {
                    MessageBox.Show("Password Box is null");
                }
                using (StreamReader s = new StreamReader(file))
                {
                    string line;
                    username = txt_username.Text;

                    while ((line = s.ReadLine()) != null)
                    {
                        if (username == line)
                        {
                            lbl_error_account.Content = "Username already in use";
                        }
                        if (username != line && txt_c.Text != "" && txt_n.Text != "" && txt_pass.Text != "" && txt_username.Text != "")
                        {
                            lbl_error_account.Content = "";
                            new Biglietteria_Narzia.SuccesfullAccount().ShowDialog();
                        }
                    }
                }
            }catch
            {
                throw new Exception("");
            }

            name = txt_n.Text;
            surname = txt_c.Text;
            username = txt_username.Text;
            password = txt_pass.Text;

            using(StreamWriter w = new StreamWriter(file))
            {
                w.Write(username);
            }

            Persona p = new Persona(name, surname);
            Account a = new Account(username, password);
        }
    }
}
