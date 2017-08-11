using System;
using BenchmarkDotNet.Running;

namespace KV.BenchmarkDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchmarkLoop>();

            Console.ReadKey();
        }
    }
}