using System;

// По двум введённым числам проверять является ли первое квадратом второго

int numberOne = 2;
int numberTwo = 4;
//int square = numberOne * numberOne;

if(numberTwo == numberOne * numberOne)
{
    Console.WriteLine(numberTwo + " is the square of number 2");
}
else 
{
    Console.WriteLine(numberTwo + " is not the square of number 2");
}