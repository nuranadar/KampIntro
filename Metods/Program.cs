using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Elma";
            double fee = 15;
            string information = "Amasya elması";



            Product product1 = new Product();            
            product1.Name = "Apple";
            product1.Fee = 15;
            product1.Information = "Amasya";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Fee = 80;
            product2.Information = "Diyarbakır";

            Product product3 = new Product();
            product3.Name = "Orange";
            product3.Fee = 15;
            product3.Information = "Washington";

            Product[] products = new Product[] {product1,product2,product3};

            //Type safe - Tip Güvenli
           
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Information);
                Console.WriteLine(product.Fee);
                Console.WriteLine("___________");
            }


            Console.WriteLine("-----------Metods------------");

            //instance - örnek
            //Encapsulation

            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);
            cartManager.Add(product3);

            //yanlıs kullanıma ornek cartManager.Add2(kendini tekrarlamak zorunda kalıyorsun)

            cartManager.Add2("Apple", "Green Apple", 12,15);
            cartManager.Add2("Watermelon", "Diyarbakır",42,8);
            cartManager.Add2("Orange", "Washington", 18,35);

        }
    }
}


// Do Not Repeat Yourself - DRY / Clean Code - Temiz Kod Yazma Teknikleri (Best Practice)
