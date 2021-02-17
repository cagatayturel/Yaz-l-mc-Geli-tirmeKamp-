using System;
using System.Collections.Generic;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 45852125;
            musteri1.MusteriAdi = "Orhan";
            musteri1.MusteriSoyadi = "Ertuğral";
            musteri1.MusteriYasi = 26;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 833129894;
            musteri2.MusteriAdi = "Gokcen";
            musteri2.MusteriSoyadi = "Hosman";
            musteri2.MusteriYasi = 28;

            Musteri musteri3 = new Musteri();
            musteri3.ID = 63321458;
            musteri3.MusteriAdi = "Kemal Caglar";
            musteri3.MusteriSoyadi = "Guler";
            musteri3.MusteriYasi = 24;

            List<Musteri> musteriListesi = new List<Musteri>();
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteriListesi, musteri1);
            musteriManager.MusteriEkle(musteriListesi, musteri2);
            musteriManager.MusteriEkle(musteriListesi, musteri3);

            musteriManager.MusteriListele(musteriListesi);
           
            musteriManager.MusteriSil(musteriListesi, musteri1);
            musteriManager.MusteriSil(musteriListesi, musteri3);

            musteriManager.MusteriListele(musteriListesi);
        }







    }
    }

