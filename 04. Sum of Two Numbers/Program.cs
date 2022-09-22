using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp109
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            bool isis = true;



            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {

                    br++;
                    if (i + j == n)
                    {
                        Console.WriteLine($"Combination N:{br} ({i} + {j} = {n})");
                        i = secondNumber;
                        isis = false;
                        break;

                        

                    }
                    
                }

                


            }

            if (isis)
            {
                Console.WriteLine($"{br} combinations - neither equals {n}");
            }

            




        }
    }
}
