using System;
using System.Linq;

public class PhoneNumber
{
    private const int INTERNATIONAL_COUNTRY_CODE = 1;
    private const int MAX_DIGITS = 11;
    private const int MIN_DIGITS = 10;

    private const int INTERNATIONAL_CODE_FIRSTDIG_POS = 0;
    private const int AREA_CODE_FIRSTDIG_POS = 0;
    private const int EXCHANGE_CODE_FIRSTDIG_POS = 3;

    public static string Clean(string phoneNumber)
    {
        var cleanNumber = String.Concat(phoneNumber.Where(s => char.IsDigit(s)));

        if (cleanNumber.Length < MIN_DIGITS || cleanNumber.Length > MAX_DIGITS) throw new ArgumentException();
        else if (cleanNumber.Length == MAX_DIGITS)
        {
            if ((int)Char.GetNumericValue(cleanNumber[INTERNATIONAL_CODE_FIRSTDIG_POS]) != INTERNATIONAL_COUNTRY_CODE)
                throw new ArgumentException();
            else
                cleanNumber = cleanNumber.Substring(1, MIN_DIGITS);
        }

        if (cleanNumber.Where((s,i) => i==AREA_CODE_FIRSTDIG_POS || i==EXCHANGE_CODE_FIRSTDIG_POS).Any( s => (int)Char.GetNumericValue(s) < 2)) throw new ArgumentException();


        return cleanNumber;
    }
}