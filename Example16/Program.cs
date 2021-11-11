using System;

// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

Console.Write("Please enter a number from 1 to 7: ");
string c = Console.ReadLine();

bool dayOff(string a)
{
    return (a == "6" | a == "7");
}
Console.WriteLine(dayOff(c));