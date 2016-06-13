using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    public class Day
    {
       
        
        public int numberOfCustomers;
    
        public Day()
        {
        
        }

        public double CustomersBuying(Player player, Store store)
        {
            Random rand = new Random();

           for (int potentialCust = 0; potentialCust < numberOfCustomers; potentialCust++)
            {
                int buyFactor = rand.Next(1, 10);

                if (store.chargePerLemonade > 0)
                {
                    if (buyFactor < 6)
                    { 
                    player.wallet += store.chargePerLemonade;
                    Console.WriteLine("bought lemonade.");
                    player.inventory.boughtLemonade = player.inventory.cupsSold += 1;
                    }
                    else
                    {
                        player.inventory.didNotBuy = player.inventory.cupsNotSold += 1;
                        Console.WriteLine("did not buy lemonade.");
                    }
                }
            }
            return player.wallet;
        }



    }
}
