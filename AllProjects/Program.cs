using System;

namespace AllProjects
{
    class Program
    {
        static void Main(string[] args)
        {

            int numBitcoins = int.Parse(Console.ReadLine());
            double numJChinaUana = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            double sum = numBitcoins * 1168 + numJChinaUana * 0.15 * 1.76;
            sum = sum / 1.95;
            sum = sum * 0.95;

            Console.WriteLine($"{sum:f2}");





        }
    }
}
