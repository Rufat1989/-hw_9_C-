using System;
using static System.Console;

Clear();
Write("Введите N: ");
int N = int.Parse(ReadLine());
Write("Введите M: ");
int M = int.Parse(ReadLine());

SumNumbers(N, M);


void SumNumbers(int N, int M)
{
    Write(Sum(N - 1, M));
}

int Sum(int N, int M)
{
    int res = N;
    if (N == M)
        return 0;
    else
    {
        N++;
        res = N + Sum(N, M);
        return res;
    }
}
