using System;
using System.Collections.Generic;

namespace ITP2_1_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var q = int.Parse(Console.ReadLine());

            var stack = new List<int>();
            for (int i = 0; i < q; i++)
            {
                var line = System.Console.ReadLine();

                // popBack
                if (line.StartsWith("2")) {
                    stack.RemoveAt(stack.Count-1);
                    continue;
                }

                var splitLine = line.Split(' ');
                var command = splitLine[0];
                var x = int.Parse(splitLine[1]);

                // pushBack
                if (command == "0") {
                    stack.Add(x);
                    continue;
                }

                // randomAccess
                Console.WriteLine(stack[x].ToString());
            }

            Console.Out.Flush();
        }
    }
}
