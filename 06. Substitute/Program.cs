using System;

namespace _06._Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int br = 0;

            for (int i = k; i <= 8; i++)
            {
                for (int j = 9; j >= l; j--)
                {

                    for (int e = m; e <= 8; e++)
                    {
                        for (int y = 9; y >= n; y--)
                        {
                            if (i % 2 == 0 && e % 2 == 0 & j % 2 != 0 && y % 2 != 0 && br < 6)
                            {



                                
                                {
                                    if (i == e && j == y)
                                    {
                                        Console.WriteLine($"Cannot change the same player.");

                                    }
                                    else
                                    {
                                        Console.WriteLine($"{i}{j} - {e}{y}");
                                        br++;

                                    }

                                   
                                }




                                

                               
                            }
                            

                        }
                    }
                }
            }





        }
    }
}
