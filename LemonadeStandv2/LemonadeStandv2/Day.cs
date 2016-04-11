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
        public Store store;


        public Day()
        {

            store = new Store();
           
           
        }
        //public double CustomersBuying()
        //{
        //    foreach (int customer in customers)
        //    {
        //        if (store.chargePerLemonade > 0 && store.chargePerLemonade < .50)
        //        {
        //            store.player.wallet += store.chargePerLemonade;
        //        }
        //    }
        //    return store.player.wallet;
        //}



    }
}
