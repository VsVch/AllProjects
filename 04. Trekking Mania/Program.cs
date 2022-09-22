using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {

            int numPeople = int.Parse(Console.ReadLine());
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everet = 0;
            double total = 0;

            for (int i = 0; i < numPeople; i++)
            {
                int people = int.Parse(Console.ReadLine());
                total += people;
                if (people < 6)
                {
                    musala += people;
                }
                if (people >= 6 && people < 13)
                {
                    monblan += people;
                }
                if (people >= 13 && people < 26)
                {
                    kilimandjaro += people;
                }
                if (people >= 26 && people < 41)
                {
                    k2 += people;
                }
                if (people >= 41)
                {
                    everet += people;
                }
                
            }
            Console.WriteLine($"{musala/total*100:f2}%");
            Console.WriteLine($"{monblan / total * 100:f2}%");
            Console.WriteLine($"{kilimandjaro / total * 100:f2}%");
            Console.WriteLine($"{k2 / total * 100:f2}%");
            Console.WriteLine($"{everet / total * 100:f2}%");





        }
    }
}
