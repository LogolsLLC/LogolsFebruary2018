using Assessment.Entities;
using System.Collections.Generic;

namespace Assessment.Entities.DataInterface
{
    public interface IQuestionRepository
    {
        void Insert(Question question);

        void Delete(int questionID);

        void Update(Question question);

        Question Get(int questionID);

        IEnumerable<Question> GetAll();

        IEnumerable<Answer> GetAnswers(int questionID);
    }
}