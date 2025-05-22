using System;
using System.Diagnostics;

namespace DemoConsole {
    class Program {
        static void Main(string[] args) {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            PrimeCalculator.PrimeCalculator.CalculatePrimes(1000000);

            watch.Stop();
            Console.WriteLine($"Elapsed milliseconds: {watch.ElapsedMilliseconds}");

            Console.ReadLine();
        }
    }
}
