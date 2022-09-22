using System;

namespace _05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int Back = 0;
            int Chest = 0;
            int Legs = 0;
            int Abs = 0;
            int ProteinShake = 0;
            int ProteinBar = 0;
            
            for (int i = 0; i < num; i++)
            {
                string jobInFitnes = Console.ReadLine();
                switch (jobInFitnes)
                {
                    case "Back":
                        Back++;
                        break;
                    case "Chest":
                        Chest++;
                        break;
                    case "Legs":
                        Legs++;
                        break;
                    case "Abs":
                        Abs++;
                        break;
                    case "Protein shake":
                        ProteinShake++;
                        break;
                    case "Protein bar":
                        ProteinBar++;
                        break;
                    default:
                        break;
                }
                
            }

            Console.WriteLine($"{Back} - back");
            Console.WriteLine($"{Chest} - chest");
            Console.WriteLine($"{Legs} - legs");
            Console.WriteLine($"{Abs} - abs");
            Console.WriteLine($"{ProteinShake} - protein shake");
            Console.WriteLine($"{ProteinBar} - protein bar");
            Console.WriteLine($"{1.0*(Back+Chest+Legs+Abs)/num*100:f2}% - work out");
            Console.WriteLine($"{1.0*(ProteinBar+ProteinShake)/num*100:f2}% - protein");









        }
    }
}
