using System;
using System.Collections.Generic;
using System.Linq;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        return IsValidTriangle(side1,side2,side3) 
            && side1 != side2 & side1 != side3 & side2 != side3;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        return IsValidTriangle(side1, side2, side3)
            && (side1 == side2 || side1 == side3 || side2 == side3);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        return IsValidTriangle(side1, side2, side3) 
            && side1 == side2 & side1 == side3 & side1!= 0;
    }

    private static bool IsValidTriangle(double side1, double side2, double side3)
    {
        List<double> sides = new List<double> { side1, side2, side3 }.OrderByDescending(s=>s).ToList();
 
        return sides[0] < sides[1] + sides[2];
    }
}