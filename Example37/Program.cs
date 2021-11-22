using System;

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.WriteLine("Задан одномерный массив из 123 элементов: ");
int[] array = new int[124];
for (int i = 0; i < 122; i++)
{
    array[i] = new Random().Next(1, 123);
    Console.Write(array[i] + " ");       
}
int count = 0;
for (int i = 0; i < 122; i++)
    if (array[i] >= 9 && array[i] <= 99)
    {
        count++;
    }
Console.WriteLine();
Console.WriteLine($"Колличество элементов из отрезка {10} {99} = {count}");