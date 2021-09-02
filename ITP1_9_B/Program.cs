using System;
using System.Collections.Generic;

namespace ITP1_9_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var continueFlag = true;
            while (continueFlag) {
                var text = System.Console.ReadLine();
                if (text == "-") {
                    continueFlag = false;
                    continue;
                }

                var cardQueue = new Queue<string>();
                foreach (var c in text)
                {
                    cardQueue.Enqueue(c.ToString());
                }

                var operationCount = int.Parse(System.Console.ReadLine());
                for (int i = 0; i < operationCount; i++)
                {
                    var h = int.Parse(System.Console.ReadLine());
                    for (int j = 0; j < h; j++)
                    {
                        var dequeueChar = cardQueue.Dequeue();
                        cardQueue.Enqueue(dequeueChar);
                    }
                }

                Console.WriteLine(String.Join("", cardQueue));
            }

            Console.Out.Flush();
        }
    }
}
