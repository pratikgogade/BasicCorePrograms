using System;
namespace BasicCoreProgram
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter the Year - ____");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 || year % 400 == 0) && year % 100 != 0)
                Console.WriteLine("Year " + year + " is Leap Year");
            else
                Console.WriteLine("Year is not a Leap Year");
        }
    }
}