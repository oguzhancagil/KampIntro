using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Oğuzhan";
            musteri1.MusteriNo = 101;
            musteri1.TcNo = 123456789;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Şeyhmus";
            musteri2.MusteriNo = 102;
            musteri2.TcNo = 12345678;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Yağız";
            musteri3.MusteriNo = 103;
            musteri3.TcNo = 1234567;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.MusteriNo);
                Console.WriteLine(musteri.TcNo);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.List(musteri1.Adi, musteri1.MusteriNo, musteri1.TcNo);
            musteriManager.List(musteri2.Adi, musteri2.MusteriNo, musteri2.TcNo);
            musteriManager.List(musteri3.Adi, musteri3.MusteriNo, musteri3.TcNo);

            Console.WriteLine(musteriManager);
        }
    }
}
