using System;

// 30. Показать кубы чисел, заканчивающихся на четную цифру 

int number = 1;
int count = 10;

for(number = 1; number <= count; number++)     // Задаем цикл по вход. данным
{   
    int sqr = number*number*number;            // Находим куб каждого числа
    if(sqr % 2 == 0)                           // Производим расчет остатка от деления (четные)
    {
        Console.WriteLine($"Ends in even: {sqr} ", "");
    }
}