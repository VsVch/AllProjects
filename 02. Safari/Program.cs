using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjet = double.Parse(Console.ReadLine());
            double litesFuel = double.Parse(Console.ReadLine());
            string days = Console.ReadLine();

            double sum = litesFuel * 2.1 + 100;
            if (days == "Saturday")
            {
                sum = sum * 0.9;
            }
            else if (days == "Sunday")
            {
                sum = sum * 0.8;
            }

            if (budjet >= sum)
            {
                Console.WriteLine($"Safari time! Money left: {(budjet-sum):f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {(sum-budjet):f2} lv.");
            }


        }
    }
}
