using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Math
    {
        public void Math1()
        {
            Console.Write("Enter the dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
        }
        public void Math2()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapping: a = {a}, b = {b}");


            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swapping: a = {a}, b = {b}");
        }
        public void Math3()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
