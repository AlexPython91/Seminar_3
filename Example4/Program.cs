using System;

// Найти максимальное из трех чисел

int a = 2;
int b = 3;
int c = 5;
int max = a;

if(b > max) max = b;
if(c > max) max = c;
else max = a;

Console.WriteLine("Максимальное число = " + max);
