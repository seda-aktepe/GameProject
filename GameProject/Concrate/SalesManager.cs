using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu " + game.Name + " oyununu satın aldı.");
        }

        public void SalesCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " : " + campaign.CampaignName + " ile " + game.Name + " oyununu satın aldı.");

        }
    }
}
