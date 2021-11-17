using System;

// 23. Показать таблицу квадратов чисел от 1 до N

int[] array = new int[2];
//Console.Clear();
Console.WriteLine("Числа от 1 до N: ");

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 15);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int result = 1;
for(int i = 0; i < array.Length; i++)
{
    result = result * array[i];
}
Console.WriteLine("Таблица квадратов: " + result);




// int[] getArraySqr(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = i * i;
//     }
//     return result;
// }
// PrintArray(getArraySqr(8));

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         //array[0] = 1;
//         Console.Write(array[i] + " ");
//     }
// }

