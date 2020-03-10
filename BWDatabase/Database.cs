using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BWDatabase.Properties;
using Dapper;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace BWDatabase
{
    public class Database
    {
        private readonly string _ConnectionString = Settings.Default.DbConnectionString;
        public MySqlConnection GetConnection => new MySqlConnection(_ConnectionString);

        public IEnumerable<dynamic> GetCustomerList()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT FullName from Customer ORDER BY FullName ASC;";
            var result = dbConnection.Query(sql);

            dbConnection.Close();
            return result;
        }

        public IEnumerable<dynamic> GetCustomerDetails(string FullName)
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT CustomerNumber, Title, FullName, Telephone, AddTelephone," +
                      " Mobile, Email, FullAddress, Postcode, Area, Facebook, Language," +
                      " Notes from Customer WHERE FullName = '" + FullName + "' ORDER BY FullName ASC;";

            var result = dbConnection.Query(sql);

            dbConnection.Close();
            return result;
        }

    }
}
