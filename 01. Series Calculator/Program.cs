using System;

namespace _01._SeriesCalculator

{
    class Program
    {
        static void Main(string[] args)
        {
            string nameMovie = Console.ReadLine();
            int numSeason = int.Parse(Console.ReadLine());
            int numEpizodies = int.Parse(Console.ReadLine());
            double oneEpozod = double.Parse(Console.ReadLine());

            double reclami = oneEpozod * 0.2;
            double total = (oneEpozod + reclami) * numEpizodies * numSeason + numSeason * 10;
            Console.WriteLine($"Total time needed to watch the {nameMovie} series is {total} minutes.");


        }
    }
}
