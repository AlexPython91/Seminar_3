using System;

/* 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
Показать количество нечетных\четных чисел*/

//Вариант №2 (рабочий но нужно редактировать)

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

Console.WriteLine("Колличество четных чисел: ");
for (int i = 0; i < array.Length; i++)             // Находим четные числа в массиве
{
    if ((array[i] % 2) == 0)                
    {
        evenNumbers++;
        Console.Write(evenNumbers + " ");
    }
}
Console.WriteLine();
Console.WriteLine("Колличество нечетных чисел: ");

for (int i = 0; i < array.Length; i++)          // Находим нечетные ччисла
{
    if ((array[i] % 2) != 0)
    {
        oddNumbers++;
        Console.Write(oddNumbers + " ");
    }
}
Console.WriteLine();


// Вариант №1

// int[] array = new int[50];
// Console.WriteLine("Массив из положительных трехзначных чисел: ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 200);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// int firstCounter = 0;
// int secondCounter = 0;
// int evenNumbers = 0;
// int oddNumbers = 0;
// Console.WriteLine("Колличество четных чисел: ");
// // Console.WriteLine("Четные числа массива: ");
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         firstCounter++;
//         evenNumbers = array[i];
//         Console.Write(firstCounter + " ");
//         // Console.Write(evenNumbers + " ");
//     }
//     Console.Write(evenNumbers + " ");
//     //int secondCounter = 0;
//     for (int j = 0; j < array.Length; j++)
//     {
//         if (array[j] % 1 == 1)
//         {
//             secondCounter++;
//             Console.Write(secondCounter + " ");
//         }
//     }
// }
// Console.WriteLine();
