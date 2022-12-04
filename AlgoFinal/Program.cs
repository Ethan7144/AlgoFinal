using System;
using System.IO;
using System.Collections.Generic;
namespace AlgoFinal
{
    class Intractable
    {
        static int findMinbin(int[] weights, int maxWeight)
        {
            int min = 0;
            Array.Sort(weights);

            bool[] visited = new bool[weights.Length];
            int processed = 0;

            if (weights.Length == 1) return 1;

            while (processed != weights.Length)
            {
                int weightSum = 0;
                for (int j = weights.Length - 1; j >= 0; j--)
                {
                    if (!visited[j] && weightSum < maxWeight)
                    {
                        weightSum += weights[j];
                        visited[j] = true;
                        processed++;
                        if (weightSum > maxWeight)
                        {
                            visited[j] = false;
                            processed--;
                            weightSum -= weights[j];
                            break;
                        }
                    }
                }
                for (int i = 0; i < weights.Length; i++)
                {
                    if (!visited[i] && weightSum < maxWeight)
                    {
                        weightSum += weights[i];
                        visited[i] = true;
                        processed++;
                        if (weightSum > maxWeight)
                        {
                            visited[i] = false;
                            processed--;
                            break;
                        }
                    }
                }
                min++;
            }
            Console.WriteLine("Minimum Bin(s) needed: " + min);
            return min;
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            int size = 10000;
            int k = 100;
            int[] weight = new int[size];
            for (int i = 0; i < weight.Length; i++)
                weight[i] = rng.Next(1, 100);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            findMinbin(weight, k);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}

