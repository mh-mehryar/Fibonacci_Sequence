using System;
using System.Collections.Generic;

namespace fibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNum = new List<int> { 1, 1 };

            while (fibonacciNum.Count < 20)
            {
                var previous = fibonacciNum[fibonacciNum.Count - 1];
                var previous2 = fibonacciNum[fibonacciNum.Count - 2];

                fibonacciNum.Add(previous + previous2);
            }

            foreach (var item in fibonacciNum)
            {
                Console.WriteLine(item);
            }
        }
    }
}
