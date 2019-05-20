using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black) => checkLine(white.Column, black.Column) || checkLine(white.Row, black.Row) || checkDiagonal(white, black) ? true : false;

    public static Queen Create(int row, int column)
    {
        if (validPos(row) && validPos(column))
            return new Queen(row, column);
        else
            throw new ArgumentOutOfRangeException();
    }

    private static bool validPos(int pos) => pos > -1 && pos < 8 ? true : false;

    private static bool checkLine(int x, int y) => x == y ? true : false;

    private static bool checkDiagonal(Queen black, Queen white) => Math.Abs(black.Column - white.Column) == Math.Abs(black.Row - white.Row) ? true : false;
}