using System;

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
for (int i = 0; i < 122; i++)
{
    array[i] = new Random().Next(0, 20);
    Console.Write(array[i] + " ");       
}
int count = 0;
for (int i = 0; i < 122; i++)
    if (array[i] >= 9 & array[i] < 100)
    {
        count++;
    }
Console.WriteLine();
Console.WriteLine("++++++++++++++");
Console.WriteLine(count);



