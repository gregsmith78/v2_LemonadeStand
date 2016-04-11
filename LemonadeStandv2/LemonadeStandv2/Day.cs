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
       // public Store store;
        //public Weather weather;


        public Day()
        {

           // store = new Store();
            //weather = new Weather();
           
           
        }
        public double CustomersBuying(Player player, Store store)
        {
            for (int potentialCust = 0; potentialCust < numberOfCustomers; potentialCust++)
            {
                if (store.chargePerLemonade > 0 && store.chargePerLemonade < .50)
                {
                    player.wallet += store.chargePerLemonade;
                }
            }
            return player.wallet;
        }



    }
}
