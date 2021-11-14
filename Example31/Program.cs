using System;

// 31. Задать массив из 8 элементов и вывести их на экран 

int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 30);
    Console.Write(array[i] + " ");
}