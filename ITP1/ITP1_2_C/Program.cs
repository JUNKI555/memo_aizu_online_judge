using System;
using System.Collections.Generic;

namespace ITP1_2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split(' ');
            var intList = new List<int>();
            intList.Add(int.Parse(line[0]));
            intList.Add(int.Parse(line[1]));
            intList.Add(int.Parse(line[2]));
            intList.Sort();

            Console.WriteLine($"{intList[0]} {intList[1]} {intList[2]}");
        }
    }
}
