﻿using System;

namespace FirstFit
{
    class FinalProject2
    {
        static int FirstFit(int[] weight, int maxWeight)
        {
            
        }
        public static void Main(string[] args)
        {
            Random rng = new Random();
            int size = 100;
            int k = 100;

            int[] weight = new int[size];
            for (int i = 0; i < weight.Length; i++)
                weight[i] = rng.Next(1, 100);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Bin(s) needed: " + FirstFit(weight, k));
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
