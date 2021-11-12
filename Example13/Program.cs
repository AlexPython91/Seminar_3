using System;

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.


int number = 80;                          // Задаем число
Console.WriteLine("Number = " + number);  // Выводим в консоль

int givenNumber = 13;                               // Задаем число
Console.WriteLine("GivenNumber = " + givenNumber); // Выводим в консоль

if (number % givenNumber == 0)         // Вычисляем остаток от деления чисел
{
    Console.WriteLine("Кратное!");
}
else
{
    Console.WriteLine("Остаток от числа = " + number % givenNumber);
}

int Show(int a, int b)
{
    return (a % b);
}
int res = Show(80, 20);
Console.WriteLine(res);