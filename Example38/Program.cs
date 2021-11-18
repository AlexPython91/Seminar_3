using System;

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();
int[] array = new int[10];
int sum = 0;
Console.WriteLine("Массив из 10 чисел: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Сумма чисел стоящих на нечетной позиции: ");
for (int i = 0; i < array.Length; i = i + 2)
{
    sum += array[i];
}
Console.WriteLine(sum);
