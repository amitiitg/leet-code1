using System;

namespace TestIdeas
{
    class Program
    {
        static void Main(string[] args)
        {
            var atoi = new AtoI();
            Console.WriteLine(atoi.MyAtoi("2147483648"));
            Console.WriteLine(atoi.MyAtoi("12"));
            Console.WriteLine(atoi.MyAtoi("w"));
        }
    }
}
