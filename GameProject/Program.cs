using GameProject.Concrete;
using GameProject.Entity;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer {Id = 1,FirstName = "Yusuf",LastName = "Tecik",DateOfBirth = "02.03.2005",NationalityId = "12345678901" };
            GamerManager gamerManager = new GamerManager(new CheckManager());
            gamerManager.Add(gamer);
            gamerManager.Upgrade(gamer);
            gamerManager.Delete(gamer);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Game game = new Game {GameId = 10, GameName = "League of Legends",GamePrice = "25 TL" };
            GameSaleManager gameSaleManager = new GameSaleManager(gamer);
            gameSaleManager.Sale(game);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Campaign campaign = new Campaign { CampaignId = 1, CampaignName = "%25 indirim kampanyası", CampaignDiscount = "%25" };
            CampaignManager campaignManager = new CampaignManager(game);
            campaignManager.AddCampaign(campaign);
            Console.WriteLine(" ");
            campaignManager.DeleteCampaign(campaign);
            Console.WriteLine(" ");
            campaignManager.UpgradeCampaign(campaign);
        }
    }
}
