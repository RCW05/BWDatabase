using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BWDatabase.Properties;
using Dapper;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.CodeDom.Compiler;
using System;

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
                      " Notes FROM Customer WHERE FullName = '" + FullName + "' ORDER BY FullName ASC;";

            var result = dbConnection.Query(sql);

            dbConnection.Close();
            return result;
        }
        public IEnumerable<dynamic> GetCount()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT COUNT(*) From Customer;";
            var result = dbConnection.Query(sql);

            dbConnection.Close();
            return result;
        }

        public void SaveEntry(int Count, string Title, string FulName,
                              string Telep, string AddTelep, string Mob, string Email, string FullAdd,
                              string PostCode, string Area, string Facebook,
                              string Language, string Notes)
        {
            var dbConnection = new Database().GetConnection;

            var sql = "INSERT INTO Customer (CustomerNumber, Title, FullName, Telephone, AddTelephone, Mobile, Email, FullAddress, Postcode, Area, Facebook, Language, Notes)" +
                " VALUES(" + Count + ",'" + Title + "','" + FulName + "'," + Telep + "," + AddTelep + "," + Mob + ",'" + Email + "','" +
                      FullAdd + "','" + PostCode + "','" + Area + "','" + Facebook + "','" + Language + "','" + Notes + "'" + ");";

            dbConnection.Execute(sql);
            dbConnection.Close();
        }

    }
}
