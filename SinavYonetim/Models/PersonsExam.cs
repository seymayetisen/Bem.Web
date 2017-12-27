using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinavYonetim.Models
{
    public class PersonsExam
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public Exam Exam { get; set; }
        public PersonsExamStatus Status { get; set; }
        public int Duration { get; set; }
        public List<Answer> Answers { get; set; }
    }
}