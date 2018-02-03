using Assessment.Entities;
using System.Collections.Generic;

namespace Assessment.Entities.DataInterface
{
    public interface IAnswerRepository
    {
        void Insert(Answer answer);

        void Delete(int answerID);

        void Update(Answer answer);

        Answer Get(int answerID);

        IEnumerable<Answer> GetAll();
    }
}