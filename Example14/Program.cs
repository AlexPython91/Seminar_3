using System;

// Найти третью цифру числа или сообщить, что её нет*/

int num = new Random().Next(20, 200);   // задаем случайную цифру в диапазоне
Console.WriteLine("Number = " + num);    // Выводим в консоль
int a = num % 100 % 10;                  // Делим полученное число на 100 и вычисляем остаток
int b = num / 100;                       // делим остаток на 100

if(b <= 0)
{
    Console.WriteLine("There is no third digit ");
}
else
    Console.WriteLine("Third digit = " + a);

//int a = num % 100;
//Console.WriteLine(a);
