using System;

namespace ITP1_6_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var qLine = System.Console.ReadLine().Split(' ');
            var aQueueRows = int.Parse(qLine[0]);
            var bQueueRows = int.Parse(qLine[1]);

            var aQueue = new int[aQueueRows][];
            for(int i = 0; i < aQueue.Length; i++) {
                aQueue[i] = new int[bQueueRows];
            }

            for (var i = 0; i < aQueueRows; i++) {
                var line = System.Console.ReadLine().Split(' ');
                for (var j = 0; j < bQueueRows; j++) {
                    aQueue[i][j] = int.Parse(line[j]);
                }
            }

            var bQueue = new int[bQueueRows];
            for (var j = 0; j < bQueueRows; j++) {
                bQueue[j] = int.Parse(System.Console.ReadLine());
            }

            for (var i = 0; i < aQueueRows; i++) {
                var c = 0;
                for (var j = 0; j < bQueueRows; j++) {
                    c += (aQueue[i][j] * bQueue[j]);
                }
                Console.WriteLine($"{c}");
            }

            Console.Out.Flush();
        }
    }
}
