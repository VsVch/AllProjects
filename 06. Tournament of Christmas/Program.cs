using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            
            int winDays = 0;
            int loseDays = 0;
            
            double totalSum = 0;

            for (int i = 0; i < days; i++)
            {

                int winGames = 0;
                int loseGames = 0;
                double sum = 0;


                string kindSport = Console.ReadLine();
                
                while (kindSport != "Finish")
                {
                    string rezult = Console.ReadLine();
                    if (rezult == "win")
                    {
                        winGames++;
                        sum += 20;
                    }
                    else
                    {
                        loseGames++;
                    }
                    
                    kindSport = Console.ReadLine();
                }
                if (winGames > loseGames)
                {
                    sum = sum + sum * 0.1;
                    totalSum += sum;
                    winDays++;
                }
                else
                {
                    sum = sum;
                    totalSum += sum;
                    loseDays++;
                }
                

            }

            if (winDays > loseDays)
            {
                totalSum = totalSum + totalSum * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalSum:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalSum:f2}");
            }





        }
    }
}
