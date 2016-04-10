using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    public class Player
    {
        public string name;
        public decimal wallet = 15.00M;
        Inventory inventory;

        public Player()
        {
            inventory = new Inventory();
            
        }
    }
}
