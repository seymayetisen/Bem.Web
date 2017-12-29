using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirst.Models
{
    public class Seferler
    {
        public int Id { get; set; }
        public DateTime SeferTarihi { get; set; }
        public List<BusSefer> BusSefer { get; set; }
    }
}