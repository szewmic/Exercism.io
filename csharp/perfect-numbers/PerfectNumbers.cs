using System;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        int aliquotSum = Enumerable.Range(1, number - 1).Where(x => number % x == 0).Sum();

        if (aliquotSum == number)
            return (Classification)0;
        else if (aliquotSum > number)
            return (Classification)1;
        else
            return (Classification)2;
    }
}
