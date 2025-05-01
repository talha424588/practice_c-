using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Number 1");
                    if(!double.TryParse(Console.ReadLine(),out num1))
                        {
                            Console.WriteLine("Please enter valid number");
                        continue;
                        }

                    Console.WriteLine("Enter Number 2");

                    if(!double.TryParse(Console.ReadLine(),out num2))
                    {
                        Console.WriteLine("Please enter valid number");
                        continue;
                    }

                    if(num2 == 0)
                    {
                        Console.WriteLine("Please enter non-zero number");
                        continue;

                    }

                    double total = num1 / num2;

                    Console.WriteLine($"Number 1 is {num1}");
                    Console.WriteLine($"Number 2 is {num2}");

                    Console.WriteLine($"devision result { total}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("please enter correct number");
                }
            }

            Console.ReadKey();


            //Console.WriteLine
            //    (Checkout(23.5,33.5,233.3));

        }
        //menthod and params in c#
        static double Checkout(params double[] prices)
        {
            double total = 0;
            foreach(double price in prices)
            {
                total += price;
            };
            return total;
        }
    }
}
