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
                Console.WriteLine("1. FlipCoin" + "\n" + "2. Leap Year " + "\n" + "3. Power Of Two" + "\n" + "4. Harmonic Number" + "\n" + "5. Prime Factor" + "\n" + "6. Find Quoteint and Remainder" + "\n" + "7. Swapping Two Numbers" + "\n" + "8. Find Even or Odd Number" + "\n" + "9.Find Alphabets - Vowel Consonant" + "\n" + "10. Largest Among Three Numbers" + "\n" + "11. Exit");
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
                        QuoteintAndRemainder quo = new QuoteintAndRemainder();
                        quo.Quotient();
                        break;
                    case 7:
                        SwapTwoNumbers swa = new SwapTwoNumbers();
                        swa.Swap();
                        break;
                    case 8:
                        EvenOdd eve = new EvenOdd();
                        eve.Number();
                        break;
                    case 9:
                        VowelConsonant vow = new VowelConsonant();
                        vow.Vowels();
                        break;
                    case 10:
                        LargestAmong3Numbers lar = new LargestAmong3Numbers();
                        lar.Largest();
                        break;
                    case 11:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}