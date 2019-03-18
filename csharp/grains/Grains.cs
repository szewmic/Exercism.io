using System;
using System.Linq;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 0 || n > 64 || n == 0)
            throw new ArgumentOutOfRangeException();

        ulong onSquare = 1;
        if (n != 1)
                Enumerable.Range(2, n - 1).ToList().ForEach(i => onSquare = onSquare * 2);

        return onSquare;
    }

    public static ulong Total()
    {
        ulong total = 0;
        Enumerable.Range(1, 64).Select(s => Square(s)).ToList().ForEach(i => total = total + i);

        return total;
    }
}