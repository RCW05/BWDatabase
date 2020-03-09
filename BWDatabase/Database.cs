using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BWDatabase.Properties;


namespace BWDatabase
{
    class Database
    {
        private readonly string _ConnectionString = Settings.Default.DbConnectionString;
        public MySqlConnection GetConnection => new MySqlConnection(_ConnectionString);

    }
}
