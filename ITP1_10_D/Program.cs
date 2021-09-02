using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP1_10_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var n = int.Parse(System.Console.ReadLine());

            var vectorX = new List<int>();
            var vectorY = new List<int>();

            string[] line;
            line = System.Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vectorX.Add(int.Parse(line[i]));
            }

            line = System.Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vectorY.Add(int.Parse(line[i]));
            }

            Console.WriteLine(CalcManhattanDistance(vectorX, vectorY).ToString("F6"));
            Console.WriteLine(CalcEuclideanDistance(2, vectorX, vectorY).ToString("F6"));
            Console.WriteLine(CalcEuclideanDistance(3, vectorX, vectorY).ToString("F6"));
            Console.WriteLine(CalcChebyshevDistance(vectorX, vectorY).ToString("F6"));

            Console.Out.Flush();
        }

        // マンハッタン距離
        static double CalcManhattanDistance(List<int> listX, List<int> listY) {
            var result = 0.0d;
            for (int i = 0; i < listX.Count; i++)
            {
                result += Math.Abs(listX[i]-listY[i]);
            }

            return (double)result;
        }

        // ユークリッド距離
        static double CalcEuclideanDistance(int p, List<int> listX, List<int> listY) {
            var result = 0.0d;

            for (int i = 0; i < listX.Count; i++)
            {
                result += Math.Pow(Math.Abs(listX[i]-listY[i]), p);
            }

            return Math.Pow(result, 1.0 / (double)p);
        }

        // チェビシェフ距離
        static double CalcChebyshevDistance(List<int> listX, List<int> listY) {
            var resultList = new List<int>();

            for (int i = 0; i < listX.Count; i++)
            {
                resultList.Add(Math.Abs(listX[i]-listY[i]));
            }

            return (double)resultList.Max();
        }
    }
}
