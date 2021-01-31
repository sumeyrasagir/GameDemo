using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class BaseCustomerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("User deleted !!");
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Saved to db: " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " : Updated !!");
        }
    }
}
