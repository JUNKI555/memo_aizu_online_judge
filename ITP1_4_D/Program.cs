using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP1_4_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(System.Console.ReadLine());

            var line = System.Console.ReadLine().Split(' ');
            var intList = new List<decimal>();
            for (var i = 0; i < numberCount; i++) {
                intList.Add(decimal.Parse(line[i]));
            }

            Console.WriteLine($"{intList.Min()} {intList.Max()} {intList.Sum()}");
        }
    }
}
