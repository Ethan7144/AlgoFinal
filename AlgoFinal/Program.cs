using System;
using System.IO;
using System.Collections.Generic;
namespace AlgoFinal
{
    class Intractable
    {
        static int findMinbin(int[] weights, int maxWeight)
        {
          
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            int size = 100;
            int k = 100;
            int[] weight = new int[size];
            for (int i = 0; i < weight.Length; i++)
                weight[i] = rng.Next(1, 1000);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            findMinbin(weight, k);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}

