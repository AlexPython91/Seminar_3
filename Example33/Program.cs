using System;

/*33. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
Найти сумму положительных/отрицательных элементов массива*/

int[] array = new int[12];     // Задаем массив
for (int i = 0; i < 12; i++)     // Создаем цикл
{
    array[i] = new Random().Next(-9, 9);    // Заполняем массив
    Console.Write(array[i] + " ");           // Выводим массив
}

int positiveElements = 0;                // Положительные элементы ("счетчик")
int negativeElements = 0;                 // Отрицательные элементы ("счетчик")

for(int i = 0; i < 12; i++)                 // Сощдаем цикл расчета элементов
{
    if(array[i] > 0)                        // Если индекс массива больше 0 то вносим в positiveElements
    {
        positiveElements = positiveElements + array[i];
    }
    else                                     // Если индекс массива меньше 0 то вносим в negativeElements
    {
        negativeElements = negativeElements + array[i];  
    }
}
Console.WriteLine();                      // Печатаем
Console.WriteLine(positiveElements);
Console.WriteLine(negativeElements);