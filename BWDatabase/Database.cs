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
        public IEnumerable<dynamic> GetCustomerNumber()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT CustomerNumber From Customer;";
            var result = dbConnection.Query(sql);

            dbConnection.Close();
            return result;
        }

        public void SaveEntry(int CustNum, string Title, string FullName,
                              string Telep, string AddTelep, string Mob, string Email, string FullAdd,
                              string PostCode, string Area, string Facebook,
                              string Language, string Notes)
        {
            var dbConnection = new Database().GetConnection;

            var sql = "INSERT INTO Customer (CustomerNumber, Title, FullName, Telephone, AddTelephone," + 
                "Mobile, Email, FullAddress, Postcode, Area, Facebook, Language, Notes)" +
                " VALUES(" + CustNum + ",'" + Title + "','" + FullName + "'," + Telep + "," + AddTelep + "," + Mob + ",'" + Email + "','" +
                      FullAdd + "','" + PostCode + "','" + Area + "','" + Facebook + "','" + Language + "','" + Notes + "'" + ");";

            dbConnection.Execute(sql);
            dbConnection.Close();
        }

        public void DeleteEntry(int CustNumber, string FullName)
        {
            var dbConnection = new Database().GetConnection;

            var sql = "DELETE FROM Customer WHERE CustomerNumber = '" + CustNumber + "' AND FullName = '" + FullName + "';";

            dbConnection.Execute(sql);
            dbConnection.Close();
        }
        public void EditEntry(int CustNumber, string Title, string FullName,
                              string Telep, string AddTelep, string Mob, string Email, string FullAdd,
                              string PostCode, string Area, string Facebook,
                              string Language, string Notes)
        {
            var dbConnection = new Database().GetConnection;

            var sql = "UPDATE Customer " +
                      "SET Title = '" + Title + "' , FullName = '" + FullName + "', Telephone = '" + Telep +
                      "' , AddTelephone = '" + AddTelep + "' , Mobile = '" + Mob + "' , Email = '" + Email +
                      "' , FullAddress = '" + FullAdd + "' , Postcode = '" + PostCode + "' , Area = '" + Area +
                      "' , Facebook = '" + Facebook + "' , Language = '" + Language + "' , Notes = '" + Notes + "'" +
                      " WHERE CustomerNumber = '" + CustNumber + "'; ";

            dbConnection.Execute(sql);
            dbConnection.Close();
        }

    }
}
