using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string kurs1 = "Yazılımcı yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç kursu";
            string kurs3 = "Java kursu";
            string kurs4 = "Python";
            string kurs5 = "c++";

            string[] kurslar = new string[] { "Yazılımcı yetiştirme kampı",
            "Programlamaya başlangıç kursu","Java kursu","Python","c++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}
