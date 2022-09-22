using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
                double currentMoney = 0;
                while (currentMoney < neededMoney)
                {
                    double newMoney = double.Parse(Console.ReadLine());
                    currentMoney += newMoney;
                }
                

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();

            }
            
        }
    }
}
