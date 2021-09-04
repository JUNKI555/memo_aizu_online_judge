using System;

namespace ITP1_3_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            for(var i = 0; i < 1000; i++) {
                Console.WriteLine("Hello World");
            }

            Console.Out.Flush();
        }
    }
}
