using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP2_1_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            const string separater = " ";
            var qLine = System.Console.ReadLine().Split(' ');
            var n = int.Parse(qLine[0]);
            var q = int.Parse(qLine[1]);

            var list = new List<int>[n];
            for(int i = 0; i < list.Length; i++) {
                list[i] = new List<int>();
            }

            for (int i = 0; i < q; i++)
            {
                var line = System.Console.ReadLine().Split(' ');
                var command = line[0];
                var t = int.Parse(line[1]);

                // pushBack
                if (command == "0") {
                    var x = int.Parse(line[2]);
                    list[t].Add(x);

                    continue;
                }

                // dump
                if (command == "1") {
                    if (list[t].Any()) {
                        Console.WriteLine(string.Join(separater, list[t]));
                    } else {
                        Console.WriteLine(String.Empty);
                    }
                    continue;
                }

                // clear
                list[t].Clear();
            }

            Console.Out.Flush();
        }
    }
}
