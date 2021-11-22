using System;

// 48. Показать двумерный массив размером m×n заполненный целыми числами

int[,] CreateTwoDemensArray = new int[3, 5];

for (int i = 0; i < CreateTwoDemensArray.GetLength(0); i++)
{
    for (int j = 0; j < CreateTwoDemensArray.GetLength(1); j++)
    {
        Console.Write($"{CreateTwoDemensArray[i, j]}" + " ");
    }
    Console.WriteLine();
}




