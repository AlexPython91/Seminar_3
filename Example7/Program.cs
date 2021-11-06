using System;

// Показать числа от -N до N

int[] array = new int[10];   // создаем массив из 10 значений

void createArray(int[] array)    // заполняем массив случ. числами в диапазоне с пом. метода
{
    for(int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
}

void showArray(int[] array)     // создаем метод вывода массива в консоль
{
    for(int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
}

createArray(array); 
Console.WriteLine("Показ всех чисел массива от -N до N: ");  // вызываем оба метода
showArray(array);
Console.WriteLine();