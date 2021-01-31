using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class SalesManagement : ISalesService
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " adlı kullanıcı " + game.Name + " adlı oyunu aldı.");
        }
    }
}
