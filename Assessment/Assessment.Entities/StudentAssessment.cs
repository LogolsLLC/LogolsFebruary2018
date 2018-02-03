using System;

namespace Assessment.Entities
{
    public class StudentAssessment
    {
        public int StudentAssessmentID { get; set; }
        public int StudentID { get; set; }
        public int AssessmentID { get; set; }
        public decimal Score { get; set; }
        public DateTime AssessmentDate { get; set; }
    }
}