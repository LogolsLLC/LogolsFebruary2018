using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Assessment.Entities.DataInterface;
using Dapper;

namespace Assessment.DAL
{
    public class AssessmentRepository : Repository, IAssessmentRepository
    {
        public void Insert(Assessment.Entities.Assessment assessment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Insert into Assessment (LevelNumber, SubjectId, Name) values (@LevelNumber, @SubjectId, @Name)"
                    , new { LevelNumber = assessment.LevelNumber, SubjectID = assessment.SubjectID, Name = assessment.Name }
                    , commandType: CommandType.Text);
            }
        }

        public void Delete(int assessmentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Delete From Assessment Where AssessmentId = @AssessmentId"
                    , new { AssessmentID = assessmentID }
                    , commandType: CommandType.Text);
            }
        }

        public void Update(Assessment.Entities.Assessment assessment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Update Assessment Set " + 
                    "LevelNumber = @LevelNumber, SubjectId = @SubjectId, Name = @Name" +
                    "Where AssessmentId = @AssessmentId"
                    , assessment
                    , commandType: CommandType.Text);
            }
        }

        public Assessment.Entities.Assessment Get(int assessmentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Assessment.Entities.Assessment>(
                    "Select AssessmentId, LevelNumber, SubjectId, Name From Assessment Where AssessmentId = @AssessmentId"
                    , new { AssessmentID = assessmentID }
                    , commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public IEnumerable<Assessment.Entities.Assessment> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Assessment.Entities.Assessment>(
                    "Select AssessmentId, LevelNumber, SubjectId, Name From Assessment"
                    , commandType: CommandType.Text);
            }
        }

        public IEnumerable<Question> GetQuestions(int assessmentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Question>(
                    "Select QuestionId, AssessmentId, Text, IsCorrect " + 
                    "From Question Where AssessmentId = @AssessmentId"
                    , new { AssessmentID = assessmentID }
                    , commandType: CommandType.Text);
            }
        }

        public IEnumerable<Answer> GetAnswers(int assessmentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Answer>(
                    "Select AnswerId, QuestionId, Text, IsCorrect " + 
                    "From Answer a " +
                    "Inner Join Question q on a.QuestionId = q.QuestionId " + 
                    "Where AssessmentId = @AssessmentId"
                    , new { AssessmentID = assessmentID }
                    , commandType: CommandType.Text);
            }
        }
    }
}