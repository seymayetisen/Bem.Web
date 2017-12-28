using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinavYonetim.Models
{
    public class Option
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        //[InverseProperty("Options")]
        public Question ParentQuestion { get; set; }
        //[InverseProperty("CorrectAnswer")]
        public Question Question { get; set; }
    }
}