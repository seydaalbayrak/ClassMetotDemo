using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Şeyda";
            musteri1.Soyad = "Albayrak";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Şule";
            musteri2.Soyad = "Albayrak";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            Console.WriteLine("---------------------------");
            musteriManager.Sil(musteri2);
            Console.WriteLine("---------------------------");
            musteriManager.Listele(musteriler);



        }
    }
}
