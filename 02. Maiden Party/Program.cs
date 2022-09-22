using System;

namespace _02._Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceGirlParty = double.Parse(Console.ReadLine());
            int numLoveMesseges = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keysHolder = int.Parse(Console.ReadLine());
            int jokePictures = int.Parse(Console.ReadLine());
            int luckSurpice = int.Parse(Console.ReadLine());

            double sum = numLoveMesseges * 0.6 + roses * 7.2 + keysHolder * 3.6 + jokePictures * 18.2 + luckSurpice * 22;
            int all = numLoveMesseges + roses + keysHolder + jokePictures + luckSurpice;

            if (all >= 25)
            {
                sum = sum * .65;
            }

            double hosting = sum * 0.1;

            sum = sum - hosting;

            if (sum >= priceGirlParty)
            {
                Console.WriteLine($"Yes! {(sum - priceGirlParty):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(priceGirlParty - sum):f2} lv needed.");
            }



        }
    }
}
