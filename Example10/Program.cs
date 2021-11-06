using System;

// Показать вторую цифру трёхзначного числа


int number = new Random().Next(100, 150);   // Создаем массив от 1 до 50
Console.WriteLine();                     // отсекаем пустой строкой
Console.WriteLine("Дано двузначное число: " + number);
Console.WriteLine();

// Решение задачи.

int secondDigit = (number / 10) % 10;
Console.WriteLine("Вторая цифра в числе = " + secondDigit);




