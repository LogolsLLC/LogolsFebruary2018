using Assessment.Entities;
using System.Collections.Generic;

namespace Assessment.Entities.DataInterface
{
    public interface ISubjectRepository
    {
        void Insert(Subject subject);

        void Delete(int subjectID);

        void Update(Subject subject);

        Subject Get(int subjectID);

        IEnumerable<Subject> GetAll();
    }
}