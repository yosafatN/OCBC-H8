using System;

public class Logika1
{
    public static void Main()
    {
        int a, b;

        Console.Write("\nNilai A: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Nilai B: ");
        b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("A lebih besar dari B");
        }
        else if (a == b)
        {
            Console.WriteLine("A sama dengan B");
        }
        else
        {
            Console.WriteLine("A lebih kecil dari B");
        }
    }
}