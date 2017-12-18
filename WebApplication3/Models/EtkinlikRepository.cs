using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public static class EtkinlikRepository
    {
        public static List<Etkinlik> Etkinlikler { get; set; }

        public static List<Etkinlik> ListeyiDoldur()
        {
            Etkinlikler = new List<Etkinlik>();

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Sinema1",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Sinema,
                alttur="komedi"
            });

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Sinema2",
                BaslangicTarihi = DateTime.Now.AddDays(-10),
                BitisTarihi = DateTime.Now.AddDays(-5),
                EtkinlikTuru = EtkinlikTuru.Sinema,
                alttur = "dram"
            });
            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Sinema3",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Sinema,
                alttur = "aksiyon"
            });

            //Tiyatro
            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Tiyatro1",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Tiyatro
            });

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Tiyatro2",
                BaslangicTarihi = DateTime.Now.AddDays(2),
                BitisTarihi = DateTime.Now.AddDays(20),
                EtkinlikTuru = EtkinlikTuru.Tiyatro
            });
            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Tiyatro3",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Tiyatro
            });

            //Music
            Etkinlikler.Add(new Etkinlik
            {
                Adi = "music1",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Muzik
            });

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "music2",
                BaslangicTarihi = DateTime.Now.AddDays(2),
                BitisTarihi = DateTime.Now.AddDays(20),
                EtkinlikTuru = EtkinlikTuru.Muzik
            });
            Etkinlikler.Add(new Etkinlik
            {
                Adi = "music3",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Muzik
            });

            return Etkinlikler;
        }
    }
}