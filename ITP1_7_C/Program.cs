using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP1_7_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var qLine = System.Console.ReadLine().Split(' ');
            var r = int.Parse(qLine[0]);
            var c = int.Parse(qLine[1]);
            const string space = " ";

            var colSumList = new int[c];
            for(int j = 0; j < c; j++) {
                colSumList[j] = 0;
            }

            for(int i = 0; i < r; i++) {
                var row = new List<int>();
                var line = System.Console.ReadLine().Split(' ');
                for(int j = 0; j < c; j++) {
                    var number = int.Parse(line[j]);
                    row.Add(number);
                    colSumList[j] += number;
                }

                var rowResult = String.Join(space, row);
                rowResult += (space + row.Sum().ToString());
                Console.WriteLine(rowResult);
            }

            var result = String.Join(space, colSumList);
            result += (space + colSumList.Sum().ToString());
            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
