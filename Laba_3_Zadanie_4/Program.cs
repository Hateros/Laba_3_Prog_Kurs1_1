using System;

namespace Laba_3_Zadanie_4
{
    class Program
    {
        // Сумма
        static int[,] Sum(int[,] Array1, int[,] Array2, out double Average)
        {
            Average = 0;
            int[,] Sum = new int [3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Sum[i, j] = Array1[i, j] + Array2[i, j];
                    Average += Array1[i, j] + Array2[i, j];
                }
            }
            if (Average == 0)
            {
                Console.WriteLine("Среднее значение всех элементов входных массивов = 0");
            }
            else
            {
                Average = Average / 18;
            }
            return Sum;
        }

        // Вычитание
        static int[,] Difference(int[,] Array1, int[,] Array2, out double Average)
        {
            Average = 0;
            int[,] Difference = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Difference[i, j] = Array1[i, j] - Array2[i, j];
                    Average += Array1[i, j] + Array2[i, j];
                }
            }
            if (Average == 0)
            {
                Console.WriteLine("Среднее значение всех элементов входных массивов = 0");
            }
            else
            {
                Average = Average / 18;
            }
            return Difference;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Вот наш красивый первый массив случайных чисел от -30 до 45:");
            int[,] KrutoiMassiv = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    KrutoiMassiv[i, j] = rand.Next(-30, 45);
                    Console.Write("{0}\t ", KrutoiMassiv[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nВот наш красивый второй массив случайных чисел от -30 до 45:");
            int[,] KrutoiMassiv2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    KrutoiMassiv2[i, j] = rand.Next(-30, 45);
                    Console.Write("{0}\t ", KrutoiMassiv2[i, j]);
                }
                Console.WriteLine();
            }
            double Average = 0;
            int[,] ResultOfSum = Sum(KrutoiMassiv, KrutoiMassiv2, out Average);
            Console.WriteLine("\nПоэлементное сложение массивов:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t ", ResultOfSum[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Среднее значение значение всех элементов массивов: {0}", Average);

            int[,] ResultOfDifference = Sum(KrutoiMassiv, KrutoiMassiv2, out Average);
            Console.WriteLine("\nПоэлементное вычитание массивов:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t ", ResultOfDifference[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Среднее значение значение всех элементов массивов: {0}", Average);
        }
    }
}
