using e_commerce.Model;
using e_commerce;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using MySqlConnector;
using System.Diagnostics;
using System.Security.Policy;
using System.Xml.Linq;
using System.CodeDom;

namespace e_commerce.View
{
    /// <summary>
    /// Logique d'interaction pour ShowProduct.xaml
    /// </summary>
    public partial class ShowProduct : Window
    {
        public ShowProduct(string email, string password)
        {
            InitializeComponent();
            Database database = new Database();
            var connectionString = database.dbConnect(email, password);
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand("SELECT * FROM products;", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            Product.DataContext = dt;
        }
        public void addProduct()
        {
            DateTime DateTime = DateTime.Now;
            var date = DateTime.ToString("dd/MM/yyyy");
            var name = name_txt.Text;
            var price = price_txt.Text;
            var quantity = quantity_txt.Text;
            var description = description_txt.Text;
            Database database = new Database();
            var connectionString = database.dbConnect("root", "");
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand("INSERT INTO products(ProductName, Price, Quantity, Publishers, CategoryId, CreationDate, Description) VALUES('" + name + "', '" + price + "', '" + quantity + "', 'Melyssa Miller', '80416', '" + date + "', '" + description + "')", connection);

            connection.Open();
            command.ExecuteNonQuery();
            ShowProduct newWindow = new ShowProduct("root", "");
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            connection.Close();
            MessageBox.Show("Successfull Added");
        }



        public void updateProduct(string id)
        {
            Database database = new Database();
            DateTime DateTime = DateTime.Now;
            var name = name_txt.Text;
            var price = price_txt.Text;
            var quantity = quantity_txt.Text;
            var description = description_txt.Text;
            var connectionString = database.dbConnect("root", "");
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("UPDATE products SET ProductName ='" + name + "' , Price ='" + price + "', Quantity = '" + quantity + "', description = '" + description + "' Where ProductId = '" + id + "'", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            ShowProduct newWindow = new ShowProduct("root", "");
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            connection.Close();
            MessageBox.Show("Successfull Updated");
        }

        public void selectProductById(string id)
        {
            Database database = new Database();
            var connectionString = database.dbConnect("root", "");
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand("SELECT * FROM products Where ProductId = '" + id + "';", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            Product.DataContext = dt;

            MessageBox.Show("Successfull selected");
        }

        public void deleteProductById(string id)
        {
            Database database = new Database();
            var connectionString = database.dbConnect("root", "");
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand("DELETE FROM products Where ProductId = '" + id + "';", connection);
            connection.Open();
            command.ExecuteNonQuery();
            View.ShowProduct newWindow = new ShowProduct("root", "");
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            connection.Close();
            MessageBox.Show("Successfull deleted");


        }

        public bool is_Valid()
        {
            if (name_txt.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (quantity_txt.Text == string.Empty)
            {
                MessageBox.Show("Quantity is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (price_txt.Text == string.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (is_Valid())
            {
                addProduct();
            }
        }




        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
                var id = search_txt.Text;
                deleteProductById(id);
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (search_txt.Text == string.Empty)
            {
                MessageBox.Show("Id is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (is_Valid())
            {
                var id = search_txt.Text;
                updateProduct(id);
            }

        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            var id = search_txt.Text;
            selectProductById(id);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
