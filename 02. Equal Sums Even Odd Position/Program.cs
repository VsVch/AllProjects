using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            

            for (int i = first; i <= second; i++)
            {
                string iii = i.ToString();
                int sum1 = 0;
                int sum2 = 0;
                for (int k = 0; k < iii.Length; k++)
                {
                    if (k % 2 == 0)
                    {
                        sum1 += int.Parse(iii[k].ToString());
                    }
                    else
                    {
                        sum2 += int.Parse(iii[k].ToString());
                    }

                   

                }

                if (sum1 == sum2)
                {
                    Console.Write($"{i } ");
                }

            }





        }
    }
}
