using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirst.Models
{
    public class BusStation
    {
        public int Id { get; set; }
        public Stations station { get; set; }
        public Buses Bus { get; set; }
    }
}