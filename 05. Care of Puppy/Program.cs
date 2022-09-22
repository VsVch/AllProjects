using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {

            double beginEating = double.Parse(Console.ReadLine());
            beginEating = beginEating * 1000;
            double totalEatng = 0;

            string imput = Console.ReadLine();
            while (imput != "Adopted")
            {
                double dayEating = double.Parse(imput);
                totalEatng += dayEating;
                

                imput = Console.ReadLine();
            }
            if (totalEatng > beginEating)
            {
                Console.WriteLine($"Food is not enough. You need {(totalEatng-beginEating):f0} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {(beginEating - totalEatng):f0} grams.");
            }






        }
    }
}
