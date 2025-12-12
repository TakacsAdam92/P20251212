using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P20251212
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        const string felhasznalo = "info";
        const string jelszo = "Premo900";
        public Login()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            if (Username.Text == felhasznalo && Password.Password == jelszo)
            {
                MessageBox.Show("Sikeres bejelentkezés!");
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!");
            }
        }

        private void ujUser_Click(object sender, RoutedEventArgs e)
        {
            ujfelhasznalo newin = new ujfelhasznalo();
            newin.Show();
        }
    }
}
