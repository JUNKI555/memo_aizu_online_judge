using System;

namespace ITP1_6_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var aBuilding = new int[][] {
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            };
            var bBuilding = new int[][] {
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            };
            var cBuilding = new int[][] {
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            };
            var dBuilding = new int[][] {
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            };
            var infoCount = int.Parse(System.Console.ReadLine());

            for (var i = 0; i < infoCount; i++) {
                var line = System.Console.ReadLine().Split(' ');
                var b = int.Parse(line[0]);
                var f = int.Parse(line[1]);
                var r = int.Parse(line[2]);
                var v = int.Parse(line[3]);

                switch (b) {
                    case 1:
                        aBuilding[f-1][r-1] += v;
                        break;
                    case 2:
                        bBuilding[f-1][r-1] += v;
                        break;
                    case 3:
                        cBuilding[f-1][r-1] += v;
                        break;
                    case 4:
                        dBuilding[f-1][r-1] += v;
                        break;
                }
            }

            OutputRooms(aBuilding);
            Console.WriteLine("####################");
            OutputRooms(bBuilding);
            Console.WriteLine("####################");
            OutputRooms(cBuilding);
            Console.WriteLine("####################");
            OutputRooms(dBuilding);

            Console.Out.Flush();
        }

        static void OutputRooms(int[][] building) {
            for (var i = 0; i < building.Length; i++) {
                var result = "";
                for (var j = 0; j < building[i].Length; j++) {
                    if (building[i][j] < 0) {
                        building[i][j] = 0;
                    }
                    if (building[i][j] > 9) {
                        building[i][j] = 9;
                    }
                    result += (" " + building[i][j].ToString());
                }
                Console.WriteLine($"{result}");
            }
        }
    }
}
