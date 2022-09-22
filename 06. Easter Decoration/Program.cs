using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {

            int cutomers = int.Parse(Console.ReadLine());
            int num = 0;
            double sum = 0;
            for (int i = 0; i < cutomers; i++)
            {
                int currentNum = 0;
                double currentSum = 0;
                string kindBays = Console.ReadLine();

                while (kindBays != "Finish")
                {
                    currentNum++;
                    num++;
                    switch (kindBays)
                    {
                        case "basket":
                            currentSum += 1.5;
                            
                            break;
                        case "wreath":
                            currentSum += 3.8;
                            
                            break;
                        case "chocolate bunny":
                            currentSum += 7;
                            
                            break;

                        default:
                            break;
                    }
                   

                    kindBays = Console.ReadLine();
                }

                if (currentNum % 2 == 0)
                {
                    currentSum = currentSum * 0.8;

                }
                sum += currentSum;

                Console.WriteLine($"You purchased {currentNum} items for {currentSum:f2} leva.");



            }


            Console.WriteLine($"Average bill per client is: {sum / cutomers :f2} leva.");








        }
    }
}
