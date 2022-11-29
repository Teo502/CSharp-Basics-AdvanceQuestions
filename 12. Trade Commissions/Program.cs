using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commsion = 0;
            
            switch (town)
            {
                case "Sofia":
                    if (0 <= sales && sales <= 500)
                    {
                        commsion = 0.05;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commsion = 0.07;
                    } else if (sales > 1000 & sales <= 10000)
                    {
                        commsion = 0.08;
                    } else if (sales > 10000)
                    {
                        commsion = 0.12;
                    }
                    break;
                case "Plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        commsion = 0.055;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commsion = 0.08;
                    }
                    else if (sales > 1000 & sales <= 10000)
                    {
                        commsion = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commsion = 0.145;
                    }
                    break;
                case "Varna":
                    if (0 <= sales && sales <= 500)
                    {
                        commsion = 0.045;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commsion = 0.075;
                    }
                    else if (sales > 1000 & sales <= 10000)
                    {
                        commsion = 0.1;
                    }
                    else if (sales > 10000)
                    {
                        commsion = 0.13;
                    } else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                    default:
                    Console.WriteLine("error");
                    break;

            }
            double totalSum = sales * commsion;
            if (commsion > 0)
            {
                Console.WriteLine($"{totalSum:f2}");
            }
        }
    }
}
