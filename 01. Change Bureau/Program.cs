using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {


            int numBitcoins = int.Parse(Console.ReadLine());
            double numJuana = double.Parse(Console.ReadLine());
            double comsion = double.Parse(Console.ReadLine());

            double sum = (numBitcoins * 1168 + numJuana * 0.15 * 1.76) / 1.95;
            sum = sum - sum * comsion / 100;

            Console.WriteLine($"{sum:f2}");





        }
    }
}
