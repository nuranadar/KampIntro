using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Nuran";
            customer1.Lastname = "Adar";
            customer1.Age = 35;
            customer1.BirthPlace = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Name = "İrem";
            customer2.Lastname = "Ülgez";
            customer2.Age = 31;
            customer2.BirthPlace = "Adana";

            Customer customer3 = new Customer();
            customer3.Name = "Ümit";
            customer3.Lastname = "Sayım";
            customer3.Age = 34;
            customer3.BirthPlace = "Kastamonu";

            Customer[] customers = new Customer[] {customer1,customer2,customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            Console.WriteLine("**********");
            customerManager.Delete(customer2);
            Console.WriteLine("**********");
            customerManager.CustomerListing(customers);



        }
    }
}
