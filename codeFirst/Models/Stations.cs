using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirst.Models
{
    public class Stations
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public List<BusStation> BusStation { get; set; }

    }
}