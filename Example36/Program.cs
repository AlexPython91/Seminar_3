using System;

/* 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
Показать количество нечетных\четных чисел*/

//Вариант №1 (рабочий но нужно редактировать)

// int[] array = new int[20];        // Создаем массив из 20 эл-ов
// int evenNumbers = 0;               // Счетчик четных чисел
// int oddNumbers = 0;                // Счетчик нечетных чисел
// Console.WriteLine("Массив из положительных трехзначных чисел: ");
// for (int i = 0; i < array.Length; i++)            // Цикл заполненя массива
// {
//     array[i] = new Random().Next(100, 500);  
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// Console.WriteLine("Колличество четных чисел: ");
// for (int i = 0; i < array.Length; i++)             // Находим четные числа в массиве
// {
//     if ((array[i] % 2) == 0)                
//     {
//         evenNumbers++;
//         Console.Write(evenNumbers + " ");
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Колличество нечетных чисел: ");

// for (int i = 0; i < array.Length; i++)          // Находим нечетные ччисла
// {
//     if ((array[i] % 2) != 0)
//     {
//         oddNumbers++;
//         Console.Write(oddNumbers + " ");
//     }
// }
// Console.WriteLine();


// Вариант №2 (оптимизированное решение для одного прогона цикла)
Console.Clear();
int[] array = new int[20];        // Создаем массив из 20 эл-ов
int evenNumbers = 0;               // Счетчик четных чисел
int oddNumbers = 0;                // Счетчик нечетных чисел
Console.WriteLine("Массив из положительных трехзначных чисел: ");

for (int i = 0; i < array.Length; i++)            // Цикл заполненя массива
{
    array[i] = new Random().Next(100, 500);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)             // Находим четные числа в массиве
{
    if ((array[i] % 2) == 0)
    {
        evenNumbers++;
    }
    if (array[i] % 2 != 0)    // Находим нечетные числа в массиве
    {
        oddNumbers++;
    }
}
Console.WriteLine("Колличество четных чисел: " + evenNumbers);
Console.WriteLine("Колличество нечетных чисел: " + oddNumbers);
