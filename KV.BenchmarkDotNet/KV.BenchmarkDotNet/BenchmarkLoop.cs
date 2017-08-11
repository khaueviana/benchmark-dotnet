using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using BenchmarkDotNet.Attributes;

namespace KV.BenchmarkDotNet
{
    public class BenchmarkLoop
    {
        [Benchmark]
        public List<Item> GenerateDataWithFor()
        {
            var list = new List<Item>();

            for (var i = 0; i < 1000000; i++)
            {
                list.Add(new Item
                {
                    Id = Guid.NewGuid(),
                    Name = i.ToString()
                });
            }

            return list;
        }

        [Benchmark]
        public List<Item> GenerateDataWithWhile()
        {
            var list = new List<Item>();

            var i = 1;

            while (i <= 1000000)
            {
                list.Add(new Item
                {
                    Id = Guid.NewGuid(),
                    Name = i.ToString()
                });

                i++;
            }

            return list;
        }
    }
}