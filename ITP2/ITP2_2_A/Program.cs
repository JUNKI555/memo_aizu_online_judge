using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP2_2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var qLine = System.Console.ReadLine().Split(' ');
            var n = int.Parse(qLine[0]);
            var q = int.Parse(qLine[1]);

            var stacks = new Stack<int>[n];
            for(int i = 0; i < stacks.Length; i++) {
                stacks[i] = new Stack<int>();
            }

            for (int i = 0; i < q; i++)
            {
                var line = System.Console.ReadLine().Split(' ');
                var command = line[0];
                var t = int.Parse(line[1]);

                // push
                if (command == "0") {
                    var x = int.Parse(line[2]);
                    stacks[t].Push(x);
                    continue;
                }

                // top
                if (command == "1") {
                    if (stacks[t].Any()) {
                        Console.WriteLine(stacks[t].Peek().ToString());
                    }

                    continue;
                }

                // pop
                if (stacks[t].Any()) {
                    stacks[t].Pop();
                }
            }

            Console.Out.Flush();
        }
    }
}
