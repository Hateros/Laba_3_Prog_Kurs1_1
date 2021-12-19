using System;

namespace Laba_3_Individ_Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("\nВот наш красивый массив случайных чисел от -30 до 45:");
            int[,] KrutoiMassiv = new int[10, 10];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    KrutoiMassiv[i, j] = rand.Next(-30, 45);
                    Console.Write("{0}\t ", KrutoiMassiv[i, j]);
                }
                Console.WriteLine();
            }
            int Tempi1, Tempj1, Tempi2, Tempj2, TempForj2, TempFori1;
            Tempi1 = 0;
            Tempi2 = 0;
            Tempj1 = 0;
            Tempj2 = 0;
            TempForj2 = 1;
            TempFori1 = 1;
            while (Tempj1 < 9)
            {
                while (Tempi1 < 9)
                {
                    KrutoiMassiv[Tempi1, Tempj1] = KrutoiMassiv[Tempi2, Tempj2];
                    Tempj2++;
                    Tempi1++;
                }
                Tempi1 = TempFori1;
                TempFori1++;
                Tempj2 = TempForj2;
                TempForj2++;
                Tempj1++;
                Tempi2++;
            }
            
            Console.WriteLine("\nВот наш новый красивый отраженный массив:");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("{0}\t ", KrutoiMassiv[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
