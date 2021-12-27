using System;

namespace Laba_3_Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Вы только посмотрите на эту первую прекрасную матрицу 5х5!\n");
            int[,] KrutoiMassiv1 = new int[5, 5];
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    KrutoiMassiv1[i, j] = rand.Next(1, 9);
                    Console.Write("{0} ", KrutoiMassiv1[i, j]);
                    if (i == 4)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("\nВы только посмотрите на эту вторую прекрасную матрицу 5х5!\n");
            int[,] KrutoiMassiv2 = new int[5, 5];
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    KrutoiMassiv2[i, j] = rand.Next(1, 9);
                    Console.Write("{0} ", KrutoiMassiv2[i, j]);
                    if (i == 4)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("\nВы только посмотрите на эту третью прекрасную матрицу 5х5, полученную в результате произведения первых двух!\n");
            int[,] KrutoiMassiv3 = new int[5, 5];
            int resultOf = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        //KrutoiMassiv3[i, j] = KrutoiMassiv1[i, j] * KrutoiMassiv2[j, i];
                        resultOf += KrutoiMassiv1[k, j] * KrutoiMassiv2[i, k];

                    }
                    KrutoiMassiv3[j, i] = resultOf;
                    resultOf = 0;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0} ", KrutoiMassiv3[i, j]);
                    if (j == 4)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
