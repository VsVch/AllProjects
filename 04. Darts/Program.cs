using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int br = 0;
            int noBr = 0;
            bool isis = false;
            int points = 301;

            string pole = Console.ReadLine();

            while (pole != "Retire")
            {
                int currentPoints = int.Parse(Console.ReadLine());
                switch (pole)
                {
                    case "Triple":
                        currentPoints = 3 * currentPoints;
                        break;
                    case "Double":
                        currentPoints = 2 * currentPoints;
                        break;
                    case "Single":
                        currentPoints = currentPoints;
                        break;




                    default:
                        break;
                }

                br++;
                
                points -= currentPoints;
                if (points == 0)
                {
                    Console.WriteLine($"{name} won the leg with {br} shots.");
                    break;
                }
                if (points < 0)
                {
                    br = br - 1;
                    noBr++;
                    points = points + currentPoints;
                }
                if (points > 0)
                {
                    pole = Console.ReadLine();
                }
                isis = true;
            }

            if (pole == "Retire")
            {
                Console.WriteLine($"{name} retired after {noBr} unsuccessful shots.");
                
                

            }
            

        }
    }
}
