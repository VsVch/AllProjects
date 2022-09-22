using System;

namespace _05._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {

            int numTournament = int.Parse(Console.ReadLine());
            int startPoints = 0;
            int beginPoints = int.Parse(Console.ReadLine());

            int w = 0;
            int f = 0;
            int sf = 0;
            for (int i = 0; i < numTournament; i++)
            {
                string lettar = Console.ReadLine();
                switch (lettar)
                {
                    case "W":
                        startPoints += 2000;
                        w++;
                        break;
                    case "F":
                        startPoints += 1200;
                        f++;
                        break;
                    case "SF":
                        startPoints += 720;
                        sf++;
                        break;

                    default:
                        break;
                }



            }

            Console.WriteLine($"Final points: {startPoints+beginPoints}");
            Console.WriteLine($"Average points: {startPoints/numTournament}");
            Console.WriteLine($"{1.0*(w*1.0/numTournament*100*1.0):f2}% ");








        }
    }
}
