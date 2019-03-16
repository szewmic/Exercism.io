using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private List<Allergen> allergens = new List<Allergen>();
    public Allergies(int mask)
    {
        string binaryMask = Convert.ToString(mask, 2);

        allergens = binaryMask
            .Select((s, i) => Char.GetNumericValue(s) * Math.Pow(2, binaryMask.Length - i - 1))
            .Where(x => x>0 & x<=128)
            .Select(s => ((Allergen)(Int32)s))
            .Reverse()
            .ToList();
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        if (allergens.Contains(allergen))
            return true;
        else
            return false;    
    }

    public Allergen[] List()
    {
        return allergens.ToArray();
    }
}