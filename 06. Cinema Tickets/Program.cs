using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameMovie = Console.ReadLine();
            double student = 0;
            double standard = 0;
            double kid = 0;
            double sum = 0;

            while (nameMovie != "Finish")
            {
                double numberFreeSeats = double.Parse(Console.ReadLine());
                double current = 0;

                string typeTicket = Console.ReadLine();
                while (typeTicket != "End")
                {
                    current++;
                    sum++;
                    switch (typeTicket)
                    {
                        case "student":
                            student++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kid++;
                            break;

                        default:
                            break;
                    }
                    if (current >= numberFreeSeats)
                    {
                        
                        break;
                    }
                    

                    typeTicket = Console.ReadLine();
                }
                Console.WriteLine($"{nameMovie} - {current/numberFreeSeats*100:f2}% full.");

                nameMovie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {sum}");
            Console.WriteLine($"{student/sum*100:f2}% student tickets.");
            Console.WriteLine($"{standard/sum*100:f2}% standard tickets.");
            Console.WriteLine($"{kid/sum*100:f2}% kids tickets.");


        }
    }
}