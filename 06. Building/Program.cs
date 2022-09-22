using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numH = int.Parse(Console.ReadLine());
            int numN = int.Parse(Console.ReadLine());

            for (int i = numH; i >= 1; i--)
            {
                for (int j = 0; j < numN; j++)
                {
                    if (i == numH)
                    {
                        Console.Write($"L{i}{j} ");
                        continue;
                    }


                    if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }


                Console.WriteLine();

            }
           



        }
    }
}
