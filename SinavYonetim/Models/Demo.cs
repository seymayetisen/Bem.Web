using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinavYonetim.Models
{
    public class Demo
    {
        [Key]
        public int BirincilAnahtar { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}