using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Assessment.Entities.DataInterface;
using Dapper;

namespace Assessment.DAL
{
    public class QuestionRepository : Repository, IQuestionRepository
    {
        public void Insert(Question question)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Insert into Question (AssessmentId, Text, IsCorrect) " + 
                    "values (@AssessmentId, @Text, @IsCorrect)"
                    , new { AssessmentID = question.AssessmentID
                    , Text = question.Text
                    , IsCorrect = question.IsCorrect }
                    , commandType: CommandType.Text);
            }
        }

        public void Delete(int questionID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Delete From Question Where QuestionId = @QuestionId"
                    , new { QuestionID = questionID }
                    , commandType: CommandType.Text);
            }
        }

        public void Update(Question question)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Update Question Set " +
                    "AssessmentId = @AssessmentId, Text = @Text, IsCorrect = @IsCorrect " +
                    "Where QuestionId = @QuestionId"
                    , question
                    , commandType: CommandType.Text);
            }
        }

        public Question Get(int questionID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Question>(
                    "Select QuestionId, AssessmentId, Text, IsCorrect " + 
                    "From Question Where QuestionId = @QuestionId"
                    , new { QuestionID = questionID }
                    , commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public IEnumerable<Question> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Question>(
                    "Select QuestionId, AssessmentId, Text, IsCorrect " + 
                    "From Question"
                    , commandType: CommandType.Text);
            }
        }

        public IEnumerable<Answer> GetAnswers(int questionID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Answer>(
                    "Select AnswerId, QuestionId, Text, IsCorrect " +
                    "From Answer Where QuestionId = @QuestionId"
                    , new { QuestionID = questionID }
                    , commandType: CommandType.Text);
            }
        }
    }
}