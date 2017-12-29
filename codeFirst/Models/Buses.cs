using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirst.Models
{
    public class Buses
    {
        public int Id { get; set; }
        public string BusName { get; set; }
        public List<BusSefer> BusSefer { get; set; }
        public List<BusStation> BusStation { get; set; }

    }
}