using System;
using System.Collections.Generic;

namespace ITP1_6_A
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

            intList.Reverse();

            var result = "";
            for (var i = 0; i < numberCount; i++) {
                if (i == 0) {
                    result += intList[i].ToString();
                    continue;
                }

                result += " " + intList[i].ToString();
            }

            Console.WriteLine($"{result}");
        }
    }
}
