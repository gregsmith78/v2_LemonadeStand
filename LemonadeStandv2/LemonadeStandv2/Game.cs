using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    public class Game
    {
        public int choice;
        public Player player;
        public Weather weather;
        public Store store;
       
        

        public Game()
        {
            player = new Player();
            weather = new Weather();
            store = new Store();
           
            

        }

        public void Start()
        {
            Console.WriteLine("Please enter your name.");
            player.name = Console.ReadLine();
            Console.WriteLine("Welcome to {0}"+ "'s Lemonade Stand!!", player.name);
            Console.ReadLine();
            Menu();
        }

        public void End()
        {
            Console.WriteLine("Good Bye!");
            Console.ReadLine();
        }

        public void Menu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1 Check the forcast....");
            Console.WriteLine("2 Purchase supplies to stock up for the day...");
            Console.WriteLine("3 Exit the game.");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    weather.GenerateForeCast();
                    weather.GoToStore(store);
                    break;
                case 2:
                    weather.GenerateForeCast();
                    store.DisplayPrices();
                    Console.WriteLine();
                    store.PurchaseCups(player);
                    store.PurchaseLemons(player);
                    store.PurchaseSugar(player);
                    store.PurchaseIce(player);
                    store.SetPriceForLemonade(player);
                    weather.day.CustomersBuying(player, store);
                    player.inventory.SubtractFromStock(player, store);
                    player.inventory.ReturnInventoryAfterSales(player);
                    Console.WriteLine(player.wallet);
                    break;
                case 3:
                    End();
                    break;
                default:
                    Console.WriteLine("Please select a valid number.");
                    Menu();
                    break;
                    



            }
            
        }
    }

}
