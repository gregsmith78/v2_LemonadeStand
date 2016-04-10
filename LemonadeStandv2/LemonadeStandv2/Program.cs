using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();

            Day day = new Day();
            Weather weather = new Weather();
            weather.PotentialCustomers();
            //Store store = new Store();
           // store.DisplayPrices();

            Console.WriteLine(day.customers.Count());
            Console.ReadLine();

        }
    }
}
