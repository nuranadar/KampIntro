using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Phyton";
            kurs2.KursunEgitmeni = "Berkay Bilgin";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursunEgitmeni = "Kerem Varış";
            kurs3.IzlenmeOrani = 64;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursunEgitmeni = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                //Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni + " : " + kurs.IzlenmeOrani);
                Console.WriteLine(kurs.KursAdi + "\n" + kurs.KursunEgitmeni + "\n" + kurs.IzlenmeOrani + "\n");
            }
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
