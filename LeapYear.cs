using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.Write("Enter a year: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int year) && input.Length == 4)
            {
                bool isLeapYear = IsLeapYear(year);

                if (isLeapYear)
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a four-digit year.");
            }
        }
        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
