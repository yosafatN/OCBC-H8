using System;
public class HitungNilai3
{
    public static void Main()
    {
        int nilai1, nilai2 = 0;

        Console.Write("Jumlah Nilai 1 = ");
        nilai1 = int.Parse(Console.ReadLine());
        Console.Write("Jumlah Nilai 2 = ");
        nilai2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Hasil Perbandingan: ");
        Console.WriteLine($"Nilai 1 > Nilai 2 : {nilai1 > nilai2}");
        Console.WriteLine($"Nilai 1 >= Nilai 2 : {nilai1 >= nilai2}");
        Console.WriteLine($"Nilai 1 < Nilai 2 : {nilai1 < nilai2}");
        Console.WriteLine($"Nilai 1 <= Nilai 2 : {nilai1 <= nilai2}");
        Console.WriteLine($"Nilai 1 == Nilai 2 : {nilai1 == nilai2}");
        Console.WriteLine($"Nilai 1 != Nilai 2 : {nilai1 != nilai2}");
    }
}