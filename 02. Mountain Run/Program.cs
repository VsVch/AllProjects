using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {

            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOnemetres = double.Parse(Console.ReadLine());

            double newFullTime = distance * timeForOnemetres + Math.Floor(1.0*distance/50)*30;


            


            if (newFullTime < record)
            {
                Console.WriteLine($"Yes! The new record is {newFullTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(newFullTime-record):f2} seconds slower.");
            }





        }
    }
}
