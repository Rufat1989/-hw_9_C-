using System;
using static System.Console;

Clear();
Write("Введите start: ");
int N = int.Parse(ReadLine());
Write("Введите end: ");
int M = int.Parse(ReadLine());

WriteLine(PrintNumbers(N, M));

string PrintNumbers(int start, int end)
{
    if (end == start)
    {
        Console.WriteLine(end);
        return start.ToString();
    }

    string s = PrintNumbers(start, end + 1) + ' ' + end.ToString();
    Console.WriteLine(s);
    return (s);
}
