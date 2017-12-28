using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinavYonetim.Models
{
    [Table("Sinav")]
    public class Exam
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Column("Baslik")]
        public string Title { get; set; }

        [Column ("Aciklama", TypeName ="varchar")]
        [MaxLength(50)]
        public string Description { get; set; }
        public int? Duration { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<Question> Questions { get; set; }
        public List<PersonsExam> PersonExam { get; set; }

    }
    
}