using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {

            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            
            int free = 0;
            int allFree = 0;


            int v = w * l ;

            string imput = Console.ReadLine();

            while (imput != "STOP" && v > allFree)
            {
                free = int.Parse(imput);
                allFree += free;

                if (allFree > v)
                {
                    Console.WriteLine($"No more cake left! You need {allFree-v} pieces more.");
                    break;
                }


                imput = Console.ReadLine();

            }


            if (imput == "STOP")
            {
                Console.WriteLine($"{v-allFree} pieces are left.");
            }



        }
    }
}
