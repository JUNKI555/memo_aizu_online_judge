using System;
using System.Collections.Generic;

namespace ITP1_6_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var sCardList = new List<int>();    // スペード
            var hCardList = new List<int>();    // ハート
            var cCardList = new List<int>();    // クラブ
            var dCardList = new List<int>();    // ダイヤ
            var cardCount = int.Parse(System.Console.ReadLine());

            for (var i = 0; i < cardCount; i++) {
                var line = System.Console.ReadLine().Split(' ');
                var suit = line[0];
                var number = int.Parse(line[1]);

                switch (suit) {
                    case "S":
                        sCardList.Add(number);
                        break;
                    case "H":
                        hCardList.Add(number);
                        break;
                    case "C":
                        cCardList.Add(number);
                        break;
                    case "D":
                        dCardList.Add(number);
                        break;
                }
            }

            CheckAndOutputNotExistCard("S", sCardList);
            CheckAndOutputNotExistCard("H", hCardList);
            CheckAndOutputNotExistCard("C", cCardList);
            CheckAndOutputNotExistCard("D", dCardList);

            Console.Out.Flush();
        }

        static void CheckAndOutputNotExistCard(string suit, List<int> cardList) {
            for (var i = 1; i <= 13; i++) {
                if (!cardList.Contains(i)) {
                    Console.WriteLine($"{suit} {i}");
                }
            }
        }
    }
}
