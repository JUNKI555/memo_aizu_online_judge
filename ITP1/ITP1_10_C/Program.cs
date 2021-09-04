using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP1_10_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var continueFlag = true;
            while (continueFlag) {
                var n = int.Parse(System.Console.ReadLine());
                if (n == 0) {
                    continueFlag = false;
                    continue;
                }

                var numberList = new List<double>();
                var line = System.Console.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    numberList.Add(double.Parse(line[i]));
                }
                Console.WriteLine(calcStdev(numberList).ToString("F13"));
            }

            Console.Out.Flush();
        }

        // https://qiita.com/c60evaporator/items/59ad0dbebc53c742a4c9
        static double calcStdev(List<double> list) {
            var average = list.Average();   // 平均
            var sum2 = list.Select(x => x * x).Sum();   // 自乗和
            var variance = (sum2 / list.Count) - (average * average);   // 分散 = 自乗和 / 要素数 - 平均値^2
            return Math.Sqrt(variance);
        }
    }
}
