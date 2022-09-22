using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            double beginingEat = double.Parse(Console.ReadLine());
            int br = 0;
            double biscuit = 0;
            double totalBiscuit = 0;
            double totalDog = 0;
            double totalCat = 0;


            for (int i = 0; i < days; i++)
            {

                br++;
                double dayDog = double.Parse(Console.ReadLine());
                double dayCat = double.Parse(Console.ReadLine());

                totalDog += dayDog;
                totalCat += dayCat;

                if (br == 3)
                {
                    biscuit = dayDog + dayCat;
                    biscuit = biscuit * 0.1;
                    totalBiscuit += (biscuit);
                    br = 0;
                }



            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuit)}gr.");
            Console.WriteLine($"{((totalCat+totalDog)/beginingEat)*100:f2}% of the food has been eaten.");
            Console.WriteLine($"{((totalDog) / (totalCat + totalDog)) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{((totalCat) / (totalCat + totalDog)) * 100:f2}% eaten from the cat.");








        }
    }
}
