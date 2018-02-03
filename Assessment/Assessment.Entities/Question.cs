using System;

namespace Assessment.Entities
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int AssessmentID { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}