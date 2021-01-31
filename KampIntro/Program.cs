using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety
            //do not repeat yourself

            string kategoriEtiketi = "Kategoriler ";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar azalmıştır");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar artmıştır");
            }
            else
            {
                Console.WriteLine("Dolar değişmedi");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
