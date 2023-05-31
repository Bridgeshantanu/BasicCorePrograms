using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        public void FlipCoinNumber()
        {
            Console.Write("Enter the number of times to flip the coin: ");
            int numFlips;
            bool isValidInput = int.TryParse(Console.ReadLine(), out numFlips);

            if (isValidInput && numFlips > 0)
            {
                Random random = new Random();
                int headsCount = 0;
                int tailsCount = 0;

                for (int i = 0; i < numFlips; i++)
                {
                    double randomValue = random.NextDouble();
                    if (randomValue < 0.5)
                    {
                        headsCount++;
                    }
                    else
                    {
                        tailsCount++;
                    }
                }

                double headsPercentage = (double)headsCount / numFlips * 100;
                double tailsPercentage = (double)tailsCount / numFlips * 100;

                Console.WriteLine($"Heads: {headsPercentage}%");
                Console.WriteLine($"Tails: {tailsPercentage}%");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}
