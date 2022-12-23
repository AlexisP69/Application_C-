using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace e_commerce.Model
{
    internal class Database
    {

        public dynamic dbConnect(string email, string password)
        {
            string connectionString = "SERVER=localhost;DATABASE=bdd_e-commerce;UID='" + email + "';PASSWORD='" + password + "';";
            //connection = new MySqlConnection(connectionString);
            return connectionString;

            //return connection;


        }
    }
}
