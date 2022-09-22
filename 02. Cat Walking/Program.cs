using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int numWolkingPerDay = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            int allCalories = min * numWolkingPerDay * 5;

            if (allCalories >= calories / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {allCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {allCalories}.");
            }


        }
    }
}
