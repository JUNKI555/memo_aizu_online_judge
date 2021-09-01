using System;
using System.Threading.Tasks;

namespace ITP1_7_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var qLine = System.Console.ReadLine().Split(' ');
            var n = int.Parse(qLine[0]);
            var m = int.Parse(qLine[1]);
            var l = int.Parse(qLine[2]);

            var matrixA = CreateMatrix(n, m);
            for(int i = 0; i < n; i++) {
                var line = System.Console.ReadLine().Split(' ');
                for(int j = 0; j < m; j++) {
                    var number = decimal.Parse(line[j]);
                    matrixA[i][j] = number;
                }
            }

            var matrixB = CreateMatrix(m, l);
            for(int i = 0; i < m; i++) {
                var line = System.Console.ReadLine().Split(' ');
                for(int j = 0; j < l; j++) {
                    var number = decimal.Parse(line[j]);
                    matrixB[i][j] = number;
                }
            }

            var matrixC = ProductMatrix(matrixA, matrixB);
            OutputMatrix(matrixC);

            Console.Out.Flush();
        }

        // https://docs.microsoft.com/ja-jp/archive/msdn-magazine/2012/december/csharp-matrix-decomposition
        static decimal[][] CreateMatrix(int rows, int cols) {
            decimal[][] result = new decimal[rows][];
            for(int i = 0; i < rows; i++) {
                result[i] = new decimal[cols];
            }
            return result;
        }

        static decimal[][] ProductMatrix(decimal[][] matrixA, decimal[][] matrixB) {
            int aRows = matrixA.Length;
            int aCols = matrixA[0].Length;
            int bRows = matrixB.Length;
            int bCols = matrixB[0].Length;

            decimal[][] result = CreateMatrix(aRows, bCols);
            if (aCols != bRows) {
                return result;
            }

            Parallel.For(0, aRows, i => {
                for(int j = 0; j < bCols; j++) {
                    for(int k = 0; k < aCols; k++) {
                        result[i][j] += (matrixA[i][k] * matrixB[k][j]);
                    }
                }
            });

            return result;
        }

        static void OutputMatrix(decimal[][] matrix) {
            for(int i = 0; i < matrix.Length; i++) {
                var s = String.Empty;
                for(int j = 0; j < matrix[i].Length; j++) {
                    if (j == 0) {
                        s += matrix[i][j].ToString();
                    } else {
                        s += (" " + matrix[i][j].ToString());
                    }
                }
                Console.WriteLine(s);
            }
        }
    }
}
