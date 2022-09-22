using System;

namespace _01._Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPepar = int.Parse(Console.ReadLine());
            int countDress = int.Parse(Console.ReadLine());
            double litreGlues = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pricePepar = countPepar * 5.8;
            double priceDress = countDress * 7.2;
            double priceGlues = litreGlues * 1.2;
            double allPrice = pricePepar + priceDress + priceGlues;
            
            allPrice = allPrice -  allPrice * discount / 100;
            Console.WriteLine($"{allPrice:f3}");








        }
    }
}
