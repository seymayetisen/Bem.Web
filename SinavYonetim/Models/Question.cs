using System.Collections.Generic;

namespace SinavYonetim.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Exam Exam { get; set; }
        public Option CorrectAnswer { get; set; }
        public List<Option> Options { get; set; }
    }
}