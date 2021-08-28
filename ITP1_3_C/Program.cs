using System;

namespace ITP1_3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var endFlag = true;
            while (endFlag) {
                var line = System.Console.ReadLine().Split(' ');
                var a = int.Parse(line[0]);
                var b = int.Parse(line[1]);

                if ((a == 0)&&(b == 0)) {
                    endFlag = false;
                } else {
                    if (a > b) {
                        Console.WriteLine($"{b} {a}");
                    } else {
                        Console.WriteLine($"{a} {b}");
                    }
                }
            }

            Console.Out.Flush();
        }
    }
}
