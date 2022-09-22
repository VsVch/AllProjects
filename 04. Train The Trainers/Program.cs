using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double all = 0;
            int br = 0;


            string presentation = Console.ReadLine();

            while (presentation != "Finish")
            {
                double sum = 0;

                for (int i = 0; i < n; i++)
                {
                    double current = double.Parse(Console.ReadLine());
                    sum += current;
                    all += current;
                    br++;

                }
                Console.WriteLine($"{presentation} - {sum/n:f2}.");




                presentation = Console.ReadLine();
            }


            if (presentation == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {all/br:f2}.");
            }













            
        }
    }
}
