using System;

namespace _02._Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            double minKontrola = double.Parse(Console.ReadLine());
            double secKontrola = double.Parse(Console.ReadLine());
            double lUlei = double.Parse(Console.ReadLine());
            double secPer100 = double.Parse(Console.ReadLine());

            double kontrolaSec = minKontrola * 60 + secKontrola;
            double timeNamalee = lUlei / 120;
            timeNamalee = timeNamalee * 2.5;
            double totalTime = (lUlei / 100) * secPer100 - timeNamalee;

            if (totalTime <= kontrolaSec)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {totalTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(totalTime-kontrolaSec):f3} second slower.");
            }







        }
    }
}
