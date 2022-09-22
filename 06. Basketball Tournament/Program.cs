using System;

namespace _06._Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTournament = Console.ReadLine();
            int gaoalDesi = 0;
            int antiDesi = 0;
            double brDesiWin = 0;
            double brDesiLose = 0;

            while (nameOfTournament != "End of tournaments")
            {
                int num = int.Parse(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                {
                    gaoalDesi = int.Parse(Console.ReadLine());
                    antiDesi = int.Parse(Console.ReadLine());
                    if (gaoalDesi > antiDesi )
                    {
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: win with {gaoalDesi - antiDesi} points.");
                        brDesiWin++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: lost with {antiDesi - gaoalDesi} points.");
                        brDesiLose++;
                    }



                }



                nameOfTournament = Console.ReadLine();
            }

            if (nameOfTournament == "End of tournaments")
            {
                Console.WriteLine($"{(brDesiWin/(brDesiWin+brDesiLose)*100):f2}% matches win");
                Console.WriteLine($"{(brDesiLose/(brDesiLose+brDesiWin)*100):f2}% matches lost");
            }



        }
    }
}
