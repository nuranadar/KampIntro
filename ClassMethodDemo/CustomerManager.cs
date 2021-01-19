using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine("The customer named " + customer.Name + " " + customer.Lastname + 
                " has been added to the list.");
        }
        public void Delete(Customer customer) 
        {
            Console.WriteLine("The customer named " + customer.Name + " " + customer.Lastname +
                " has been deleted from the list.");
        }
        public void CustomerListing(Customer[] customers)
        {


            foreach (var customer in customers)
            {
                                
                Console.WriteLine("Customer Name : " + customer.Name + "\n" + "Customer Lastname : "
                    + customer.Lastname + "\n" + "Customer Age : " + customer.Age + "\n" +
                    "Customer Birth of place : " + customer.BirthPlace + "\n");

            }
        }



    }
}
