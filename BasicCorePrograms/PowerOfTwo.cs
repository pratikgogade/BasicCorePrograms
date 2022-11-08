using System;
namespace BasicCoreProgram
{
    public class PowerOfTwo
    {
        public void Table()
        {
            Console.WriteLine("Enter the value ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N && N < 32; i++)
            {
                double number = Math.Pow(2, i);
                Console.WriteLine("2^" + i + " = " + number);
            }

        }
    }
}