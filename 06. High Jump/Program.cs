using System;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int desireHigh = int.Parse(Console.ReadLine());
            int total = 0;
            int fail = 0;

            for (int startHigh = desireHigh - 30; startHigh <= desireHigh; startHigh += 5)
            {
                for (int i = 0; i < 3; i++)
                {
                    int newHigh = int.Parse(Console.ReadLine());
                    total++;
                    if (newHigh > startHigh)
                    {
                        fail = 0;
                        break;
                    }
                    else
                    {
                        fail++;
                    }




                    if (fail == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {startHigh}cm after {total} jumps.");
                        return;
                    }

                }





            }

            Console.WriteLine($"Tihomir succeeded, he jumped over {desireHigh}cm after {total} jumps.");
        }
    }
}
