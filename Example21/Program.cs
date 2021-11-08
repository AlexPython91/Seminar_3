using System;

// Программа проверяет пятизначное число на палиндромом.

int a = 12321;
int b = a / 10000;
int c = a % 10;
int d = a % 10000 / 1000;
int e = a % 100 / 10;
if(b == c && d == e) 
{
    Console.WriteLine("Полиндром");
}
else
    Console.WriteLine("Не полиндром");

