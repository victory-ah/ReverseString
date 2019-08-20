using System;

namespace ReverseString
{
    class Program
    {
        public static string ReverseString(string phrase)
        {
            string result = ("");
            for (int i = phrase.Length-1; i >= 0; i--)
            {
                result += phrase[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write a phrase that you want reversed");
            Console.WriteLine(ReverseString(Console.ReadLine()));
        }
    }
}
