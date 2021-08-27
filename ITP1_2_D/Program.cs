using System;

namespace ITP1_2_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split(' ');
            var W = int.Parse(line[0]);
            var H = int.Parse(line[1]);
            var x = int.Parse(line[2]);
            var y = int.Parse(line[3]);
            var r = int.Parse(line[4]);

            bool isInnerA = false, isInnerB = false, isInnerC = false, isInnerD = false;
            // Aizu Online Judge では System.Drawing 名前空間が使用できない
            // var rect = new System.Drawing.Rectangle(0, 0, W, H);
            // if (rect.Contains(x+r, y)) {
            //     isInnerA = true;
            // }
            // if (rect.Contains(x-r, y)) {
            //     isInnerB = true;
            // }
            // if (rect.Contains(x, y+r)) {
            //     isInnerC = true;
            // }
            // if (rect.Contains(x, y-r)) {
            //     isInnerD = true;
            // }
            if ((x+r).Between(0, W)) {
                isInnerA = true;
            }
            if ((x-r).Between(0, W)) {
                isInnerB = true;
            }
            if ((y+r).Between(0, H)) {
                isInnerC = true;
            }
            if ((y-r).Between(0, H)) {
                isInnerD = true;
            }

            if (isInnerA && isInnerB && isInnerC && isInnerD) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }
    }

    static class Extensions {
        public static bool Between(this int num, int lower, int upper) {
            return lower <= num && num <= upper;
        }
    }
}
