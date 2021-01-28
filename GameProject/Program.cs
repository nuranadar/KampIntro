using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {


        static void Main(string[] args)
        {

            Game game1 = new Game() { Id = 1, Name = "Prince Of Persia 1 ", ReleaseYear = 1989, Price = 100 };
            Game game2 = new Game() { Id = 1, Name = "Prince Of Persia 2 ", ReleaseYear = 1993, Price = 200 };
            Game game3 = new Game() { Id = 1, Name = "Lego Indiana Jones ", ReleaseYear = 2009, Price = 350 };

            GameManager gameManager = new GameManager();

            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            Console.WriteLine("\n");
            gameManager.Remove(game3);
            Console.WriteLine("\n");
            gameManager.List();
            Console.WriteLine("\n");



            Campaign campaign1 = new Campaign { Id = 1, Name = "Black Friday", DiscountRate = 50 };
            Campaign campaign2 = new Campaign { Id = 2, Name = "Boxing Day", DiscountRate = 20 };
            Campaign campaign3 = new Campaign { Id = 3, Name = "Cyber Monday", DiscountRate = 40 };

            CampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);
            Console.WriteLine("\n");

            campaignManager.Remove(campaign2);
            Console.WriteLine("\n");

            campaignManager.Update(campaign1);
            Console.WriteLine("\n");

            campaignManager.Apply(game1,campaign1);
            Console.WriteLine("\n");














        }
    }
}
