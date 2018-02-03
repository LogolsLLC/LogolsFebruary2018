using Assessment.Entities;
using System.Collections.Generic;

namespace Assessment.Entities.DataInterface
{
    public interface IAssessmentRepository
    {
        void Insert(Assessment assessment);

        void Delete(int assessmentID);

        void Update(Assessment assessment);

        Assessment Get(int assessmentID);

        IEnumerable<Assessment> GetAll();

        IEnumerable<Question> GetQuestions(int assessmentID);

        IEnumerable<Answer> GetAnswers(int assessmentID);
    }
}