using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class MusteriManager
    {
        public void MusteriEkle(List<Musteri> musterilistesi, Musteri musteri)
        {
            Console.WriteLine("Müşteri eklenmiştir" + musteri.MusteriAdi+ musteri.MusteriSoyadi);
            musterilistesi.Add(musteri);

        }

        public void MusteriListele(List<Musteri> musterilistesi)
        {
            
            foreach (var musteri in musterilistesi)
            {
                Console.WriteLine("Müşteriler:" + musteri.ID + musteri.MusteriAdi + musteri.MusteriSoyadi + musteri.MusteriYasi);
            }
        }
        public void MusteriSil(List<Musteri> musterilistesi, Musteri musteri)
        {
            Console.WriteLine("Musteri silinmiştir" + musteri.MusteriAdi + musteri.MusteriSoyadi);
            musterilistesi.Remove(musteri);
        }
    }
    
}
