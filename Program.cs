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

            


            try
            {
                Console.WriteLine("Enter Number 1");
                double num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Enter Number 2");
                double num2 = Convert.ToInt32(Console.ReadLine());

                double total = num1 / num2;

                Console.WriteLine("devision result " + total);
            }
            catch (FormatException) {
                Console.WriteLine("please enter correct number");
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
