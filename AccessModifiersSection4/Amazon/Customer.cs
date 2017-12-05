using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate();

            Console.WriteLine("Promote logic changed.");
        }
    }
}