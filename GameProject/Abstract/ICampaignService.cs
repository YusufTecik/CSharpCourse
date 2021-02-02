using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpgradeCampaign(Campaign campaign);
    }
}
