using System;
using TestIdeas.Easy;
using TestIdeas.Medium;

namespace TestIdeas
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new _4Sum();
            var output = ts.FourSum(new int[] { 1, 0, -1, 0, -2, 2}, 0);

            foreach (var res in output)
            {
                Console.WriteLine(res);
            }

            Console.Read();
        }
    }
}
