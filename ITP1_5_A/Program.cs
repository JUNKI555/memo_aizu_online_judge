using System;

namespace ITP1_5_A
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
                var H = int.Parse(line[0]);
                var W = int.Parse(line[1]);

                if ((H == 0)&&(W == 0)) {
                    endFlag = false;
                } else {
                    for (var i = 0; i < H; i++) {
                        var horizontal = "";
                        for (var j = 0; j < W; j++) {
                            horizontal += "#";
                        }
                        Console.WriteLine(horizontal);
                    }
                    Console.WriteLine(String.Empty);
                }
            }

            Console.Out.Flush();
        }
    }
}
