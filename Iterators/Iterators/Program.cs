using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersGenerator nrGen = new NumbersGenerator();
            EvenNumbersGenerator evenGen = new EvenNumbersGenerator(nrGen);

            int maxCount = 10;
            int currentCount = 0;
            foreach (int nr in evenGen)
            {
                Console.WriteLine($"Nr={nr}");
                currentCount++;
                if (currentCount >= maxCount)
                {
                    break;
                }
            }
        }

        private static void PerfComparison_Between_IEnumerableAndRawLoop()
        {
            Stopwatch watch1 = Stopwatch.StartNew();
            foreach (int element in Fibonacci.Get(10))
            {
                Console.Write($"{element}, ");
            }
            watch1.Stop();
            Console.WriteLine($"Fibo with IEnumerable: {watch1.ElapsedMilliseconds}");


            Stopwatch watch2 = Stopwatch.StartNew();
            foreach (int element in Fibonacci.GetClassic(10))
            {
                Console.Write($"{element}, ");
            }
            watch2.Stop();
            Console.WriteLine($"Fibo (classic): {watch2.ElapsedMilliseconds}");
        }
    }
}
