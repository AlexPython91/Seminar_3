using System;

// 49. Показать двумерный массив размером m×n заполненный вещественными числами

double[,] FillArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * 100;
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ------- ");
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 6;

double[,] ArrayOfRealNumbers = FillArray(m, n);
PrintArray(ArrayOfRealNumbers);

