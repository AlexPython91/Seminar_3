using System;

// 34. Написать программу замену элементов массива на противоположные

int[] array = new int[5];
Console.Clear();
Console.WriteLine("Программа замены элементов массива на противоположные");
Console.WriteLine("Список элементов: ");
for (int i = 0; i < array.Length; i++)        // Цикл заполнения массива
{
    array[i] = new Random().Next(-20, 20);
    Console.Write(array[i] + " ");        // Вывод массива
}
Console.WriteLine();

Console.WriteLine("Список противоположных элементов: ");
int result = 0;                            // Задаем начальное значение
for (int i = 0; i < array.Length; i++)     // Цикл прохождения по массиву
{
    if (array[i] > 0 || array[i] < 0)            // Если элемент массива больше 0 или меньше 0
    {
        result = array[i] = -array[i];    // Присваиваем ему противоположное значение
        Console.Write(result + " ");
    }
}
Console.WriteLine();


