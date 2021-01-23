using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Nuran", LastName = "Adar", City = "Istanbul" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Michael";
            customer3.LastName = "Adar";
            customer3.City = "İstanbul";

            Customer customer2 = new Customer(2,"Romina","Adar","Istanbul");

            Console.WriteLine(customer2.FirstName);

            

        }

        
    }

    class Customer 
    {
        //default constructors
        // bu işlem sıklıkla yapılır

        public Customer()
        {
           
        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }

    }
}
