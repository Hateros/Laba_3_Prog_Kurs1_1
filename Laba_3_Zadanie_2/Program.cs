using System;

namespace Laba_3_Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] KrutoiMassiv = new int[7, 7];
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    KrutoiMassiv[i, j] = rand.Next(1, 9);
                    Console.Write("{0} ", KrutoiMassiv[i, j]);
                    if (i == 6)
                    {
                        Console.WriteLine();
                    }
                }
            }
            int temporaryForArrayTurn;
            Console.WriteLine("\nСколько раз Вы желаете повернуть? 1, 1 или 1?");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (N == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 6 - 2 * i; j++)
                    {
                        temporaryForArrayTurn = KrutoiMassiv[j + i, i];
                        KrutoiMassiv[j + i, i] = KrutoiMassiv[i, 6 - j - i];
                        KrutoiMassiv[6 - j - i, 6 - i] = KrutoiMassiv[6 - i, j + i];
                        KrutoiMassiv[i, 6 - j - i] = KrutoiMassiv[6 - j - i, 6 - i];
                        KrutoiMassiv[6 - i, j + i] = temporaryForArrayTurn;
                    }
                }
                for (int j = 0; j < 7; j++)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write("{0} ", KrutoiMassiv[i, j]);
                        if (i == 6)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Данная функция заблокирована в бесплатной версии \nДля разблокировки Премиум версии внесите 50 рублей в дисковод!");
            }
            

        }

    }
}
