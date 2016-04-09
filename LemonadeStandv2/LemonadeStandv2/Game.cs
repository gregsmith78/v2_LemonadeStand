﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    public class Game
    {
        public int choice;

        Player player;
        Weather weather;

        public Game()
        {
            player = new Player();
            weather = new Weather();
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
            Console.WriteLine("1 Check the forcast?");
            Console.WriteLine("2 Purchase supplies?");
            Console.WriteLine("3 Exit the game.");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    weather.GenerateForeCast();
                    //Console.WriteLine();
                    break;
                case 2:
                    //PurchaseSupplies();
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
