using System;

namespace Laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Привет, насколько большим у нас будет массив? Введи, пожалуйста, число:");
            int N = int.Parse(Console.ReadLine());
            while (N <= 0)
            {
                Console.WriteLine("Друг, давай у нас массив будет иметь хотя бы 1 элемент \nВведи другое число:");
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вот наш красивый массив случайных чисел от -30 до 45:");
            int[] KrutoiMassiv = new int[N];
            for (int i = 0; i < N; i++)
            {
                KrutoiMassiv[i] = rand.Next(-30, 45);
                Console.Write("{0} ", KrutoiMassiv[i]);
                if (i % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
            int sch = 0;
            Console.WriteLine("\n А вот тот же массив, но в обратном порядке и без отрицательных чисел:");
            for (int i = N - 1; i > 0; i--)
            {
                if (KrutoiMassiv[i] > 0)
                {
                    Console.Write("{0} ", KrutoiMassiv[i]);
                    sch++;
                    if (sch % 10 == 0)
                    {
                        Console.Write("\n");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
