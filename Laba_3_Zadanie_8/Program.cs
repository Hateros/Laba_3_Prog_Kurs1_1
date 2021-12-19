using System;

namespace Laba_3_Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            static double[,] getMinor(double[,] matrix, int n)
            {
                double[,] result = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0, column = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == n)
                            continue;
                        result[i - 1, column] = matrix[i, j];
                        column++;
                    }
                }
                return result;
            }

            static double DeterminantMatrix(double[,] matrix)
            {
                if (matrix.Length == 1)
                    return matrix[0, 0];
                if (matrix.Length == 4)
                    return matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
                else
                {
                    double result = 0;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        double[,] Minor = getMinor(matrix, i);
                        result += Math.Pow(-1, i) * matrix[0, i] * DeterminantMatrix(Minor);
                    }
                    return result;
                }
            }



            Console.Write("Введите размер матрицы N*N: ");
            int N = int.Parse(Console.ReadLine());
            double[,] KrutoiMassiv = new double[N, N];
            while (N <= 1)
            {
                Console.WriteLine("N должно быть больше 1!\nВведи другое число N");
                N = int.Parse(Console.ReadLine());
            }
            
                Random random = new Random();
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        KrutoiMassiv[i, j] = random.Next(-30, 45);
                        Console.Write(KrutoiMassiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("Определитель матрицы равен: {0}", DeterminantMatrix(KrutoiMassiv));
        }
    }
}
