﻿using System;

namespace Nested_Loops___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (current > n)
                    {

                        break;

                    }
                    Console.Write($"{current } ");
                    current++;

                }
                
                Console.WriteLine();
            }
            
        }
    }
}
