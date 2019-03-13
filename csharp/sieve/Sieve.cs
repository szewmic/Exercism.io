using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    

    public static int[] Primes(int limit)
    {
        if (limit == 1) throw new ArgumentOutOfRangeException();

        List<int> primeNumbers = new List<int>();
        List<int> allPossibilities = new List<int>();

        allPossibilities = Enumerable.Range(2, limit).ToList();

        try
        {
            while (allPossibilities.Count != 0)
            {
                primeNumbers.Add(allPossibilities[0]);
                for (int i = allPossibilities[0]; i <= limit; i = i + allPossibilities[0])
                {
                    if (allPossibilities.Contains(i))
                        allPossibilities.Remove(i);
                }
            }
        }
        catch (Exception e)
        {
            return null;
        };

        return primeNumbers.ToArray();
    }
}