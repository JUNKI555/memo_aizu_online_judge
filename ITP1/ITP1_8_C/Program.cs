using System;

namespace ITP1_8_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var alphabetCounts = new int[alphabet.Length];
            var line = "";
            while ((line = System.Console.ReadLine()) != null) {
                line = line.ToLower();

                var i = 0;
                foreach (var c in alphabet)
                {
                    alphabetCounts[i] += CountChar(line, c);
                    i++;
                }
            }

            var j = 0;
            foreach (var c in alphabet)
            {
                Console.WriteLine($"{c.ToString()} : {alphabetCounts[j]}");
                j++;
            }

            Console.Out.Flush();
        }

        static int CountChar(string s, char c) {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }
    }
}
