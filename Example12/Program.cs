using System;

// Удалить вторую цифру трёхзначного числа


int number = new Random().Next(100, 999);                  // Создаем число от 100 до 999
Console.WriteLine("Given a three-digit number: " + number); //
Console.WriteLine();


int firstDigit = number / 100;         // Узнаем первую цифру
int secondDigit = number / 10 % 10;     // Узнаем вторую и откидываем остаток. ЖУТКИЙ КОСТЫЛЬ №1))
int thirdDigit = number % 10;            // Узнаем полследнюю цифру
int result = firstDigit + thirdDigit;

Console.WriteLine("Deleted second digit " + secondDigit);   // Выводим в консоль удаленную цифру
Console.WriteLine();
Console.WriteLine("Result = " + $"{firstDigit}{thirdDigit}");  // ЖУТКИЙ КОСТЫЛЬ №2!)) Выводим в консоль результат




// int result = number / 100 / 10 % 10;
// Console.WriteLine(result);


