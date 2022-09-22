using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int s4 = num1 % 10;
            int s3 = num1 % 100 / 10;
            int s2 = num1 / 100 % 10;
            int s1 = num1 /1000;

            
            int d4 = num2 % 10;
            int d3 = num2 % 100 / 10;
            int d2 = num2 / 100 % 10;
            int d1 = num2 / 1000;


            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {

                            if (i % 2 != 0 && s1 <= i && d1 >=i)
                            {
                                if ((j % 2 !=0 ) && s2 <= j && d2 >= j)
                                {
                                    if ((k % 2 != 0 ) && s3 <= k && d3 >= k)
                                    {
                                        if ((m % 2 != 0 ) && s4 <= m && d4 >= m)
                                        {

                                            Console.Write("" + i + j + k + m + " ");

                                        }
                                    }
                                }
                            }


                        }
                    }
                }
            }





        }
    }
}
