using System;

namespace _03._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string paket = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double sum = 0.0;

            switch (movie)
            {
                case "John Wick":
                    if (paket == "Drink")
                    {
                        sum = 12;
                    }
                    else if (paket == "Popcorn")
                    {
                        sum = 15;
                    }
                    else if (paket == "Menu")
                    {
                        sum = 19;
                    }
                    break;
                case "Star Wars":
                    if (paket == "Drink")
                    {
                        sum = 18;
                    }
                    else if (paket == "Popcorn")
                    {
                        sum = 25;
                    }
                    else if (paket == "Menu")
                    {
                        sum = 30;
                    }
                    break;
                case "Jumanji":
                    if (paket == "Drink")
                    {
                        sum = 9;
                    }
                    else if (paket == "Popcorn")
                    {
                        sum = 11;
                    }
                    else if (paket == "Menu")
                    {
                        sum = 14;
                    }
                    break;


                default:
                    break;
            }



            if (movie == "Star Wars" && tickets>=4)
            {
                sum = sum * 0.7;
            }
            if (movie == "Jumanji" && tickets == 2)
            {
                sum = sum * 0.85;
            }
            sum = sum * tickets;

            Console.WriteLine($"Your bill is {sum:f2} leva.");




        }
    }
}
