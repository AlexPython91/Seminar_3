using System;

// 26. Возведите число А в натуральную степень B используя цикл

int toPower(int number, int degree)  // 2, 4
{
    int result = 1;      // = 1
    for (int i = 1; i <= degree; i++)
    {
        result = result * number;   // result = 2 сколько раз повториться
    }
    return result;
}

if(8 == toPower(2, 3))
{
    Console.WriteLine("Работает корректно");
}
else
{
    Console.WriteLine("Ошибка");
}

if(225 == toPower(15, 2))
{
    Console.WriteLine("Работает корректно");
}
else
{
    Console.WriteLine("Ошибка");
}