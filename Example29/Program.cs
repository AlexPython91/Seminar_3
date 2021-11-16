using System;

// 29. Написать программу вычисления произведения чисел от 1 до N


int[] array = new int[5];              // Задаем новый массив из 5 элементов
Console.Clear();
Console.WriteLine("Числа от 1 до N: ");
for (int i = 0; i < array.Length; i++)   //Создаем цикл наполнения массива
{
    array[i] = new Random().Next(1, 16);   // Заполнение
    Console.Write(array[i] + " ");       // Вывод в консоль
}
Console.WriteLine();

int result = 1;                          // Задаем начальное значение      
for (int i = 0; i < array.Length; i++)   // Цикл прохода по всем элементам массива
{
    result *= array[i];               // Умножаем каждый элемент с каждым последующим
}
Console.WriteLine("Результат произведения чисел = " + result);    // Вывод в консоль


