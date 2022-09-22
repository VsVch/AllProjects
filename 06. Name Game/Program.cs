using System;

namespace _06._Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int maxSum = 0;
            string maxName =string.Empty;



            while (name != "Stop")
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    int letter = int.Parse(Console.ReadLine());


                    if (letter == name[i])
                    {
                        sum += 10;
                    }
                    else
                    {
                        sum += 2;
                    }

                    if (sum >= maxSum)
                    {
                        maxSum = sum;
                        maxName = name;
                    }



                }



                name = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {maxName} with {maxSum} points!");
        }
    }
}
