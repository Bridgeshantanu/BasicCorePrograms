using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.Write("Enter the harmonic value (n): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n != 0)
            {
                double harmonicNumber = 0;
                for (int i = 1; i <= n; i++)
                {
                    harmonicNumber += 1.0 / i;
                }
                Console.WriteLine($"The {n}th harmonic number is: {harmonicNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-zero integer.");
            }
        }
    }
}
