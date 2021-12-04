using System;

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом 

double[] RealArray = new double[5];
double min = 0;
double max = 0;
double R;

for(int i = 0; i < RealArray.Length; i++)
{
    Console.Write("Введите {0}-е число: ", i + 1);
    R = double.Parse(Console.ReadLine());

    if(R > max && R < min) max = R; min = R;
}
Console.WriteLine("Разница между числами = {0}", max - min);

