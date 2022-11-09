using System;
namespace BasicCoreProgram
{
    public class QuoteintAndRemainder
    {
        public void Quotient()
        {
            Console.WriteLine("Enter Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = (dividend / divisor);
            int reminder = (dividend % divisor);
            Console.WriteLine("Quotient is  " + quotient);
            Console.WriteLine("Remainder is " + reminder);
        }
    }
}