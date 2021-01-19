using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "C#";
            string kurs5 = "Phyton";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            Console.WriteLine("____Bitti____");

            // Array = Dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
                "Programlamaya başlangıç için temel kurs", "Java","C#","Phyton","Nuran" };

            // for döngüsü
            

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("____For_Bitti____");

            
            
            // foreach döngüsü
            // genellikle dizileri kolay dönmek için kullanılır
            // Phytondaki for yapısı

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("_____Foreach_Bitti_____");

            for (int i = 2; i <= 10; i=i+2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("********");

            for (int i = 2; i <= 15; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
