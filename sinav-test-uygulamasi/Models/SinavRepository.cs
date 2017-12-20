using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sinav_test_uygulamasi.Models
{
    public  class SinavRepository
    {
        private static Dictionary<string, Sinav> SinavGetir()
        {
            Dictionary<string, Sinav> sinavlar = new Dictionary<string, Sinav>();

            sinavlar.Add("deneme-sinavi-1",Sinav1());
            sinavlar.Add("deneme-sinavi-2", Sinav2());

            return sinavlar;
        }

        private static Sinav Sinav1()
        {
            var sinav = new Sinav
            {
                Baslik = "Deneme Sınavı",
                Aciklama = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eu mattis lorem, ac iaculis elit. Nam et facilisis arcu. Suspendisse mollis quam quam, ac scelerisque urna viverra at. In eget consectetur lectus, sit amet consectetur orci. Fusce ullamcorper imperdiet quam iaculis hendrerit. Morbi ultricies facilisis purus, eget venenatis dui varius ut. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed dictum convallis ligula, non iaculis lacus fringilla id.",
                Sure = 10,
                Sorular = new List<Soru>()
            };

            sinav.Sorular.Add(new Soru
            {
                Metin = "Dünya düz müdür?",
                Secenekler = new List<string> { "Evet", "Hayır" },
                DogruCevap = 0,
                Puan = 10,
                Sira = 1
            });

            sinav.Sorular.Add(new Soru
            {
                Metin = "Ay dünyanın uydusu mudur?",
                Secenekler = new List<string> { "Evet", "Hayır" },
                DogruCevap = 0,
                Puan = 10,
                Sira = 1
            });

            sinav.Sorular.Add(new Soru
            {
                Metin = "Javascript en iyi programlama dilidir?",
                Secenekler = new List<string> { "Evet", "Hayır" },
                DogruCevap = 1,
                Puan = 10,
                Sira = 1
            });

            return sinav;
        }

        private static Sinav Sinav2()
        {
            var sinav = new Sinav
            {
                Baslik = "Deneme Sınavı 2",
                Aciklama = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eu mattis lorem, ac iaculis elit. Nam et facilisis arcu. Suspendisse mollis quam quam, ac scelerisque urna viverra at. In eget consectetur lectus, sit amet consectetur orci.",
                Sure = 10,
                Sorular = new List<Soru>()
            };

            sinav.Sorular.Add(new Soru
            {
                Metin = "Dünya düz müdür?",
                Secenekler = new List<string> { "Evet", "Hayır" },
                DogruCevap = 0,
                Puan = 10,
                Sira = 1
            });

            sinav.Sorular.Add(new Soru
            {
                Metin = "Ay dünyanın uydusu mudur?",
                Secenekler = new List<string> { "Evet", "Hayır" },
                DogruCevap = 0,
                Puan = 10,
                Sira = 1
            });

            sinav.Sorular.Add(new Soru
            {
                Metin = "Javascript en iyi programlama dilidir?",
                Secenekler = new List<string> { "Evet", "Hayır" },
                DogruCevap = 1,
                Puan = 10,
                Sira = 1
            });

            return sinav;
        }


        public static Sinav SinavBul(string key)
        {
            return SinavGetir()[key];
        }
    }
}