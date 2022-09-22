using System;

namespace _06._Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameMovie = Console.ReadLine();
            int br = 1;
            string bestMovie = string.Empty;
            int bestSum = 0;

            while (nameMovie != "STOP")
            {
                    int sum = 0;
                    
                    for (int i = 0; i < nameMovie.Length; i++)
                    {
                        if (char.IsUpper(nameMovie[i]))
                        {
                            sum += nameMovie[i] - nameMovie.Length;
                        }

                        else if (char.IsLower(nameMovie[i]))
                        {
                            sum += nameMovie[i] - 2 * nameMovie.Length;
                        }
                        else
                        {
                            sum += nameMovie[i];
                        }
                    }

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestMovie = nameMovie;
                    }
                nameMovie = Console.ReadLine();
                br++;
                if (br > 7)
                {
                    Console.WriteLine($"The limit is reached.");
                    break;
                }

            }
            Console.WriteLine($"The best movie for you is {bestMovie} with {bestSum} ASCII sum.");
        }
    }
}
