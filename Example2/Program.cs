using System;

// Даны два числа. Показать большее и меньшее число

// int numberOne = 2;
// int numberTwo = 8;
// int max = numberOne;

// if(numberOne > numberTwo) 
// {
//     max = numberOne;
//     Console.WriteLine("Максимальное число = " + numberOne); 
//     Console.WriteLine("Минимальное число = " + numberTwo);
// }
// else
//     max = numberTwo;
//     Console.WriteLine("Максимальное число = " + numberTwo);
//     Console.WriteLine("Минимальное число = " + numberOne);
   
    // Решение методом. Вариант 2

   int findMaximumNumber(int a, int b)
   {
       if(a > b)
       {
           return a;
       }
       else return b;
   }
   Console.WriteLine(findMaximumNumber(1, 13));
