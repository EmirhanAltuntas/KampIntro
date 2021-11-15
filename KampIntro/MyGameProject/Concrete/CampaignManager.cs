using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated");
        }
    }
}
