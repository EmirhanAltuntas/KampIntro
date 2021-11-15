using MyGameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
