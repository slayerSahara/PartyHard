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

namespace Party_Hard
{
    /// <summary>
    /// Interaction logic for CateringAdmin.xaml
    /// </summary>
    public partial class CateringAdmin : Window
    {
        public CateringAdmin()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            App.Current.MainWindow = login;
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
