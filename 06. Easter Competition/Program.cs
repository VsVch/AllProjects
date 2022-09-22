using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            double numKozunaci = double.Parse(Console.ReadLine());
            double points = 0;
            double pointOne = 0;
            double maxPoints = 0;
            string maxName = string.Empty;

            for (int i = 0; i < numKozunaci; i++)
            {
                pointOne = 0;
                string name = Console.ReadLine();
                string opinion = Console.ReadLine();

                while (opinion != "Stop")
                {
                    points = double.Parse(opinion);
                    pointOne += points;

                    opinion = Console.ReadLine();

                }
                if (opinion == "Stop")
                {
                    Console.WriteLine($"{name} has {pointOne} points.");

                    if (pointOne>maxPoints)
                    {
                        maxPoints = pointOne;
                        maxName = name;
                        Console.WriteLine($"{maxName} is the new number 1!");

                    }

                    

                }

            }

            Console.WriteLine($"{maxName} won competition with {maxPoints} points!");


        }
    }
}
