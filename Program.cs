namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlipCoin flipCoin = new FlipCoin();
            flipCoin.FlipCoinNumber();
            Console.WriteLine("--------------------");

            LeapYear leapYear = new LeapYear();
            leapYear.CheckLeapYear();
            Console.WriteLine("--------------------");

            HarmonicNumber harmonicNumber = new HarmonicNumber();
            harmonicNumber.Harmonic();
            Console.WriteLine("--------------------");

            Factors factors = new Factors();
            factors.FactorNumbers();
            Console.WriteLine("--------------------");

            Math math = new Math();
            math.Math1();
            math.Math2();
            math.Math3();
        }
    }
}