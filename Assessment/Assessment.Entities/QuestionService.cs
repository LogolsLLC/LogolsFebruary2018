using System;
using System.Collections.Generic;
using Assessment.Entities.DataInterface;

namespace Assessment.Entities
{
    public class QuestionService
    {
        private IQuestionRepository _repository;

        public QuestionService(IQuestionRepository repository)
        {
            _repository = repository;
        }

        public void Insert(Question question)
        {
            _repository.Insert(question);
        }

        public void Delete(int questionID)
        {
            _repository.Delete(questionID);
        }

        public void Update(Question question)
        {
            _repository.Update(question);
        }

        public Question Get(int questionID)
        {
            return _repository.Get(questionID);
        }

        public IEnumerable<Question> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Answer> GetAnswers(int questionID)
        {
            return _repository.GetAnswers(questionID);
        }
    }
}