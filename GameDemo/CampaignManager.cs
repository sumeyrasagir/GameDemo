using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni bir kampanya eklendi : " + campaign.CampaignName );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyasının süresi dolduğundan kaldırılıyor...");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyasının süresi uzatılmıştır !!");
        }
    }
}
