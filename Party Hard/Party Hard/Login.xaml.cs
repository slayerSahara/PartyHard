using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Party_Hard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StringBuilder sb = new StringBuilder("", 4);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Length < 4)
            {
                sb.Append('1');
                loginField.Text = sb.ToString();
            }
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Length < 4)
            {
                sb.Append('2');
                loginField.Text = sb.ToString();
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Length < 4)
            {
                sb.Append('3');
                loginField.Text = sb.ToString();
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Length < 4)
            {
                sb.Append('4');
                loginField.Text = sb.ToString();
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Length < 4)
            {
                sb.Append('5');
                loginField.Text = sb.ToString();
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Length < 4)
            {
                sb.Append('6');
                loginField.Text = sb.ToString();
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Length < 4)
            {
                sb.Append('7');
                loginField.Text = sb.ToString();
            }
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Length < 4)
            {
                sb.Append('8');
                loginField.Text = sb.ToString();
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Length < 4)
            {
                sb.Append('9');
                loginField.Text = sb.ToString();
            }
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Length < 4)
            {
                sb.Append('0');
                loginField.Text = sb.ToString();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
            loginField.Text = sb.ToString();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (loginField.Text.Length == 4)
            {
                if (Regex.IsMatch(loginField.Text, @"^[0-9]+$"))
                {
                    if (sb.ToString() == "0000")
                    {
                        CateringReg catReg = new CateringReg();
                        catReg.Show();
                    }
                    else if (sb.ToString() == "1111")
                    {
                        CateringAdmin catAdm = new CateringAdmin();
                        catAdm.Show();
                    }
                    else if (sb.ToString() == "2222")
                    {
                        Financial finReg = new Financial();
                        finReg.Show();
                    }
                    else if (sb.ToString() == "3333")
                    {
                        AdminFinancial finAdm = new AdminFinancial();
                        finAdm.Show();
                    }
                    else if (sb.ToString() == "4444")
                    {
                        HR hrReg = new HR();
                        hrReg.Show();
                    }
                    else if (sb.ToString() == "5555")
                    {
                        HRAdmin hrAdm = new HRAdmin();
                        hrAdm.Show();
                    }
                    else if (sb.ToString() == "6666")
                    {
                        OfficeSupport off = new OfficeSupport();
                        off.Show();
                    }
                    else if (sb.ToString() == "7777")
                    {
                        LogisticsReg logReg = new LogisticsReg();
                        logReg.Show();
                    }
                    else if (sb.ToString() == "8888")
                    {
                        LogisticsAdmin logAdm = new LogisticsAdmin();
                        logAdm.Show();
                    }
                    else if (sb.ToString() == "9999")
                    {
                        Management mng = new Management();
                        mng.Show();
                    }
                }
            }
        }
    }
}
