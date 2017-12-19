using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace burcSitesii.Models
{
    public class BurcKutusu
    {
        public string adres { get; set; }
        public string ResimSRC { get; set; }
        public string BurcIsmi { get; set; }
        public string Aciklama { get; set; }
        public int fiyat { get; set; }
    }
}