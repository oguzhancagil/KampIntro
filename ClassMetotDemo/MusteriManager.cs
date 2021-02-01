using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void List(string Adi, int MusteriNo, int TcNo)
        {
            Console.WriteLine(Adi + " " + MusteriNo + " " + TcNo);
        }
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
        }

    }
}
