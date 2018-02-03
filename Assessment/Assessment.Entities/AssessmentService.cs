using System;
using System.Collections.Generic;
using Assessment.Entities.DataInterface;

namespace Assessment.Entities
{
    public class AssessmentService
    {
        private IAssessmentRepository _repository;

        public AssessmentService(IAssessmentRepository repository)
        {
            _repository = repository;
        }

        public void Insert(Assessment assessment)
        {
            _repository.Insert(assessment);
        }

        public void Delete(int assessmentID)
        {
            _repository.Delete(assessmentID);
        }

        public void Update(Assessment assessment)
        {
            _repository.Update(assessment);
        }

        public Assessment Get(int assessmentID)
        {
            return _repository.Get(assessmentID);
        }

        public IEnumerable<Assessment> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Question> GetQuestions(int assessmentID)
        {
            return _repository.GetQuestions(assessmentID);
        }

        public IEnumerable<Answer> GetAnswers(int assessmentID)
        {
            return _repository.GetAnswers(assessmentID);
        }
    }
}