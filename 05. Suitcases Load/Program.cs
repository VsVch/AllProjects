using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {

            double capacity = double.Parse(Console.ReadLine());
            int br = 0;
            int totalBr = 0;
            double totalObem = 0;

            string imput = Console.ReadLine();
            while (imput != "End")
            {
                double obem = double.Parse(imput);
                br++;
                totalBr++;
                if (br == 3)
                {
                    obem = obem + obem * 0.1;
                    br = 0;
                }
                totalObem += obem;
                if (totalObem > capacity)
                {
                    Console.WriteLine($"No more space!");
                    totalBr = totalBr - 1;
                    break;
                }

                imput = Console.ReadLine();
            }
            if (imput == "End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {totalBr} suitcases loaded.");



        }
    }
}
