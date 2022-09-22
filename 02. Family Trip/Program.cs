using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjet = double.Parse(Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());
            double priceForOneNight = double.Parse(Console.ReadLine());
            int dopRaz = int.Parse(Console.ReadLine());

            double discount = 0;
            if (numNights > 7)
            {
                discount = 5;
            }

            double allDOpRaz = budjet * dopRaz / 100;
            double sum = numNights * priceForOneNight - numNights * priceForOneNight * discount / 100 + allDOpRaz;

            if (budjet >= sum)
            {
                Console.WriteLine($"Ivanovi will be left with {(budjet - sum):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{(sum - budjet):f2} leva needed.");
            }

        }
    }
}
