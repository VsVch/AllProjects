using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string sizeSnow = Console.ReadLine();
            int numSet = int.Parse(Console.ReadLine());
            double price = 0;

            switch (fruit)
            {
                case "Watermelon":
                    switch (sizeSnow)
                    {
                        case "small":
                            price = 2*56;
                            break;
                        case "big":
                            price = 5*28.7;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Mango":
                    switch (sizeSnow)
                    {
                        case "small":
                            price = 2*36.66;
                            break;
                        case "big":
                            price = 5*19.6;
                            break;

                        default:
                            break;
                    }
                    break;
                    
                case "Pineapple":
                    switch (sizeSnow)
                    {
                        case "small":
                            price = 2*42.1;
                            break;
                        case "big":
                            price = 5*24.8;
                            break;

                        default:
                            break;
                    }
                    break;
                    
                case "Raspberry":
                    switch (sizeSnow)
                    {
                        case "small":
                            price = 2*20;
                            break;
                        case "big":
                            price = 5*15.2;
                            break;

                        default:
                            break;
                    }
                    break;
                   




                default:
                    break;
            }

            double sum = price * numSet;
            if (sum>=400 && sum<= 1000)
            {
                sum = sum * .85;
            }
            if (sum>1000)
            {
                sum = sum / 2;
            }

            Console.WriteLine($"{sum:f2} lv.");



        }
    }
}
