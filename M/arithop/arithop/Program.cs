using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arithop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a two number : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int sum;

            sum = x1 + x2;
            Console.WriteLine("Addition : " + sum);
            sum = x1 - x2;
            Console.WriteLine("Subtraction: " + sum);
            sum = x1 * x2;
            Console.WriteLine("Multiplication : " + sum);
            sum = x1 / x2;
            Console.WriteLine("Division : " + sum);
            sum = x1 % x2;
            Console.WriteLine("modules:"+ sum);

            Console.Read();
        }
    }
}
