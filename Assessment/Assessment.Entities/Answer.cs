using System;

namespace Assessment.Entities
{
    public class Answer
    {
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
