using Assessment.Entities;
using System.Collections.Generic;

namespace Assessment.Entities.DataInterface
{
    public interface IStudentRepository
    {
        void Insert(Student student);

        void Delete(Student student);

        void Update(Student student);

        Student Get(int studentID);

        IEnumerable<Student> GetAll();
    }
}