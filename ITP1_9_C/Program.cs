using System;

namespace ITP1_9_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(System.Console.ReadLine());

            const int winScore = 3;
            const int drawScore = 1;
            var scoreTaro = 0;
            var scoreHanako = 0;
            for (int i = 0; i < n; i++)
            {
                var line = System.Console.ReadLine().Split(' ');
                var taro = line[0];
                var hanako = line[1];

                var judge = taro.CompareTo(hanako);
                if (judge == 0) {
                    scoreTaro += drawScore;
                    scoreHanako += drawScore;
                } else if (judge < 0) {
                    scoreHanako += winScore;
                } else {
                    scoreTaro += winScore;
                }
            }

            Console.WriteLine($"{scoreTaro} {scoreHanako}");
        }
    }
}
