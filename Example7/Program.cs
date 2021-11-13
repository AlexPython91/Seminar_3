using System;

//  7. Показать числа от -N до N

string numbers (int a, int b){
    int aMath = Math.Abs(a); int bMath = Math.Abs(b);
    int sum = 0;
    if (a < 0 & b < 0)
    {
        sum = aMath - bMath;
    }
    if (a < 0 & b > 0)
    {
        sum = aMath + bMath;
    }
    if (a > 0 & b > 0)
    {
        sum = b - a;
    }
    int [] arr = new int [sum + 1];
    string res = string.Empty;
        for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = a;
        a = a+1;
    }
        for (int i = 0; i < arr.Length; i++)
    {
        res = $"{Convert.ToString(res)} {Convert.ToString(arr[i])}";
    }
    return res;
}
string valueArr = numbers(-11, 11);
Console.Write($"А чисел то не мало:\n {valueArr} ");


