using System;
using System.Collections.Generic;

namespace ITP2_2_B
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

            var queueArray = new Queue<int>[n];
            for (int i = 0; i < n; i++)
            {
                queueArray[i] = new Queue<int>();
            }
            
            for (int i = 0; i < q; i++)
            {
                var line = System.Console.ReadLine().Split(' ');
                var command = line[0];
                var t = int.Parse(line[1]);

                // enqueue
                if (command == "0") {
                    var x = int.Parse(line[2]);
                    queueArray[t].Enqueue(x);
                    continue;
                }

                // front
                if (command == "1") {
                    var peek = 0;
                    if (queueArray[t].TryPeek(out peek)) {
                        Console.WriteLine(peek.ToString());
                    }
                    continue;
                }

                // dequeue
                var dequeue = 0;
                queueArray[t].TryDequeue(out dequeue);
            }

            Console.Out.Flush();
        }
    }
}
