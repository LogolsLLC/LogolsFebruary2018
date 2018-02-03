using System;
using System.Collections.Generic;
using Assessment.Entities.DataInterface;

namespace Assessment.Entities
{
    public class SubjectService
    {
        private ISubjectRepository _repository;

        public SubjectService(ISubjectRepository repository)
        {
            _repository = repository;
        }

        public void Insert(Subject subject)
        {
            _repository.Insert(subject);
        }

        public void Delete(int subjectID)
        {
            _repository.Delete(subjectID);
        }

        public void Update(Subject subject)
        {
            _repository.Update(subject);
        }

        public Subject Get(int subjectID)
        {
            return _repository.Get(subjectID);
        }

        public IEnumerable<Subject> GetAll()
        {
            return _repository.GetAll();
        }
    }
}