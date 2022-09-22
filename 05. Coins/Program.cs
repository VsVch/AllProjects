using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {

            double resto = double.Parse(Console.ReadLine());
            resto = Math.Floor(resto*100);
            int br = 0;
            while (resto>0)
            {
                while (resto >= 200)
                {
                    resto = resto - 200;
                    br++;
                }
                while (resto >= 100)
                {
                    resto = resto - 100;
                    br++;
                }
                while (resto >= 50)
                {
                    resto = resto - 50;
                    br++;
                }
                while (resto >= 20)
                {
                    resto = resto - 20;
                    br++;
                }
                while (resto >= 10)
                {
                    resto = resto - 10;
                    br++;
                }
                while (resto >= 5)
                {
                    resto = resto - 5;
                    br++;
                }
                while (resto >= 2)
                {
                    resto = resto - 2;
                    br++;
                }
                while (resto >= 1)
                {
                    resto = resto - 1;
                    br++;
                }

            }

            


            Console.WriteLine(br);








        }
    }
}
