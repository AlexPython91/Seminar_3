using System;

// 45. Показать числа Фибоначчи

int firstFib = 0;
int secondFib = 1;
int n = 5;

for (int i = 0; i < n; i++)
{
    secondFib = secondFib + firstFib;
    firstFib = secondFib - firstFib;
    Console.Write(secondFib + " ");
}
