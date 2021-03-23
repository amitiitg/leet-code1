using System;

namespace TestIdeas
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new IsPalindrome();
            var output = ts.IsPalindromeInt(121);
            Console.Write(output);
            Console.Read();
        }
    }
}
