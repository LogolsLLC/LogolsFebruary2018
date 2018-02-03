using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Assessment.Entities.DataInterface;
using Dapper;

namespace Assessment.DAL
{
    public class SubjectRepository : Repository, ISubjectRepository
    {
        public void Insert(Subject subject)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Insert into Subject (Name, Description) values (@Name, @Description)"
                    , new { Name = subject.Name, Description = subject.Description }
                    , commandType: CommandType.Text);
            }
        }

        public void Delete(int subjectID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Delete From Subject Where SubjectId = @SubjectId"
                    , new { SubjectId = subjectID }
                    , commandType: CommandType.Text);
            }
        }

        public void Update(Subject subject)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Update Subject Set Name = @Name, Description = @Description Where SubjectId = @SubjectId" 
                    , subject
                    , commandType: CommandType.Text);
            }
        }

        public Subject Get(int subjectID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Subject>(
                    "Select SubjectId, Name, Description From Subject Where SubjectId = @SubjectId"
                    , new { SubjectId = subjectID }
                    , commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public IEnumerable<Subject> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Subject>(
                    "Select SubjectId, Name, Description From Subject"
                    , commandType: CommandType.Text);
            }
        }
    }
}