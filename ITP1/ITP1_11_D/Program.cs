using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP1_11_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(System.Console.ReadLine());

            var dices = new Dice[n];
            for (int i = 0; i < n; i++)
            {
                var line = System.Console.ReadLine().Split(' ');

                var diceNumbers = new int[6];
                for (int j = 0; j < line.Length; j++)
                {
                    diceNumbers[j] = int.Parse(line[j]);
                }

                dices[i] = new Dice(diceNumbers);
            }

            var same = false;
            for (int i = 0; i < (n-1); i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    RotateENForSameCheck(dices[i], dices[j]);
                    same = CheckSameAllDiceSurface(dices[i], dices[j]);
                    if (same) {
                        break;
                    }
                }

                if (same) {
                    break;
                }
            }

            if (same) {
                // Not All different
                Console.WriteLine("No");
            } else {
                Console.WriteLine("Yes");
            }
        }

        // 同じになるまで回転
        static void RotateENForSameCheck(Dice diceX, Dice diceY) {
            if (diceX.GetTop() == diceY.GetTop()) {
                if (RotateZForSameCheck(diceX, diceY)) {
                    return;
                }
            }

            // Eへ1回転してみる
            diceY.ToE();
            if (diceX.GetTop() == diceY.GetTop()) {
                if (RotateZForSameCheck(diceX, diceY)) {
                    return;
                }
            }
            diceY.ToE();
            if (diceX.GetTop() == diceY.GetTop()) {
                if (RotateZForSameCheck(diceX, diceY)) {
                    return;
                }
            }
            diceY.ToE();
            if (diceX.GetTop() == diceY.GetTop()) {
                if (RotateZForSameCheck(diceX, diceY)) {
                    return;
                }
            }
            // ダメだったら戻す
            diceY.ToE();

            // Nへ1回転してみる
            diceY.ToN();
            if (diceX.GetTop() == diceY.GetTop()) {
                if (RotateZForSameCheck(diceX, diceY)) {
                    return;
                }
            }
            diceY.ToN();
            if (diceX.GetTop() == diceY.GetTop()) {
                if (RotateZForSameCheck(diceX, diceY)) {
                    return;
                }
            }
            diceY.ToN();
            if (diceX.GetTop() == diceY.GetTop()) {
                if (RotateZForSameCheck(diceX, diceY)) {
                    return;
                }
            }

            // ダメだったら戻す
            diceY.ToN();

            return;
        }

        static bool RotateZForSameCheck(Dice diceX, Dice diceY) {
            if (CheckSameAllDiceSurface(diceX, diceY)) {
                return true;
            }

            diceY.ToZ();
            if (CheckSameAllDiceSurface(diceX, diceY)) {
                return true;
            }

            diceY.ToZ();
            if (CheckSameAllDiceSurface(diceX, diceY)) {
                return true;
            }

            diceY.ToZ();
            if (CheckSameAllDiceSurface(diceX, diceY)) {
                return true;
            }

            // ダメだったら戻す
            diceY.ToZ();

            return false;
        }

        static bool CheckSameAllDiceSurface(Dice diceX, Dice diceY) {
            var result = true;
            // 6面チェック
            for (int i = 0; i < 6; i++)
            {
                if (diceX.GetSurface(i) != diceY.GetSurface(i)) {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }

    public class Dice {

        private int[] numbers;

        public Dice(int[] numbers) {
            this.numbers = numbers;
        }

        public int GetSurface(int surface) {
            return numbers[surface];
        }

        public int GetTop() {
            return numbers[0];
        }

        public int GetFront() {
            return numbers[1];
        }

        public int GetSideE() {
            return numbers[2];
        }

        public void ToN() {
            var o = numbers[0];
            numbers[0] = numbers[1];
            numbers[1] = numbers[5];
            numbers[5] = numbers[4];
            numbers[4] = o;
        }

        public void ToS() {
            for (int i = 0; i < 3; i++)
            {
                ToN();
            }
        }

        public void ToE() {
            var o = numbers[0];
            numbers[0] = numbers[3];
            numbers[3] = numbers[5];
            numbers[5] = numbers[2];
            numbers[2] = o;

        }

        public void ToW() {
            for (int i = 0; i < 3; i++)
            {
                ToE();
            }
        }

        public void ToZ() {
            var o = numbers[1];
            numbers[1] = numbers[3];
            numbers[3] = numbers[4];
            numbers[4] = numbers[2];
            numbers[2] = o;
        }
    }
}
