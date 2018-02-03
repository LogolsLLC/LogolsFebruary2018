using System;
using System.Collections.Generic;
using Assessment.Entities.DataInterface;

namespace Assessment.Entities
{
    public class StudentAssessmentService
    {
        private IStudentAssessmentRepository _repository;

        public StudentAssessmentService(IStudentAssessmentRepository repository)
        {
            _repository = repository;
        }

        public void Insert(StudentAssessment studentAssessment)
        {
            _repository.Insert(studentAssessment);
        }

        public void Delete(StudentAssessment studentAssessment)
        {
            _repository.Delete(studentAssessment);
        }

        public void Update(StudentAssessment studentAssessment)
        {
            _repository.Update(studentAssessment);
        }

        public StudentAssessment Get(int studentAssessmentID)
        {
            return _repository.Get(studentAssessmentID);
        }

        public IEnumerable<StudentAssessment> GetAll()
        {
            return _repository.GetAll();
        }
    }
}