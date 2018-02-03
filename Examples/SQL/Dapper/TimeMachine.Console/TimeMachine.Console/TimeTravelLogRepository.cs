namespace TimeMachine.Console
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Dapper;

    public class TimeTravelLogRepository : Repository
    {
        public IEnumerable<TimeTravelLog> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<TimeTravelLog>(
                    "select ttl.TimeTravelLogId, ttl.TravelToYear, ttl.TravelDate, tt.FirstName, tt.LastName "
                    + "from timetravellog ttl "
                    + "inner join timetraveler tt "
	                + "on ttl.TimeTravelerId = tt.TimeTravelerId;"
                    , commandType: CommandType.Text);
            }
        }
    }
}
