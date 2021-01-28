using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        List<ICampaignService> campaigns = new List<ICampaignService>();
        Game game = new Game();

        public void Add(Campaign campaign) 
        {
            Console.WriteLine("New campaign has been added to our system ; ");
            Console.WriteLine("Campaign Name : " + campaign.Name);
            Console.WriteLine("Discount Rate : " + campaign.DiscountRate);
        }
        public void Apply(Game game, Campaign campaign)
        {
            var discount = campaign.DiscountRate;
            var price = game.Price;
            var discountedGamePrice = price * (100 - discount) / 100;

            Console.WriteLine(campaign.Name +" has been applied to your purchase." );
            Console.WriteLine("New game price is : " + discountedGamePrice);
        }

        public void Apply(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void List(Campaign campaign)
        {
            foreach (var item in campaigns)
            {
                Console.WriteLine(campaign.Id + "\t" + campaign.Name + "\t" + campaign.DiscountRate);
            }
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " has been removed from the campaign list.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " has been updated.");
        }
    }
}
