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
            Console.WriteLine("\nСколько раз Вы желаете повернуть? 1, 2 или 3?");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (N == 1)
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 6; j >= 0; j--)
                    {
                        Console.Write("{0} ", KrutoiMassiv[i, j]);
                        if (j == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            else if (N == 2)
            {
                for (int j = 6; j >= 0; j--)
                {
                    for (int i = 6; i >= 0; i--)
                    {
                        Console.Write("{0} ", KrutoiMassiv[i, j]);
                        if (i == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            else if (N == 3)
            {
                for (int i = 6; i >= 0; i--)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write("{0} ", KrutoiMassiv[i, j]);
                        if (j == 6)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            else if (N == 4)
            {
                Console.WriteLine("Ну и зачем ты ввёл 4? Уже перевернули массив, посмотри выше!");
            }
            else
            {
                Console.WriteLine("Данная функция заблокирована в бесплатной версии \nДля разблокировки Премиум версии внесите 50 рублей в дисковод!");
            }
        }

    }
}
