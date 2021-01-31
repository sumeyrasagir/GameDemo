using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { Id = 1, Name = "Counter-Strike: Global Offensive", Price = 70 };

            Game game2 = new Game() { Id = 2, Name = "Among Us", Price = 57 };

            Game game3 = new Game() { Id = 3, Name = "DOTA 2", Price = 45 };
            
            Gamer gamer1 = new Gamer() { Id = 70, BirthYear = 1996, FirstName = "Ali", LastName = "Kaya", UserName = "ali.kaya1", NationalityId = 25413698705, CreditCardNumber = 365412389 }; 

            Gamer gamer2 = new Gamer() { Id = 77, BirthYear = 1999, FirstName = "Sümeyra", LastName = "Sağır", UserName = "sumeyrasagir_", NationalityId = 25694262770, CreditCardNumber = 962415386 };

            Gamer gamer3 = new Gamer() { Id = 97, BirthYear = 2005, FirstName = "Zeynep Güher", LastName = "Sağır", UserName = "zeynepsagir_", NationalityId = 75300438506, CreditCardNumber = 462415386 };

            //Kullanıcı bilgileri yanlış olduğu için Exceptiona gidecek, doğruları girildiğinde çalışıyor.

            Campaign campaign1 = new Campaign() { GameId = 352, CampaignName = "Kış Festivali", RateOfDiscount = 13 };
            Campaign campaign2 = new Campaign() { GameId = 368, CampaignName = "Sömestır Maratonu", RateOfDiscount = 24 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);


            BaseCustomerManager customerManager = new GamerManager(new MernisServiceAdapter());
            customerManager.Save(gamer3);
            customerManager.Save(gamer1);
            customerManager.Save(gamer2);
            customerManager.Update(gamer2);

            
            Sales sales1 = new Sales() { Game = game1.Name, Gamer = gamer3.UserName };

            SalesManagement salesManagement = new SalesManagement();
            salesManagement.Buy(game3, gamer3);
            salesManagement.Buy(game1, gamer2);
            

        }
    }
}
