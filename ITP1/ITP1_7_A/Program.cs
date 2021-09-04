using System;

namespace ITP1_7_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            const int blankScore = -1;
            var continueFlag = true;
            while (continueFlag) {
                var line = System.Console.ReadLine().Split(' ');
                var m = int.Parse(line[0]);
                var f = int.Parse(line[1]);
                var r = int.Parse(line[2]);

                if ((m == blankScore)&&(f == blankScore)&&(r == blankScore)) {
                    continueFlag = false;
                    continue;
                }

                if ((m == blankScore)||(f == blankScore)) {
                    Console.WriteLine("F");
                    continue;
                }

                var sumScore = m + f;

                if (80 <= sumScore) {
                    Console.WriteLine("A");
                    continue;
                }

                if ((65 <= sumScore)&&(sumScore < 80)) {
                    Console.WriteLine("B");
                    continue;
                }

                if ((50 <= sumScore)&&(sumScore < 65)) {
                    Console.WriteLine("C");
                    continue;
                }

                if ((30 <= sumScore)&&(sumScore < 50)) {
                    if (50 <= r) {
                        Console.WriteLine("C");
                        continue;
                    }

                    Console.WriteLine("D");
                    continue;
                }

                if (sumScore < 30) {
                    Console.WriteLine("F");
                }
            }

            Console.Out.Flush();
        }
    }
}
