using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {

            double sum = double.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());
            int ages = int.Parse(Console.ReadLine());
            string kindSport = Console.ReadLine();
            double price = 0;

            if (letter == 'm')
            {
                switch (kindSport)
                {

                    case "Gym":
                        price = 42;
                        break;
                    case "Boxing":
                        price = 41;
                        break;
                    case "Yoga":
                        price = 45;
                        break;
                    case "Zumba":
                        price = 34;
                        break;
                    case "Dances":
                        price = 51;
                        break;
                    case "Pilates":
                        price = 39;
                        break;
                    default:
                        break;
                }
            }
            else if (letter == 'f')
            {
                switch (kindSport)
                {

                    case "Gym":
                        price = 35;
                        break;
                    case "Boxing":
                        price = 37;
                        break;
                    case "Yoga":
                        price = 42;
                        break;
                    case "Zumba":
                        price = 31;
                        break;
                    case "Dances":
                        price = 53;
                        break;
                    case "Pilates":
                        price = 37;
                        break;
                    default:
                        break;
                }
            }

            if (ages <= 19)
            {
                price = price * 0.8;
            }
            if (price <= sum)
            {
                Console.WriteLine($"You purchased a 1 month pass for {kindSport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(price - sum):f2} more.");
            }





        }
    }
}
