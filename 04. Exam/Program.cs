using System;

namespace _04._Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            double countTopStudents = 0;
            double countVerryGood = 0;
            double countGood = 0;
            double fail = 0;
            double average = 0;

            for (int i = 0; i < numStudents; i++)
            {
                double ocenka = double.Parse(Console.ReadLine());
                average += ocenka;


                if (ocenka >= 5)
                {
                    countTopStudents++;
                }
                if (ocenka < 5 && ocenka >= 4)
                {
                    countVerryGood++;
                }
                if (ocenka < 4 && ocenka >= 3)
                {
                    countGood++;
                }
                if (ocenka < 3)
                {
                    fail++;
                }


            }
            Console.WriteLine($"Top students: {(countTopStudents / numStudents * 100):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(countVerryGood / numStudents *100):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(countGood / numStudents *100):f2}%");
            Console.WriteLine($"Fail: {(fail / numStudents *100):f2}%");
            Console.WriteLine($"Average: {(average / numStudents):f2}");


        }
    }
}
