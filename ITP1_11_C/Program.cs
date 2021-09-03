using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP1_11_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line;
            line = System.Console.ReadLine().Split(' ');
            var diceXNumbers = new int[6];
            for (int i = 0; i < line.Length; i++)
            {
                diceXNumbers[i] = int.Parse(line[i]);
            }

            line = System.Console.ReadLine().Split(' ');
            var diceYNumbers = new int[6];
            for (int i = 0; i < line.Length; i++)
            {
                diceYNumbers[i] = int.Parse(line[i]);
            }

            // check same array
            var checkX = (int[])diceXNumbers.Clone();
            var checkY = (int[])diceYNumbers.Clone();
            Array.Sort(checkX);
            Array.Sort(checkY);
            if (!checkX.SequenceEqual(checkY)) {
                Console.WriteLine("No");
                return;
            }

            // check same dice
            var diceX = new Dice(diceXNumbers);
            var diceY = new Dice(diceYNumbers);

            RotateENForSameCheck(diceX, diceY);
            var same = CheckSameAllDiceSurface(diceX, diceY);
            if (same) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
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
            // 5面チェックすれば同一判定可
            for (int i = 0; i < 5; i++)
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
