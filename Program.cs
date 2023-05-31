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



        }
    }
}