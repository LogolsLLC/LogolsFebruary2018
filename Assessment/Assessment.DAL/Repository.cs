using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Assessment.DAL
{
    public class Repository
    {
        private const string connectionStringv =@"server=localhost;port=3306;database=Assessment;user=[user];password=[password]";

        public IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(connectionString);
            }
        }
    }
}