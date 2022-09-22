using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {

            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int free = 0;
            int allFree = 0;


            int v = w * l * h;

            string imput = Console.ReadLine();

            while (imput != "Done" && v >= allFree)
            {
                free = int.Parse(imput);
                allFree += free;

                if (allFree >= v)
                {
                    Console.WriteLine($"No more free space! You need {allFree-v} Cubic meters more.");
                }


                imput = Console.ReadLine();

            }


            if (imput == "Done")
            {
                Console.WriteLine($"{v-allFree} Cubic meters left.");
            }



        }
    }
}
