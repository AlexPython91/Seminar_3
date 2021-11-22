using System;

// 43. Написать программу преобразования десятичного числа в двоичное

Console.Write("Введите число в десятичной системе: ");

string ToBinary(int decimalNumber)
{
    var binaryNumber = string.Empty;
    while (decimalNumber > 0)
    {
        binaryNumber = (decimalNumber % 2) + binaryNumber;
        decimalNumber /= 2;
    }
    return binaryNumber;
}

var decNum = int.Parse(Console.ReadLine());
var binNum = ToBinary(decNum);
Console.WriteLine("Двоичное число = {1}", decNum, binNum);