using System;

// 25. Найти сумму чисел от 1 до А

int[] array = new int[8];
Random rand = new Random();
for(int i = 0; i < 8; i++)
{
    array[i] = rand.Next(1, 15);
    Console.Write(array[i] + " ");
}

int sum = 0;
for(int i = 0; i < 8; i++)
{
    sum = sum + array[i];
}
Console.WriteLine();
Console.WriteLine(sum);





// int n, 
// sum = 0;
// Random r = new Random();
// Console.Write("Введите размерность: ");
// n = Convert.ToInt32(Console.ReadLine());
// int[,] A = new int[n, n];
// for(int i = 0; i < A.Length; i++)
// {
//     for(int j = 0; j < A.Length; j++)
//     {
//         A[i, j] = r.Next(1, 50);
//         Console.Write(A[i, j] + " ");
//         sum += A[i] + A[j];
//     }
// }
// Console.WriteLine(sum);
