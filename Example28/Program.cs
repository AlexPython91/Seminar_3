using System;

// 28 Подсчитать сумму цифр в числе

int num = 6524;
int result = 0; 

while(num > 0)  // num = 123      //12        // 1
{
    //int result = 0;  // result = 0     //0       //0
    result = result + num % 10;  // result = 0 + 3       // result = 0 + 2   // result = 0 + 1
    num = num / 10;           // num = 12            // num = 1     // num = 0
    //Console.WriteLine(result);   // 3       // 2       // 1
}
Console.WriteLine(result);   // 3       // 2       // 1
// 123 