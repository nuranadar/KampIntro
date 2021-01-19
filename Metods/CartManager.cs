using System;
using System.Collections.Generic;
using System.Text;

namespace Metods
{
    class CartManager
    {
        //naming convention

        public void Add(Product product) 
        {
            Console.WriteLine("Congratulations. Added to your cart. " + "\n" +"Product : " +  
                product.Name + "\n" +"Information : " +product.Information + "\n" + "Fee : "+product.Fee);
        }

       public void Add2(string productName, string Information, double Fee , int stockNumber) 
        {
            Console.WriteLine("Congratulations. Added to your cart : " + productName);
        }

    }
}
