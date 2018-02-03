using Assessment.Entities;
using System.Collections.Generic;

namespace Assessment.Entities.DataInterface
{
    public interface IStudentAssessmentRepository
    {
        void Insert(StudentAssessment studentAssessment);

        void Delete(StudentAssessment studentAssessment);

        void Update(StudentAssessment studentAssessment);

        StudentAssessment Get(int studentAssessmentID);

        IEnumerable<StudentAssessment> GetAll();
    }
}