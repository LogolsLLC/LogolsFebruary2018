using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Assessment.Entities.DataInterface;
using Dapper;

namespace Assessment.DAL
{
    public class StudentAssessmentRepository : Repository, IStudentAssessmentRepository
    {
        public void Insert(StudentAssessment studentAssessment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Insert into StudentAssessment (StudentID, AssessmentID, Score, AssessmentDate) values (@StudentID, @AssessmentID, @Score, @AssessmentDate)"
                    , new { StudentID = studentAssessment.StudentID
                        , AssessmentID = studentAssessment.AssessmentID
                        , Score = studentAssessment.Score
                        , AssessmentDate = studentAssessment.AssessmentDate }
                    , commandType: CommandType.Text);
            }
        }

        public void Delete(StudentAssessment studentAssessment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Delete From StudentAssessment Where StudentAssessmentId = @StudentAssessmentId"
                    , new { StudentAssessmentId = studentAssessment.StudentAssessmentID }
                    , commandType: CommandType.Text);
            }
        }

        public void Update(StudentAssessment studentAssessment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Update StudentAssessment Set " + 
                    "StudentID = @StudentID, AssessmentID = @AssessmentID, Score = @Score, AssessmentDate = @AssessmentDate" + 
                    "Where StudentAssessmentId = @StudentAssessmentId"
                    , studentAssessment
                    , commandType: CommandType.Text);
            }
        }

        public StudentAssessment Get(int studentAssessmentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<StudentAssessment>(
                    "Select StudentAssessmentID, StudentID, AssessmentID, Score, AssessmentDate" + 
                    "From StudentAssessment Where StudentAssessmentId = @StudentAssessmentId"
                    , new { StudentAssessmentID = studentAssessmentID }
                    , commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public IEnumerable<StudentAssessment> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<StudentAssessment>(
                    "Select StudentAssessmentID, StudentID, AssessmentID, Score, AssessmentDate" + 
                    "From StudentAssessment"
                    , commandType: CommandType.Text);
            }
        }
    }
}