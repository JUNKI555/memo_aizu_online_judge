using System;

namespace ITP1_10_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var line = System.Console.ReadLine().Split(' ');
            var a = int.Parse(line[0]);
            var b = int.Parse(line[1]);
            var c = int.Parse(line[2]);

            double radian = Math.PI * c / 180.0;
            var sinC = Math.Sin(radian);

            var h = b * sinC;
            var s = (a * b / 2) * sinC;

            var l = a + b + Math.Sqrt((a * a) + (b * b) - (2 * a * b * Math.Cos(radian)));

            Console.WriteLine(s.ToString("F13"));
            Console.WriteLine(l.ToString("F13"));
            Console.WriteLine(h.ToString("F13"));
            Console.Out.Flush();
        }
    }
}
