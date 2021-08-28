using System;

namespace ITP1_5_B
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
                        if ((i == 0)||(i == (H - 1))) {
                            for (var j = 0; j < W; j++) {
                                horizontal += "#";
                            }
                        } else {
                            horizontal += "#";
                            for (var j = 1; j < (W - 1); j++) {
                                horizontal += ".";
                            }
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
