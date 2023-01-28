using System;

using HotelReservation;

namespace Working_With_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestProblem4();
        }

        static void TestProblem4()
        {
            PriceCalculator t1 = new PriceCalculator(25, 5, Season.Spring, Discount.VIP);
            Console.WriteLine($"Here is your final price: {PriceCalculator.Calculate(t1)}");
        }
    }
}