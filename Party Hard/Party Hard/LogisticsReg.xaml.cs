﻿using System;
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
    /// Interaction logic for LogisticsReg.xaml
    /// </summary>
    public partial class LogisticsReg : Window
    {
        public LogisticsReg()
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
    }
}
