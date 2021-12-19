using System;

namespace Laba_3_Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n:");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Ну введите число больше 0:");
                n = int.Parse(Console.ReadLine());
            }
            int f = 0;
            int f0, f1, i;
            f0 = 0;
            i = 0;
            f1 = 1;

            static int Fibogachi(int n, int f, int f0, int f1, int i)
            {
                if (i == n)
                {
                    return f;
                }
                else
                {
                    f = f0 + f1;
                    f0 = f1;
                    f1 = f;
                    i++;
                    return Fibogachi(n, f, f0, f1, i);
                }
            }
            int Result = Fibogachi(n, f, f0, f1, i);
            Console.WriteLine("Нужное нам число: {0}", Result);

        }
    }
}
