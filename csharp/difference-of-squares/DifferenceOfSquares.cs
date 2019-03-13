using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
      return Convert.ToInt32(Math.Pow(Enumerable.Range(1, max).Sum(), 2));
    }

    public static int CalculateSumOfSquares(int max)
    {
      return Convert.ToInt32(Enumerable.Range(1, max).Select(s => Math.Pow(s, 2)).Sum());
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return Math.Abs(CalculateSquareOfSum(max) - CalculateSumOfSquares(max));
    }
}