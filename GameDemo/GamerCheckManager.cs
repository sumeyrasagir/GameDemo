using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
