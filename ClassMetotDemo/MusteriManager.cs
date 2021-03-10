using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Listele(Musteri[] musteri)
        {
            foreach (var i in musteri)
            {
                Console.WriteLine(i.Ad + " " + i.Soyad);
                
            }
            
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi : " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
