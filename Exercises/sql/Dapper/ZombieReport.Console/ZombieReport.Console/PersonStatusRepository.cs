namespace ZombieReport.Console
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Dapper;

    public class PersonStatusRepository : Repository
    {
        public IEnumerable<PersonStatus> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<PersonStatus>(
                    "select p.PersonId, p.FirstName, p.LastName, ps.PersonStatusId, ps.StatusDescription"
                    + " from Person p"
                    + " inner join PersonStatus ps"
	                + " on p.PersonStatusId = ps.PersonStatusId;"
                    , commandType: CommandType.Text);
            }
        }
    }
}
