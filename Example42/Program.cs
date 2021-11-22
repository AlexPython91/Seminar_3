using System;

// 42. Определить сколько чисел больше 0 введено с клавиатуры

int[] array = new int[10];             // Определяем массив
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите {0}-е число: ", i + 1);   // Выводим в консоль поочередно 10 значений    
    array[i] = int.Parse(Console.ReadLine());       // Переводим из строкового значение в числовое
}

int MoreZeroNumber(int[] array)             // Создаем метод подсчета введенных чисел больше 0
{
    int count = 0;                              // Задаем счетчик
    for (int i = 0; i < array.Length; i++)       // Цикл прохода по массиву
    {
        if (array[i] > 0) count++;            // Условие (если находим число > 0, то добавляем в счетчик)
    }
    return count;                             // Возврат заполненного счетчика
}
int res = MoreZeroNumber(array);              // Вызываем метод с результатом
Console.Write("Введено чисел > 0: " + res);      // Выводим в консоль результат
Console.WriteLine();