using System;

/* 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д.*/

int[] array = new int[8];
Console.WriteLine("Дан массив: ");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 20);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Произведение пар чисел: ");
for(int i = 0; i < array.Length / 2; i++)         // Делим массив до половины
{
    int res = array[i] * array[array.Length - i - 1];   // Умножаем первое и последнее число массива
    Console.Write(res + " ");
}
Console.WriteLine();
