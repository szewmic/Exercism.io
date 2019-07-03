using System;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] array = new int[size, size];
        int counter = 1;
        int c1 = 0, c2 = size - 1;
        while (counter <= size * size)
        {
            //Right Direction Move  
            for (int i = c1; i <= c2; i++)
                array[c1, i] = counter++;
            //Down Direction Move  
            for (int j = c1 + 1; j <= c2; j++)
                array[j, c2] = counter++;
            //Left Direction Move  
            for (int i = c2 - 1; i >= c1; i--)
                array[c2, i] = counter++;
            //Up Direction Move  
            for (int j = c2 - 1; j >= c1 + 1; j--)
                array[j, c1] = counter++;
            c1++;
            c2--;
        }
        return array;
    }
}
