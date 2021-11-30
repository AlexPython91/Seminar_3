using System;

// 50. В двумерном массиве n×k заменить четные элементы на противоположные

// Метод заполнения массива

int[,] FillArray(int[,] array, int leftBound, int rightBound)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(leftBound, rightBound);
        }
    }
    return array;
}

// Метод печати массива

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Метод замены элементов массива

int[,] ReplaceElementArray(int[,] array)
{
    //int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) array[i, j] = -array[i, j];
        }
    }
    return array;
}

int n = 5;
int k = 5;

int[,] replaceEven = new int[n, k];

replaceEven = FillArray(replaceEven, 1, 10);
Console.WriteLine("Дан двумерный массив: ");
PrintArray(replaceEven);

Console.WriteLine("Массив заменненых четных элементов на противоположные: ");
int[,] replaseArray = ReplaceElementArray(replaceEven);
PrintArray(replaseArray);
//Console.WriteLine(result);

