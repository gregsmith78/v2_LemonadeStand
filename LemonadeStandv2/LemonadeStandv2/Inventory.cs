using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    public class Inventory
    {
        public double lemons;
        public double sugar;
        public double cups;
        public double ice;
        public double boughtLemonade;
        public double cupsNotSold = 0;
        public double didNotBuy;
        public double cupsSold = 0;
        public double totalCustomers;
        public string input;
        public char response;
       // Game game = new Game();
       


        public Inventory()
        {}

        public void SubtractFromStock(Player player, Store store)
        {
            //Game game = new Game();

            for (int drinks = 0; drinks < player.inventory.boughtLemonade; drinks++)
            {
                player.inventory.lemons -= 1;
                player.inventory.cups -= 1;
                player.inventory.sugar -= 1;
                player.inventory.ice -= 1;
            }
            if (player.inventory.lemons <= 0)
            {
                Console.WriteLine("Out of inventory...");
            }
        }

           //     if (player.inventory.lemons < 1 || player.inventory.cups < 1 || player.inventory.sugar < 1 || player.inventory.ice < 1)
           //     {

           //         Console.WriteLine("You ran out of inventory. :(");
           //         Console.WriteLine("Sorry...better luck tomorrow...");
           //         Console.ReadLine();
           //         Console.WriteLine("Would you like to continue? Yes or No?");
           //         input = Console.ReadLine();
           //         response = Convert.ToChar(input);

           //         while(response == 'Y')
           //         {
                        
           //             game.weather.GenerateForeCast();
           //             store.DisplayPrices();
           //             Console.WriteLine();
           //             store.PurchaseCups(player);
           //             store.PurchaseLemons(player);
           //             store.PurchaseSugar(player);
           //             store.PurchaseIce(player);
           //             store.SetPriceForLemonade(player);
           //             game.weather.day.CustomersBuying(player, store);
           //             Console.WriteLine(player.wallet);
           //             break;    

           //         }
           //         game.End();
           //         Environment.Exit(0);
                    
                    
           //     }
               
           //}
           public void MeltedIce(Player player)
           {
            player.inventory.ice = 0;
           }
           
        
        public void ReturnInventoryAfterSales(Player player)
        {
            totalCustomers = (player.inventory.boughtLemonade) + (player.inventory.didNotBuy);
            double cupsFloor = Math.Floor(player.inventory.cups);
            double lemonFloor = Math.Floor(player.inventory.lemons);
            double sugarFloor = Math.Floor(player.inventory.sugar);
            //player.inventory.ice = 0;
            Console.WriteLine(player.inventory.boughtLemonade + " out of " + totalCustomers + " customers bought lemonade today!");
            Console.WriteLine("This is what you have left in your inventory.");
            Console.WriteLine("Cups: " + cupsFloor);
            Console.WriteLine("Lemons: " + lemonFloor);
            Console.WriteLine("Cups of Sugar: " + sugarFloor);
            MeltedIce(player);
            Console.WriteLine("All your remaining ice has melted for the day...");
            
           
        }

     
       
    }

}
