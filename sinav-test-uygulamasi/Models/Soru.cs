using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sinav_test_uygulamasi.Models
{
    public class Soru
    {
        public int Sira { get; set; }
        public string Metin { get; set; }
        public int DogruCevap { get; set; }
        public int Puan { get; set; }
        public Sinav Sinav { get; set; }
        public List<string> Secenekler { get; set; }
    }
}