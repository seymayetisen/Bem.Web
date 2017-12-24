using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace sinav_test_uygulamasi.Models
{
    public  class SinavRepository
    {
        private static Dictionary<string, Sinav> SinavGetir()
        {
            Dictionary<string, Sinav> sinavlar = new Dictionary<string, Sinav>();

            sinavlar.Add("deneme-sinavi-1",Sinav1("deneme-sinavi-1"));
            sinavlar.Add("deneme-sinavi-2", Sinav2("deneme-sinavi-2"));

            return sinavlar;
        }
        private static string connStr = "Data Source=DESKTOP-SON6OA8;Initial Catalog=SinavUygulamasi;Integrated Security=True";

        private static SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(connStr);
            connection.Open();

            return connection;
        }
        private static Sinav Sinav1(string baslik)
        {
            Sinav sinav = new Sinav();
            sinav.Sorular = new List<Soru>();
            sinav.Sorular.Clear();

            using (SqlConnection conn = CreateConnection())
            {
                SqlCommand comm = new SqlCommand("select * from Sinav inner join SinavSorusu on sinav.id = SinavSorusu.sinavId inner join Soru on Soru.id = SinavSorusu.SoruId where Baslik=@baslik", conn);
                comm.Parameters.AddWithValue("@baslik", baslik);
                using (SqlDataReader result = comm.ExecuteReader())
                {
                    while (result.Read())
                    {
                        Soru soru = new Soru();
                        soru.Secenekler = new List<string>();

                        sinav.Baslik = $"{result["Baslik"].ToString()}";
                        sinav.Aciklama = $"{result["Aciklama"].ToString()}";
                        sinav.Sure = (int)result["Sure"];
                        soru.Metin = $"{result["Metin"].ToString()}";
                        soru.Puan = (int)result["Puan"];
                        soru.DogruCevap=(int)result["DogruCevap"];
                        soru.Sira = (int)result["Sira"];
                        foreach (var item in result["Secenekler"].ToString().Split('|'))
                        {
                            soru.Secenekler.Add(item);
                        }
                        
                        sinav.Sorular.Add(soru);

                    }
                }
            }
            return sinav;
            //var sinav = new Sinav
            //{
            //    Baslik = "Deneme Sınavı",
            //    Aciklama = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eu mattis lorem, ac iaculis elit. Nam et facilisis arcu. Suspendisse mollis quam quam, ac scelerisque urna viverra at. In eget consectetur lectus, sit amet consectetur orci. Fusce ullamcorper imperdiet quam iaculis hendrerit. Morbi ultricies facilisis purus, eget venenatis dui varius ut. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed dictum convallis ligula, non iaculis lacus fringilla id.",
            //    Sure = 10,
            //    Sorular = new List<Soru>()
            //};

            //sinav.Sorular.Add(new Soru
            //{
            //    Metin = "Dünya düz müdür?",
            //    Secenekler = new List<string> { "Evet", "Hayır" },
            //    DogruCevap = 0,
            //    Puan = 10,
            //    Sira = 1
            //});

            //sinav.Sorular.Add(new Soru
            //{
            //    Metin = "Ay dünyanın uydusu mudur?",
            //    Secenekler = new List<string> { "Evet", "Hayır" },
            //    DogruCevap = 0,
            //    Puan = 10,
            //    Sira = 1
            //});

            //sinav.Sorular.Add(new Soru
            //{
            //    Metin = "Javascript en iyi programlama dilidir?",
            //    Secenekler = new List<string> { "Evet", "Hayır" },
            //    DogruCevap = 1,
            //    Puan = 10,
            //    Sira = 1
            //});

            //return sinav;
        }

        private static Sinav Sinav2(string baslik)
        {
            Sinav sinav = new Sinav();
            sinav.Sorular = new List<Soru>();
            sinav.Sorular.Clear();

            using (SqlConnection conn = CreateConnection())
            {
                SqlCommand comm = new SqlCommand("select * from Sinav inner join SinavSorusu on sinav.id = SinavSorusu.sinavId inner join Soru on Soru.id = SinavSorusu.SoruId where Baslik=@baslik", conn);
                comm.Parameters.AddWithValue("@baslik", baslik);
                using (SqlDataReader result = comm.ExecuteReader())
                {
                    while (result.Read())
                    {
                        Soru soru = new Soru();
                        soru.Secenekler = new List<string>();

                        sinav.Baslik = $"{result["Baslik"].ToString()}";
                        sinav.Aciklama = $"{result["Aciklama"].ToString()}";
                        sinav.Sure = (int)result["Sure"];
                        soru.Metin = $"{result["Metin"].ToString()}";
                        soru.Puan = (int)result["Puan"];
                        soru.DogruCevap = (int)result["DogruCevap"];
                        soru.Sira = (int)result["Sira"];
                        foreach (var item in result["Secenekler"].ToString().Split('|'))
                        {
                            soru.Secenekler.Add(item);
                        }

                        sinav.Sorular.Add(soru);

                    }
                }
            }
            return sinav;
            //var sinav = new Sinav
            //{
            //    Baslik = "Deneme Sınavı 2",
            //    Aciklama = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eu mattis lorem, ac iaculis elit. Nam et facilisis arcu. Suspendisse mollis quam quam, ac scelerisque urna viverra at. In eget consectetur lectus, sit amet consectetur orci.",
            //    Sure = 10,
            //    Sorular = new List<Soru>()
            //};

            //sinav.Sorular.Add(new Soru
            //{
            //    Metin = "Dünya düz müdür?",
            //    Secenekler = new List<string> { "Evet", "Hayır" },
            //    DogruCevap = 0,
            //    Puan = 10,
            //    Sira = 1
            //});

            //sinav.Sorular.Add(new Soru
            //{
            //    Metin = "Ay dünyanın uydusu mudur?",
            //    Secenekler = new List<string> { "Evet", "Hayır" },
            //    DogruCevap = 0,
            //    Puan = 10,
            //    Sira = 1
            //});

            //sinav.Sorular.Add(new Soru
            //{
            //    Metin = "Javascript en iyi programlama dilidir?",
            //    Secenekler = new List<string> { "Evet", "Hayır" },
            //    DogruCevap = 1,
            //    Puan = 10,
            //    Sira = 1
            //});

            //return sinav;
        }


        public static Sinav SinavBul(string key)
        {
            return SinavGetir()[key];
        }
    }
}