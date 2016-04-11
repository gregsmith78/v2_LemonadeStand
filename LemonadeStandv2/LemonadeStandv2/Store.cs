using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    public class Store
    {
        public double paperCupsPrice = .02;
        public double paperCupInput;
        public double paperCupAmount;

        public double lemonsPrice = .10;
        public double lemonInput;
        public double lemonAmount;

        public double cupsOfSugarPrice = .05;
        public double sugarInput;
        public double sugarAmount;

        public double iceCubesPrice = .02;
        public double iceInput;
        public double iceAmount;

        public double updateWallet;
        public double lemonadeInput;
        public double chargePerLemonade;
       
        
        
          
        

        public Store() 
        {
          
           
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
        public double PurchaseCups(Player player)
        {
           
            Console.WriteLine("Let's start off with cups...How many cups would you like to buy?");
            Console.WriteLine();
            try
            {
                paperCupInput = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseCups(player);
            }
            if (player.wallet - (paperCupInput * paperCupsPrice) < 0)
            {
                Console.WriteLine("Sorry, you don't have enough money to buy that much. Please try another amount.");
                PurchaseCups(player);
            }
            else 
            { 
                paperCupAmount = paperCupInput * paperCupsPrice;
                Console.WriteLine("You chose to buy " + paperCupInput + " cups for {0:C}",  paperCupAmount);
                updateWallet = player.wallet - paperCupAmount;
                Console.WriteLine("You now have {0:C}", updateWallet + " left in your bank.");
                Console.WriteLine();
                player.inventory.cups = paperCupInput;
                player.wallet = updateWallet;

            }
            return player.wallet;
           
        }
        public double PurchaseLemons(Player player)
        {

            Console.WriteLine("Let's go on to lemons. How many lemons would you like to buy?");
            try
            {
                lemonInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseLemons(player);
            }
            if (player.wallet - (lemonInput * lemonsPrice) + paperCupAmount < 0)
            {
                Console.WriteLine("Sorry, you don't have enough money to buy that much. Please try another amount.");
                PurchaseLemons(player);
            }
            else
            {
                lemonAmount = lemonInput * lemonsPrice;
                Console.WriteLine("You chose to buy " + lemonInput  + " lemons for {0:C}", lemonAmount);
                updateWallet = player.wallet - lemonAmount;
                Console.WriteLine("You now have {0:C}", updateWallet + " left in your bank.");
                Console.WriteLine();
                player.inventory.lemons = lemonInput;
                player.wallet = updateWallet;

            }
            return player.wallet;

        }

        public double PurchaseSugar(Player player)
        {

            Console.WriteLine("Your cups and lemons are taken care of. Now we need sugar...How many cups of sugar would you like to buy?");
            Console.WriteLine();
            try

            {
                sugarInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseSugar(player);
            }
            if (player.wallet - (sugarInput * cupsOfSugarPrice) + paperCupAmount + lemonAmount < 0)
            {
                Console.WriteLine("Sorry, you don't have enough money to buy that much. Please try another amount.");
                PurchaseSugar(player);
            }
            else
            {
                sugarAmount = sugarInput * cupsOfSugarPrice;
                Console.WriteLine("You chose to buy " + sugarInput + " cups for {0:C}", sugarAmount);
                updateWallet = player.wallet - sugarAmount;
                Console.WriteLine("You now have {0:C}", updateWallet + " left in your bank.");
                Console.WriteLine();
                player.inventory.sugar = sugarInput;
                player.wallet = updateWallet;

            }
            return player.wallet;

        }
        public double PurchaseIce(Player player)
        {
        
            Console.WriteLine("And lastly we need our ice...how many cubes would you like to buy?");
            Console.WriteLine();
            try
            {
                iceInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseIce(player);
            }
            if (player.wallet - (iceInput * iceCubesPrice) + paperCupAmount + lemonAmount + sugarAmount < 0)
            {
                Console.WriteLine("Sorry, you don't have enough money to buy that much. Please try another amount.");
                PurchaseIce(player);
            }
            else
            {
                iceAmount = iceInput * iceCubesPrice;
                Console.WriteLine("You chose to buy " + iceInput + " cubes of ice for {0:C}", iceAmount);
                updateWallet = player.wallet - iceAmount;
                Console.WriteLine("You now have {0:C}", updateWallet + " left in your bank.");
                Console.WriteLine();
                player.inventory.ice = iceInput;
                player.wallet = updateWallet;

            }
            return player.wallet;

        }

        public double SetPriceForLemonade(Player player)
        {
            Console.WriteLine("You now have your ingredients to make your lemonade!");
            Console.WriteLine("How much would you like to charge for a cup?");
            Console.WriteLine("Please enter your price in decimal form...");
            Console.WriteLine("and remember to keep in mind that the weather will be a factor in your sales...");
            Console.WriteLine();
          

            lemonadeInput = Double.Parse(Console.ReadLine());
          
            if (lemonadeInput > .0 && lemonadeInput < 1.50)
            {
                Console.WriteLine("Alright, you set your price for {0:C}", lemonadeInput);
                Console.WriteLine("Let's see how many customers liked your lemonade!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That price is too high...try again please.");
                SetPriceForLemonade(player);
                Console.ReadLine();
            }

            chargePerLemonade = lemonadeInput;

            return chargePerLemonade;
        }
       



    }
}
