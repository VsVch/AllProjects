﻿using System;

namespace _03._Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {


            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            double price = 0;
            switch (size)
            {
                case "Large":
                    switch (color)
                    {
                        case "Red":
                            price = 16;
                            break;
                        case "Green":
                            price = 12;
                            break;
                        case "Yellow":
                            price = 9;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Medium":
                    switch (color)
                    {
                        case "Red":
                            price = 13;
                            break;
                        case "Green":
                            price = 9;
                            break;
                        case "Yellow":
                            price = 7;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Small":
                    switch (color)
                    {
                        case "Red":
                            price = 9;
                            break;
                        case "Green":
                            price = 8;
                            break;
                        case "Yellow":
                            price = 5;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


            price = price * num;
            price = price * .65;
            Console.WriteLine($"{price:f2} leva.");




        }
    }
}
