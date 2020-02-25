using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BWDatabase.Properties;
using Dapper;


namespace BWDatabase
{
    class Database
    {
        private readonly string _ConnectionString = Settings.Default.DbConnectionString;
        public MySqlConnection GetConnection => new MySqlConnection(_ConnectionString);

        public IEnumerable<dynamic> Test(long TestRange)
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT * from TestOne WHERE idTestOne = " + TestRange;
            var result = dbConnection.Query(sql);

            dbConnection.Close();
            return result;
        }
    }
}
