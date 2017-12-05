using Amazon;

namespace AccessModifiersSection4
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}
