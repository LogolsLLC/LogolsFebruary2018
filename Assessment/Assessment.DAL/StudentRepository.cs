using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Assessment.Entities.DataInterface;
using Dapper;

namespace Assessment.DAL
{
    public class StudentRepository : Repository, IStudentRepository
    {
        public void Insert(Student student)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Insert into Student (FirstName, LastName) " +
                    "values (@FirstName, @LastName)"
                    , new { FirstName = student.FirstName, LastName = student.LastName }
                    , commandType: CommandType.Text);
            }
        }

        public void Delete(Student student)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Delete from Student Where StudentId = @StudentId"
                    , new { StudentId = student.StudentID }
                    , commandType: CommandType.Text);
            }
        }

        public void Update(Student student)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Update Student set FirstName = @FirstName" +
                    ", LastName = @LastName Where StudentId = @StudentId"
                    , new { StudentId = student.StudentID, FirstName = student.FirstName, LastName = student.LastName }
                    , commandType: CommandType.Text);
            }
        }

        public Student Get(int studentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Student>(
                    "Select StudentId, FirstName, LastName " +
                    "From Student Where StudentId = @StudentId"
                    , new { StudentID = studentID }
                    , commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public IEnumerable<Student> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Student>(
                    "Select StudentId, FirstName, LastName From Student"
                    , commandType: CommandType.Text);
            }
        }
    }
}