using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Campaign : IEntity
    {
        public string CampaignName { get; set; }
        public string CampaignType { get; set; }
        public int HowManyTimes { get; set; }
    }
}
