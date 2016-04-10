using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    public class Store
    {
        public decimal lemons = .10M;
        public decimal cupsOfSugar = .04M;
        public decimal paperCups = .02M;
        public decimal iceCubes = .02M;


        public Store() 
        {

        }
        public void DisplayPrices()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Welcome to Bucky's Supplies!");
            Console.WriteLine("--------------------------");
            Console.WriteLine(String.Format("Lemons: {0:C}", lemons));
            Console.WriteLine(String.Format("Cups of Sugar: {0:C}", cupsOfSugar));
            Console.WriteLine(String.Format("Paper Cups: {0:C}", paperCups));
            Console.WriteLine(String.Format("Cubes of Ice: {0:C}", iceCubes));

        }
    }
}
