using System;

namespace _03._Excursion_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int numPeople = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;

            if (numPeople <= 5)
            {
                switch (season)
                {
                    case "spring":
                        price = 50;
                        break;
                    case "summer":
                        price = 48.5;
                        break;
                    case "autumn":
                        price = 60;
                        break;
                    case "winter":
                        price = 86;
                        break;


                    default:
                        break;
                }
            }
            else
            {
                switch (season)
                {
                    case "spring":
                        price = 48;
                        break;
                    case "summer":
                        price = 45;
                        break;
                    case "autumn":
                        price = 49.5;
                        break;
                    case "winter":
                        price = 85;
                        break;


                    default:
                        break;
                }
            }

            double sum = price * numPeople;
            if (season == "summer")
            {
                sum = sum * 0.85;
            }

            if (season == "winter")
            {
                sum = sum + sum*8/100;
            }


            Console.WriteLine($"{sum:f2} leva.");

        }
    }
}
