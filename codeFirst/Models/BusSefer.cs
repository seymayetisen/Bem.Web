using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirst.Models
{
    public class BusSefer
    {
        public int Id { get; set; }
        public Buses Bus { get; set; }
        public Seferler Sefer { get; set; }

    }
}