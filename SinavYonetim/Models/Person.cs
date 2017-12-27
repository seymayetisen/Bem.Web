using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinavYonetim.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string IdentityNumber { get; set; }
    }
}