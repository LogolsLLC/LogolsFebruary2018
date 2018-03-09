namespace ZombieReport.WebAPI
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
                    "select PersonId, FirstName, LastName, PersonStatusId"
                    + " from Person;"
                    , commandType: CommandType.Text);
            }
        }

        public PersonStatus Get(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<PersonStatus>(
                    "select PersonId, FirstName, LastName, PersonStatusId "
                    + "from Person "
                    + "where PersonId = @PersonId;"
                    ,new {PersonId = id} ,commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "delete "
                    + "from Person "
                    + "where PersonId = @PersonId;"
                    ,new {PersonId = id} ,commandType: CommandType.Text);
            }
        }

        public void Update(PersonStatus personStatus)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "update Person "
                    + "set FirstName = @FirstName, LastName = @LastName, PersonStatusId = @PersonStatusId "
                    + "where PersonId = @PersonId;"
                    ,new {
                        PersonId = personStatus.PersonId, 
                        FirstName = personStatus.FirstName,
                        LastName = personStatus.LastName,
                        PersonStatusId = personStatus.PersonStatusId
                    } 
                    ,commandType: CommandType.Text);
            }
        }

        public void Insert(PersonStatus personStatus)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "insert into Person(FirstName, LastName, PersonStatusId) "
                    + "values(@FirstName, @LastName, @PersonStatusId);"
                    ,new { 
                        FirstName = personStatus.FirstName,
                        LastName = personStatus.LastName,
                        PersonStatusId = personStatus.PersonStatusId
                    } 
                    ,commandType: CommandType.Text);
            }
        }
    }
}