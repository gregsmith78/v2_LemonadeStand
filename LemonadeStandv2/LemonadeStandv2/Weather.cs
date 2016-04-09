using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    public class Weather
    {
        public int temperature;
        string weather;
        int chanceOfPrecipitation;
        

        public Weather()
        {

        }

        public void GenerateForeCast()
        {
            Random rand = new Random();
            temperature = rand.Next(60, 100);

        if (temperature < 75)
            {
                RainOrShine();
                Console.WriteLine("It is " +temperature+ " degrees outside and " + weather);
               
                Console.ReadLine();
        }
        else if (temperature > 75 && temperature < 90)
        {
                RainOrShine();
                Console.WriteLine("It is " + temperature + " degrees outside and " + weather);
                Console.ReadLine();
        }
        else
        {
                RainOrShine();
                Console.WriteLine("It is " + temperature + " degrees outside and " + weather);
                Console.ReadLine();
        }
            
        }

        public void RainOrShine()
        {
            Random rand = new Random();
            int forecast = rand.Next(1, 5);
            

            switch (forecast)
            {
                case 1:
                    chanceOfPrecipitation = rand.Next(1, 80);
                    weather = "cloudy with a "+chanceOfPrecipitation+ "% of rain";
                    break;
                case 2:
                    weather = "rainy";
                    break;
                case 3:
                    chanceOfPrecipitation = rand.Next(1, 20);
                    weather = "sunny with a " + chanceOfPrecipitation + "% of rain";
                    break;
                case 4:
                    weather = "breezy";
                    break;
                case 5:
                    chanceOfPrecipitation = rand.Next(1, 60);
                    weather = "hazy";
                    break;

            }

        }
        public void DisplayForeCast()
        {

        }
    }

}
