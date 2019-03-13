using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        if (number.ToString().Select(n => Math.Pow(Char.GetNumericValue(n), number.ToString().Length)).Sum() == number)
            return true;
        return false;
    }
}