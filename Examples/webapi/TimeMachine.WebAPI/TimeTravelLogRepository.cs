namespace TimeMachine.WebAPI
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

        public TimeTravelLog Get(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<TimeTravelLog>(
                    "select ttl.TimeTravelLogId, ttl.TravelToYear, ttl.TravelDate, tt.FirstName, tt.LastName "
                    + "from timetravellog ttl "
                    + "inner join timetraveler tt "
	                + "on ttl.TimeTravelerId = tt.TimeTravelerId "
                    + "where ttl.TimeTravelLogId = @TimeTravelLogId;"
                    ,new {TimeTravelLogId = id} ,commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "delete "
                    + "from timetravellog "
                    + "where TimeTravelLogId = @TimeTravelLogId;"
                    ,new {TimeTravelLogId = id} ,commandType: CommandType.Text);
            }
        }

        public void Update(TimeTravelLog timeTravelLog)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "update timetravellog "
                    + "set TravelToYear = @TravelToYear, TravelDate = @TravelDate, TimeTravelerId = @TimeTravelerId "
                    + "where TimeTravelLogId = @TimeTravelLogId;"
                    ,new {
                        TimeTravelLogId = timeTravelLog.TimeTravelLogId, 
                        TravelToYear = timeTravelLog.TravelToYear,
                        TravelDate = timeTravelLog.TravelDate,
                        TimeTravelerId = timeTravelLog.TimeTravelerId
                    } 
                    ,commandType: CommandType.Text);
            }
        }

        public void Insert(TimeTravelLog timeTravelLog)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "insert into timetravellog(TravelToYear, TravelDate, TimeTravelerId) "
                    + "values(@TravelToYear, @TravelDate, @TimeTravelerId);"
                    ,new { 
                        TravelToYear = timeTravelLog.TravelToYear,
                        TravelDate = timeTravelLog.TravelDate,
                        TimeTravelerId = timeTravelLog.TimeTravelerId
                    } 
                    ,commandType: CommandType.Text);
            }
        }
    }
}
