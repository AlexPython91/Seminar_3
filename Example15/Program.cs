using System;

// 15. Дано число. Проверить кратно ли оно 7 и 23 (Вариант 1. Цикл if)

int number = 161;     // Задаем число

if (number % 7 == 0 | number % 23 == 0)   // Проверяем кратность 7 (161 / 7) = 23, или кратность 23 (161 / 23) = 7
{
    Console.WriteLine("Yes");        // Вывод ответа
}
else
{
    Console.WriteLine("No");
}

// (Вариант 2. Метод)

bool multiplicity(int num)      // создаем метод (тип, имя, аргумент)
{
    return (num % 7 == 0 | num % 23 == 0);    // возврат по расчету True or Folse
}
bool res = multiplicity(161);      // Вызываем метод, передаем ему число(161)
Console.WriteLine(res);            // Выводим в консоль 