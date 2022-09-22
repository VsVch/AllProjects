using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            double entrance = double.Parse(Console.ReadLine());
            double priceShezlong = double.Parse(Console.ReadLine());
            double priceUmbrela = double.Parse(Console.ReadLine());


            double shezlong = Math.Ceiling(0.75*numPeople);
            double umbrela = Math.Ceiling(0.5*numPeople);

            double sum = numPeople * entrance + shezlong * priceShezlong + umbrela *priceUmbrela;

            Console.WriteLine($"{sum:f2} lv.");



        }
    }
}
