using System;

namespace ITP1_8_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var continueFlag = true;
            while (continueFlag) {
                var line = System.Console.ReadLine();
                if (string.IsNullOrEmpty(line)) {
                    continueFlag = false;
                    continue;
                }

                if (line == "0") {
                    continueFlag = false;
                    continue;
                }

                var sum = 0;
                foreach (var c in line)
                {
                    var number = int.Parse(c.ToString());
                    sum += number;
                }
                Console.WriteLine(sum.ToString());
            }

            Console.Out.Flush();
        }
    }
}
