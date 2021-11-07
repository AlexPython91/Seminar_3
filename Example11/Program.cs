using System;

// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 99);                         // Задаем случ. двузначное число
Console.WriteLine("Given in significant number: " + number);   // Вывод в терминал

int firstDigit = number / 10;    // Полученное число делим на 10
int secondDigit = number % 10;        // от полученного числа

if(firstDigit > secondDigit)     // Сравниваем деленное число с отсатком от деленного числа
{
    Console.WriteLine("The first digit is greater");       // Вывод результата сравнения
}
else
    Console.WriteLine("The second digit is greater");

