using System;

// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] +  " ");
        }
        Console.WriteLine();
    }
}

System.Console.WriteLine("Two-dimensional array: ");

// Метод замены индексов

void ReplaceEvenIndicesAnArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        }
    }
}


int leftBound = 1;
int rightBound = 10;

int[,] ReplaceEvenIndices = new int[4, 4];

ReplaceEvenIndices = FillArray(ReplaceEvenIndices, leftBound, rightBound);
PrintArray(ReplaceEvenIndices);
System.Console.WriteLine();
Console.WriteLine("Replacing even elements with their squares: ");
ReplaceEvenIndicesAnArray(ReplaceEvenIndices);
PrintArray(ReplaceEvenIndices);


// int[,] replaseElements = ReplaceEvenIndicesAnArray(ReplaceEvenIndices);
// Console.Write(replaseElements);