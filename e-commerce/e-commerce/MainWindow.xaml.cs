using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Shapes;
using System.Diagnostics;
using e_commerce.Model;
using System.Security.Cryptography.X509Certificates;
using e_commerce.View;

namespace e_commerce
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool error = true;
            string email = txtUser.Text;
            string password = txtPass.Password;

            if (email == "root" && password == "")
            {
                error = false;
                ShowProduct objSecondWindow = new ShowProduct(email, password);
                this.Visibility = Visibility.Hidden;
                objSecondWindow.Show();
            }
            if (txtUser.Text.Length == 0)
            {
                txtUser.Text = "Enter an email.";
                txtUser.Focus();
            }

            if (error == true)
            {
                MessageBox.Show("error");
            }
        }
    }
}
