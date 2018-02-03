using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Assessment.Entities.DataInterface;
using Dapper;

namespace Assessment.DAL
{
    public class AnswerRepository : Repository, IAnswerRepository
    {
        public void Insert(Answer answer)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Insert into Answer (QuestionId, Text, IsCorrect) " +
                    "Values (@QuestionId, @Text, @IsCorrect)"
                    , new { QuestionID = answer.QuestionID, Text = answer.Text, IsCorrect = answer.IsCorrect }
                    , commandType: CommandType.Text);
            }
        }

        public void Delete(int answerID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Delete from Answer Where AnswerId = @AnswerId"
                    , new { AnswerID = answerID }, commandType: CommandType.Text);
            }
        }

        public void Update(Answer answer)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Update Answer Set " + 
                    "Text = @Text, IsCorrect = @IsCorrect " +
                    "Where AnswerId = @AnswerId"
                    , new { AnswerId = answer.AnswerID, Text = answer.Text, IsCorrect = answer.IsCorrect }
                    , commandType: CommandType.Text);
            }
        }

        public Answer Get(int answerID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Answer>(
                    "Select AnswerId, QuestionId, Text, IsCorrect From Answer Where AnswerId = @AnswerId"
                    , new { AnswerId = answerID }
                    , commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public IEnumerable<Answer> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Answer>(
                    "Select AnswerId, QuestionId, Text, IsCorrect From Answer"
                    , commandType: CommandType.Text);
            }
        }
    }
}