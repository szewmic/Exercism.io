using System;
using System.Collections.Generic;
using System.Linq;

public static class RomanNumeralExtension
{
    public static IDictionary<int, char> dictionary =
    new Dictionary<int, char>
    {
                { 1, 'I'}, {5, 'V'}, {10, 'X'},{50,'L'},{100,'C'},{500,'D'},{1000,'M'}
    };

    public static string ToRoman(this int value)
    {
        var transformedValue = value.ToString().PadLeft(4, '0');

        return GetEachDecimalInRoman(Char.GetNumericValue(transformedValue[0]), 1000) 
             + GetEachDecimalInRoman(Char.GetNumericValue(transformedValue[1]), 100) 
             + GetEachDecimalInRoman(Char.GetNumericValue(transformedValue[2]), 10) 
             + GetEachDecimalInRoman(Char.GetNumericValue(transformedValue[3]), 1);

    }

    public static string GetEachDecimalInRoman(double number, int multiply)
    {
        int number1 = 1 * multiply;
        int number2 = 5 * multiply;
        int number3 = 10 * multiply;

        switch(number)
        {
            case 0:
                return "";
            case 1:
                return dictionary[number1].ToString();
            case 2:
                return $"{dictionary[number1]}{dictionary[number1]}";
            case 3:
                return $"{dictionary[number1]}{dictionary[number1]}{dictionary[number1]}";
            case 4:
                return $"{dictionary[number1]}{dictionary[number2]}";
            case 5:
                return dictionary[number2].ToString();
            case 6:
                return $"{dictionary[number2]}{dictionary[number1]}";
            case 7:
                return $"{dictionary[number2]}{dictionary[number1]}{dictionary[number1]}";
            case 8:
                return $"{dictionary[number2]}{dictionary[number1]}{dictionary[number1]}{dictionary[number1]}";
            case 9:
                return $"{dictionary[number1]}{dictionary[number3]}";
            default:
                return null;
        }
    }
}