namespace ZombieReport.WebAPI
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    public class PersonStatus
    {
        public int PersonId { get; set; }
        public int PersonStatusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}