using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ujfelhasznalo.xaml
    /// </summary>
    public partial class ujfelhasznalo : Window
    {
        public string ujFelhasznaloNev;
        public string ujJelszo;
        public ujfelhasznalo()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            ujFelhasznaloNev = Username.Text;
            ujJelszo = Password.Password;
            FileStream f = new FileStream("adat.txt", FileMode.Create);
            StreamWriter iras = new StreamWriter(f);
            iras.WriteLine(ujFelhasznaloNev);
            iras.WriteLine(ujJelszo);
            f.Close();
        }
    }
}
