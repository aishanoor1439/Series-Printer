using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Odd Series
            Console.Write("Enter the limit for the odd series: ");
            int oddLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Odd series up to " + oddLimit + ":");
            for (int i = 1; i <= oddLimit; i += 2)
            {
                Console.Write(i);
                if (i + 2 <= oddLimit)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            // Even Series
            Console.Write("Enter the limit for the even series: ");
            int evenLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Even series up to " + evenLimit + ":");
            for (int i = 0; i <= evenLimit; i += 2)
            {
                Console.Write(i);
                if (i + 2 <= evenLimit)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            // Arithmetic Series
            Console.WriteLine("First 10 terms of an arithmetic series when a1 = -2 and d = 2.5:");
            double a1 = -2;
            double d = 2.5;
            for (int i = 0; i < 10; i++)
            {
                double term = a1 + i * d;
                Console.Write(term);
                if (i < 9)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            // Geometric Series
            Console.WriteLine("First 10 terms of a geometric series when a1 = 3 and r = 2:");
            double g1 = 3;
            double r = 2;
            for (int i = 0; i < 10; i++)
            {
                double term = g1 * Math.Pow(r, i);
                Console.Write(term);
                if (i < 9)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

        }
    }
}
