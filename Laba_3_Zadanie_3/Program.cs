using System;

namespace Laba_3_Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ни капли не скопировано с 1 задания
            int i = 0;
            Random rand = new Random();
            Console.WriteLine("Привет, насколько большим у нас будет массив? Введи, пожалуйста, число:");
            int N = int.Parse(Console.ReadLine());
            while (N <= 0)
            {
                Console.WriteLine("Друг, давай у нас массив будет иметь хотя бы 1 элемент \nВведи другое число:");
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вот наш красивый массив случайных чисел от -30 до 45:");
            int[] KrutoiMassiv = new int[N+1];
            for (i = 0; i < N; i++)
            {
                KrutoiMassiv[i] = rand.Next(-30, 45);
                Console.Write("{0} ", KrutoiMassiv[i]);
            }
            i = 0;
            Console.WriteLine("\nВведите число k, на которое сдивентся массив влево:");
            int k = int.Parse(Console.ReadLine());
            while (k > N)
            {
                k -= N;
            }
            int temp = KrutoiMassiv[0];
            for (i = 0; i < k; i++)
            {
                temp = KrutoiMassiv[0];
                for (int j = 0; j < N; j++)
                {
                    KrutoiMassiv[j] = KrutoiMassiv[j + 1];
                }
                KrutoiMassiv[N - 1] = temp;
            }
            Console.WriteLine("Дело сделано:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", KrutoiMassiv[i]);
            }
        }
    }
}
