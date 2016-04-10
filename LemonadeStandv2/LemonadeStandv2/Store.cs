using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    public class Store
    {
        public decimal paperCupsPrice = .02M;
        public decimal lemonsPrice = .10M;
        public decimal cupsOfSugarPrice = .04M;
        public decimal iceCubesPrice = .02M;
        public int paperCupInput;
        public decimal paperCupAmount;
        public decimal updateWallet;
        public int lemonInput;
        public int sugarInput;
        public int iceInput;
        Player player;
        

        public Store() 
        {
            player = new Player();
        }
        public void DisplayPrices()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Welcome to Bucky's Supplies!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(String.Format("Paper Cups: {0:C}", paperCupsPrice));
            Console.WriteLine(String.Format("Lemons: {0:C}", lemonsPrice));
            Console.WriteLine(String.Format("Cups of Sugar: {0:C}", cupsOfSugarPrice));
            Console.WriteLine(String.Format("Cubes of Ice: {0:C}", iceCubesPrice));
            Console.WriteLine("-------------------------------");

        }
        public decimal PurchaseCups()
        {
           
            Console.WriteLine("Let's start off with cups...How many cups would you like to buy?");
            try
            {
                paperCupInput = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseCups();
            }
            if (player.wallet - (paperCupInput * paperCupsPrice) < 0)
            {
                Console.WriteLine("Sorry, you don't have enough money to buy that much. Please try another amount.");
                PurchaseCups();
            }
            else 
            { 
                paperCupAmount = paperCupInput * paperCupsPrice;
                Console.WriteLine("You chose to buy " + paperCupInput + " cups for " + paperCupAmount);
                updateWallet = player.wallet - paperCupAmount;
                Console.WriteLine("You now have {0:C}", updateWallet);
            }
            return updateWallet;
           
        }
    }
}
