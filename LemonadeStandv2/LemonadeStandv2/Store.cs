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
        public int paperCupInput;
        public decimal paperCupAmount;

        public decimal lemonsPrice = .03M;
        public int lemonInput;
        public decimal lemonAmount;

        public decimal cupsOfSugarPrice = .04M;
        public int sugarInput;
        public decimal sugarAmount;

        public decimal iceCubesPrice = .02M;
        public int iceInput;
        public decimal iceAmount;

        public decimal updateWallet;
       
        
        
        Player player;
        Inventory inventory;
        

        public Store() 
        {
            player = new Player();
            inventory = new Inventory();
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
                Console.WriteLine("You now have {0:C}", updateWallet + " left in your bank.");
                inventory.cups = paperCupInput;
                player.wallet = updateWallet;

            }
            return player.wallet;
           
        }
        public decimal PurchaseLemons()
        {

            Console.WriteLine("Let's go on to lemons. How many lemons would you like to buy?");
            try
            {
                lemonInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseLemons();
            }
            if (player.wallet - (lemonInput * lemonsPrice) + paperCupAmount < 0)
            {
                Console.WriteLine("Sorry, you don't have enough money to buy that much. Please try another amount.");
                PurchaseLemons();
            }
            else
            {
                lemonAmount = lemonInput * lemonsPrice;
                Console.WriteLine("You chose to buy " + lemonInput  + " lemons for " + lemonAmount);
                updateWallet = player.wallet - lemonAmount;
                Console.WriteLine("You now have {0:C}", updateWallet + " left in your bank.");
                inventory.lemons = lemonInput;
                player.wallet = updateWallet;

            }
            return player.wallet;

        }

        public decimal PurchaseSugar()
        {

            Console.WriteLine("Your cups and lemons are taken care of. Now we need sugar...How many cups of sugar would you like to buy?");
            try
            {
                sugarInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseSugar();
            }
            if (player.wallet - (sugarInput * cupsOfSugarPrice) + paperCupAmount + lemonAmount < 0)
            {
                Console.WriteLine("Sorry, you don't have enough money to buy that much. Please try another amount.");
                PurchaseSugar();
            }
            else
            {
                sugarAmount = sugarInput * cupsOfSugarPrice;
                Console.WriteLine("You chose to buy " + sugarInput + " cups for " + sugarAmount);
                updateWallet = player.wallet - sugarAmount;
                Console.WriteLine("You now have {0:C}", updateWallet + " left in your bank.");
                inventory.sugar = sugarInput;
                player.wallet = updateWallet;

            }
            return player.wallet;

        }
        public decimal PurchaseIce()
        {

            Console.WriteLine("And lastly we need our ice...how cubes would you like to buy?");
            try
            {
                iceInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseIce();
            }
            if (player.wallet - (iceInput * iceCubesPrice) + paperCupAmount + lemonAmount + sugarAmount < 0)
            {
                Console.WriteLine("Sorry, you don't have enough money to buy that much. Please try another amount.");
                PurchaseIce();
            }
            else
            {
                iceAmount = iceInput * iceCubesPrice;
                Console.WriteLine("You chose to buy " + iceInput + " cubes of ice for " + iceAmount);
                updateWallet = player.wallet - iceAmount;
                Console.WriteLine("You now have {0:C}", updateWallet + " left in your bank.");
                inventory.ice = iceInput;
                player.wallet = updateWallet;

            }
            return player.wallet;

        }
    }
}
