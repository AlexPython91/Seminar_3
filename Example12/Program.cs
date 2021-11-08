using System;

// Удалить вторую цифру трёхзначного числа


// int number = new Random().Next(100, 999);                  // Создаем число от 100 до 999
// Console.WriteLine("Given a three-digit number: " + number); //
// Console.WriteLine();


// int firstDigit = number / 100;         // Узнаем первую цифру
// int secondDigit = number / 10 % 10;     // Узнаем вторую и откидываем остаток. ЖУТКИЙ КОСТЫЛЬ №1))
// int thirdDigit = number % 10;            // Узнаем полследнюю цифру
// int result = firstDigit + thirdDigit;

// Console.WriteLine("Deleted second digit " + secondDigit);   // Выводим в консоль удаленную цифру
// Console.WriteLine();
// Console.WriteLine("Result = " + $"{firstDigit}{thirdDigit}");  // ЖУТКИЙ КОСТЫЛЬ №2!)) Выводим в консоль результат

// Вариант решения на Семинаре №4

int number = new Random().Next(100, 1000);    // Задаем случайное число в диапазоне
Console.WriteLine("Given a three-digit number: " + number);   // Выводим в консоль

int firsNumber = number / 100;    // Узнаем первую цифру
int secondNumber = number % 10;    // Узнаем полследнюю цифру

Console.WriteLine("Number without second digit" + $" = {firsNumber}{secondNumber}");

