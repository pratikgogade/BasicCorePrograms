using System;
namespace BasicCoreProgram
{
    public class VowelConsonant
    {
        public void Vowels()
        {
            Console.Write("Input an Alphabet: ");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());

            switch (ch)

            {
                case 'a':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("Alphabet is consonant");
                    break;
            }
        }

    }
}