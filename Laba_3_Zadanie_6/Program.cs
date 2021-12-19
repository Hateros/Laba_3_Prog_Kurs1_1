using System;

namespace Laba_3_Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            static int sumIterative(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
            static int sumRecursive(int[] array, int i = 0)
            {
                if (i >= array.Length)
                {
                    return 0;
                }
                else
                {
                    return array[i] + sumRecursive(array, i + 1);
                }
            }
            static int minIterative(int[] array)
            {
                int minValue = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < minValue)
                    {
                        minValue = array[i];
                    }
                }
                return minValue;
            }
            static int minRecursive(int[] array, int i = 0)
            {
                if (i + 1 == array.Length)
                {
                    return array[i];
                }
                else
                {
                    return Math.Min(array[i], minRecursive(array, ++i));
                }
            }
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
                Console.Write("{0}\t ", KrutoiMassiv[i]);
                if (i % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine("\n\nСумма (Итерация):{0}", sumIterative(KrutoiMassiv));
            Console.WriteLine("Сумма (Рекурсия):{0}", sumRecursive(KrutoiMassiv));
            Console.WriteLine("Минимальный элемент (Итерация):{0}", minIterative(KrutoiMassiv));
            Console.WriteLine("Минимальный элемень (Рекурсия):{0}", minRecursive(KrutoiMassiv));
        }
    }
}

