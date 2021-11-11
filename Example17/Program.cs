using System;

// 17. По двум введённым числам проверять является ли одно квадратом другого. Вариант 1. Цикл

int firstNumber = 2;
int secondNuber = 4;

if (secondNuber == firstNumber * firstNumber)
{
    Console.WriteLine("Number " + firstNumber + " is the square of number  " + secondNuber);
}
else
{
    Console.WriteLine("Number " + firstNumber + " is not the square of number " + secondNuber);
}

// Вариант 2. Метод.

bool findSquare(int a, int b)   // Объявляем метод (тип, имя, аргументы - 2 числа)
{
    return (b == a * a);         // True если есть квадрат и Folse если не квадрат
}
bool res = findSquare(2, 4);    // Вызываем метод и аргументы 2 числа для расчета
Console.WriteLine(res);         // Выводим на консоль