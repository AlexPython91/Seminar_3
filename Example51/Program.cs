using System;

// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] FillMatrix(int[,] matrix, int row, int col)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = new Random().Next(row, col);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            System.Console.Write(matrix[m, n] + " ");
        }
        Console.WriteLine();
    }
}


void AdditionOfElements(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = matrix[m, n] + matrix[m, n];
        }
    }
}


int row = 1;
int col = 10;

int[,] twoDimensionalArray = new int[4, 4];

twoDimensionalArray = FillMatrix(twoDimensionalArray, row, col);
PrintMatrix(twoDimensionalArray);
AdditionOfElements(twoDimensionalArray);
System.Console.WriteLine("---------");
PrintMatrix(twoDimensionalArray);



