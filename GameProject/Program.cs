using GameProject.Adapters;
using GameProject.Concrate;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //gamerManager.Add(new Entities.Gamer
            //{ 
            //    DateOfBirth = 1997,
            //    FirstName = "SEDA",
            //    LastName = "AKTEPE",
            //    Tc = 12345
            //});

            

            //Oyuncu Oluşturma
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Seda";
            gamer1.LastName = "Aktepe";
            gamer1.Tc = 12345678987;
            gamer1.DateOfBirth = 1997;

            //Oyuncu Ekleme 
            GamerManager gamerManager1 = new GamerManager(new MernisServiceAdapter());
            gamerManager1.Add(gamer1);
            //Oyuncu Silme
            gamerManager1.Delete(gamer1);
            //Oyuncu Güncelleme 
            gamerManager1.Update(gamer1);
            Console.WriteLine("*************************");
            //Oyun Oluşturma
            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "ASPHALT 9";
            game1.Cost = 1500;

            //Oyun Ekleme
            GameManager gameManager1 = new GameManager();
            gameManager1.Add(game1);
            //Oyun Silme
            gameManager1.Delete(game1);
            //Oyun Güncelleme
            gameManager1.Update(game1);
            Console.WriteLine("*************************");
            //Kampanya Oluşturma
            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "İndirim yağmuru";
            campaign1.HowManyTimes = 50;

            //Kampanya Ekleme
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);
            //Kampanya Silme
            campaignManager1.Delete(campaign1);
            //Kampanya Güncelleme
            campaignManager1.Update(campaign1);
            Console.WriteLine("*************************");
            //Satış
            SalesManager salesManager = new SalesManager();
            //Normal Satış
            salesManager.Sales(gamer1, game1);
            //Kampanyalı Satış
            salesManager.SalesCampaign(gamer1, game1, campaign1);
        }
    }
}
