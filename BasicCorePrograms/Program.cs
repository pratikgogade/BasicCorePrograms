using System;
namespace BasicCoreProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. FlipCoin" + "\n" + "2. Leap Year " + "\n" + "3. Power Of Two" + "\n" + "4. Harmonic Number" + "\n" + "5. Prime Factor" + "\n" + "6. Exit");
                Console.WriteLine("Enter The Above Mention Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin enter = new FlipCoin();
                        enter.Play();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.Leap();
                        break;
                    case 3:
                        PowerOfTwo power = new PowerOfTwo();
                        power.Table();
                        break;
                    case 4:
                        HarmonicNumber number = new HarmonicNumber();
                        number.Harmonic();
                        break;
                    case 5:
                        PrimeFactor prime = new PrimeFactor();
                        prime.Prime();
                        break;
                    case 6:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}