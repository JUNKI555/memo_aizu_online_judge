using System;

namespace ITP1_3_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var i = 0;
            var endFlag = true;
            while (endFlag) {
                i++;
                var x = int.Parse(System.Console.ReadLine());
                if (x == 0) {
                    endFlag = false;
                } else {
                    Console.WriteLine($"Case {i}: {x}");
                }
            }

            Console.Out.Flush();
        }
    }
}
