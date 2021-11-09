using System;

// Написать программу вычисления значения функции y=f(a)

// int f = 6;    // взяли произвольное число
// int y = f * f - 5;    // расчет по формуле 
// Console.WriteLine(y);

// Второй вариант методом

int f = 3;

int findValue(int f)
{
    //int y = f * f - 5;
    return (f * f) - 5;
}
Console.WriteLine(findValue(f));