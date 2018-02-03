using System;
using System.Collections.Generic;
using Assessment.Entities.DataInterface;

namespace Assessment.Entities
{
    public class StudentService
    {
        private IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public void Insert(Student student)
        {
            _repository.Insert(student);
        }

        public void Delete(Student student)
        {
            _repository.Delete(student);
        }

        public void Update(Student student)
        {
            _repository.Update(student);
        }

        public Student Get(int studentID)
        {
            return _repository.Get(studentID);
        }

        public IEnumerable<Student> GetAll()
        {
            return _repository.GetAll();
        }
    }
}