using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Factors
    {
        public void FactorNumbers()
        {
            Console.Write("Enter a number to find its prime factors: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Prime factors of {n}:");
            FindPrimeFactors(n);
        }

        public void FindPrimeFactors(int n)
        {
            while (n % 2 == 0)
            {
                Console.Write("2 ");
                n /= 2;
            }
            for (int i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            if (n > 2)
            {
                Console.Write(n);
            }

        }
    }
}
