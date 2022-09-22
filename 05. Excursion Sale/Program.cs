using System;

namespace _05._Excursion_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTripSea = int.Parse(Console.ReadLine());
            int numTripMountain = int.Parse(Console.ReadLine());
            int brSea = 0;
            int brMountains = 0;
            double price = 0;
            double priceSea = 680;
            double priceMountain = 499;

            string trip = Console.ReadLine();

            while (trip != "Stop")
            {

                if (trip == "sea")
                {
                    numTripSea--;
                    price += priceSea;
                }
                if (trip == "mountain")
                {
                    numTripMountain--;
                    price += priceMountain;
                }

                if (numTripSea == 0)
                {
                    priceSea = 0;
                }
                if (numTripMountain == 0)
                {
                    priceMountain = 0;
                }

                if (numTripSea <= 0 && numTripMountain <= 0)
                {
                    Console.WriteLine($"Good job! Everything is sold.");
                    break;
                }


                trip = Console.ReadLine();
            }

            
            {
                Console.WriteLine($"Profit: {price:f0} leva.");
            }



        }
    }
}
