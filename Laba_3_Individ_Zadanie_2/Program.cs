using System;

namespace Laba_3_Individ_Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumOfLeft = 0;
            int SumOfRight = 0;
            Console.WriteLine("Привет, насколько большим у нас будет массив? Введи, пожалуйста, число:");
            int N = int.Parse(Console.ReadLine());
            while (N <= 0 || N % 2 == 1)
            {
                Console.WriteLine("Друг, давай у нас массив будет иметь чётное кол-во элементов и иметь хотя бы 1 элемент \nВведи другое число:");
                N = int.Parse(Console.ReadLine());
            }
            int[] KrutoiMassiv = new int [N];
            Console.WriteLine("А теперья заставлю тебя ввести элементы массива:");
            for (int i = 0; i < N; i++)
            {
                KrutoiMassiv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вот твой красивый массив:");
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0} \t", KrutoiMassiv[i]);
            }

            int MiddleOfKrutoiMassiv = N / 2;
            for (int i = 0; i < MiddleOfKrutoiMassiv; i++)
            {
                SumOfLeft += KrutoiMassiv[i];
            }
            for (int i = MiddleOfKrutoiMassiv; i < N; i++)
            {
                SumOfRight += KrutoiMassiv[i];
            }
            int ResultEtihDeistviy = SumOfLeft - SumOfRight;
            Console.WriteLine("\nВот что получается у нас:\n {0}", ResultEtihDeistviy);
        }
    }
}
