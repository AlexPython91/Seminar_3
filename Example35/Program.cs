using System;

// 35. Определить, присутствует ли в заданном массиве, некоторое число

int[] array = new int[14];
for (int i = 0; i < 14; i++)
{
    array[i] = new Random().Next(1, 14);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int N = 5;
int count = 0;
for (int i = 0; i < 14; i++)
{
    if (array[i] == N)
    {
        count = 1;
    }

}
if (count > 0)
{
    Console.WriteLine("Число " + N + " присутствует " + count + " раз");
}
else
{
    Console.WriteLine("Число отсутствует"!);
}

// int N;
// int count = 0;
// bool FindeNum(int[] array)
// {
//     for (int i = 0; i < 14; i++)
//     {
//         if (array[i] == N)
//         {
//             count++;
//         }
//     }
// }
// FindeNum(5);