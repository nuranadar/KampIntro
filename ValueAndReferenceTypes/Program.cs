using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // sayısal veri tipleri : int, decimal , float, double , boolean (true, False ) = Deger tip.
            // array, class , interface = referans tip.

            //bellekte stack ve heap diye 2 alan vardır.
            //deger tip olanlar stack'te tutulur
            //referans tip olanlar heap'te (pointer olarakta adlandırılır) tutulur.

            
            ////Ornek////
            

            int number1 = 10;   // sayi1'in degeri 10 diye okunur.
            int number2 = 30;   // sayi2'nin degeri 30 diye okunur.
            number1 = number2;  // sayi 1'in degeri eşittir sayi2'nin degeri.Sadece degeri aktarır. 
            // ve sayi1 ile sayi2'in bağlantısı kopar. daha sonradan sayi 2 ile ilgili yapılan değişiklikler 
            // sayi1'i etkilemez.
            number2 = 65;       //sayi2'nin degeri bu değiştirilsede eşitleme işlemi daha önce yapıldığından 
            //sayi1'i etkilemez.
            //***//
            //***//
            //number1 kaçtır?
            //cevap : 30

            int[] numbers1 = new int[] { 10, 20, 30 }; 
            // numbers1 stack'te numbers1 diye değişken oluşur.new denildiğinde belleğin heap kısmında 
            //number1 karşılığındaki sayıları tutar.
            int[] numbers2 = new int[] { 100, 200, 300 };
            // numbers2 stack'te numbers1 diye değişken oluşur.new denildiğinde belleğin heap kısmında 
            //number2 karşılığındaki sayıları tutar.
            number1 = number2; 
            // "sayılar 1'in referans numarası, sayılar 2'nin referans numarasına eşittir"diye okunur.
            numbers2[0] = 999;
            //numbers1[0] kaçtır.
            //cevap 999.

            //     Stack            Heap
            //  1/sayılar1        [10,20,30]
            //  2/sayılar2        [100,200,300]

            //sayılar 1 sayılar 2 ye eşitlendiğinde sayılar1 aynı şekilde kalıyor fakat heap'te tutmuş olduğu 
            //karşılığı sayılar 2'nin karşılığına eşitleniyor. dolayısı ile değişiklik daha sonrada yapılsa 
            // sayılar1 artık sayılar2' nin karşılığını tuttuğundan yapılan değişiklik sayılar 1'ide etkiliyor. 

            int yil;
            System.Console.Write("Hangi Yıldayız : ");
            yil = System.Console.Read();
            System.Console.WriteLine();
            System.Console.Write("Girdiğiniz Yıl :");
            System.Console.WriteLine(yil);




        }
    }
}
