using System;
using System.Collections.Generic;
using Assessment.Entities.DataInterface;

namespace Assessment.Entities
{
    public class AnswerService
    {
        private IAnswerRepository _repository;

        public AnswerService(IAnswerRepository repository)
        {
            _repository = repository;
        }

        public void Insert(Answer answer)
        {
            _repository.Insert(answer);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Update(Answer answer)
        {
            _repository.Update(answer);
        }

        public Answer Get(int answerID)
        {
            return _repository.Get(answerID);
        }

        public IEnumerable<Answer> GetAll()
        {
            return _repository.GetAll();
        }
    }
}