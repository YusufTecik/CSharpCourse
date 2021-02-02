using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entity
{
    public class Campaign : IBaseCampaignService
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDiscount { get; set; }

    }
}
