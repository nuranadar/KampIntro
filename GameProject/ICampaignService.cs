using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Apply(Campaign campaign);
        void Remove(Campaign campaign);
        void Update(Campaign campaign);
        void List(Campaign campaign);

    }
}
