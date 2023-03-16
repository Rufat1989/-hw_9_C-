using System;
using static System.Console;

Clear();
Write("Введите N: ");
int N = int.Parse(ReadLine());
Write("Введите M: ");
int M = int.Parse(ReadLine());

AkkermanFunction(N,M);

void AkkermanFunction(int N, int M)
{
    Write(Akkerman(N, M)); 
}

int Akkerman(int N, int M)
{
    if (N == 0)
    {
        return M + 1;
    }
    else if (M == 0 && N > 0)
    {
        return Akkerman(N - 1, 1);
    }
    else
    {
        return (Akkerman(N - 1, Akkerman(N, M - 1)));
    }
}
