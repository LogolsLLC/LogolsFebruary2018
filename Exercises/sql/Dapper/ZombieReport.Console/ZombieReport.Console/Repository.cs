namespace ZombieReport.Console
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    public class Repository
    {
        private string connectionString = @"server=localhost;port=3306;database=Assessment;user=[user];password=[password]";
        public IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(connectionString);
            }
        }
    }
}
