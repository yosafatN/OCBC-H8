using System;

class Jagged
{
    static void Main()
    {
        int[][] jegged = new int[3][];
        jegged[0] = new int[4];
        jegged[1] = new int[3];
        jegged[2] = new int[5];
        int i;

        for (i = 0; i < 4; i++)
            jegged[0][i] = i;

        for (i = 0; i < 3; i++)
            jegged[1][i] = i;

        for (i = 0; i < 5; i++)
            jegged[2][i] = i;

        for (i = 0; i < 4; i++)
            Console.Write(jegged[0][i] + " ");
        Console.WriteLine();

        for (i = 0; i < 3; i++)
            Console.Write(jegged[1][i] + " ");
        Console.WriteLine();

        for (i = 0; i < 5; i++)
            Console.Write(jegged[2][i] + " ");
        Console.WriteLine();
    }
}