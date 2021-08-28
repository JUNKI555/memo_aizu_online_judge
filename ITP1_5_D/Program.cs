using System;

namespace ITP1_5_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var n = int.Parse(System.Console.ReadLine());
            var result = "";
            var x = 0;
            for (var i = 1; i <= n; i++) {
                x = i;
                if ((x % 3) == 0) {
                    result += " " + i.ToString();
                    continue;
                }
                
                if ((x % 10) == 3) {
                    result += " " + i.ToString();
                    continue;
                }

                while(x != 0) {
                    x = x / 10;
                    if ((x % 10) == 3) {
                        result += " " + i.ToString();
                        x = 0;
                    }
                }
            }

            Console.WriteLine(result);
            Console.Out.Flush();
        }
    }
}
