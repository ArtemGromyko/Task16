using System;
using System.Diagnostics;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int x = Gcd.CalculateGcd(Gcd.BinaryAlgorithm, 4, 16, 16, 8);
            sw.Stop();
            Console.WriteLine("x = "+x);
            Console.WriteLine(sw.Elapsed);

            sw.Reset();

            sw.Start();
            int y = Gcd.CalculateGcd(Gcd.EuclideanAlgorithm, 4, 16, 16, 8);
            sw.Stop();
            Console.WriteLine("y = "+y);
            Console.WriteLine(sw.Elapsed);
        }
    }
}
