using System;

namespace _01._Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double naem = double.Parse(Console.ReadLine());

            double sum = naem + (naem * 0.2) + naem * 0.2 * .55 + naem / 3;
            Console.WriteLine($"{sum}");
        }
    }
}
