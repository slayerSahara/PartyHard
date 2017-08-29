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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Marketing : Window
    {
        public Marketing()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

         private void LogoutButton_click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            this.Close();
        }
    }
}
