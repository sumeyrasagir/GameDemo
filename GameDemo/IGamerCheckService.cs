using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
