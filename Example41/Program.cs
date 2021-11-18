using System;

// 41. Выяснить являются ли три числа сторонами треугольника 

int a = 2;
int b = 2;
int c = 2;

if ((a < b + c) && (b < a + c) && (c < a + b))
{
    Console.WriteLine("Треугольник");
}
else
{
    Console.WriteLine("Не треугольник");
}

// Метод

// bool IsTriangle(int a, int b, int c)
// {
//     if ((a < b + c) && (b < a + c) && (c < a + b))
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// if (IsTriangle(2, 3, 5) == true)
// {
//     Console.WriteLine("Треугольник");
// }
// else
// {
//     Console.WriteLine("Не треугольник");
// }

