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
        public double wallet = 15.00;
        public Inventory inventory;
        //Game game;
       

        public Player()
        {
            inventory = new Inventory();
            //game = new Game();
            
            
        }
    }
}
