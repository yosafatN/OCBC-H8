using System;
public class HitungNilai
{
    public static void Main()
    {
        int pertama, kedua, ketiga, total;
        double rata;

        Console.WriteLine("=== Menghitung Nilai ===");
        Console.Write("Masukkan nilai pertama : ");
        pertama = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai kedua: ");
        kedua = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai ketiga: ");
        ketiga = int.Parse(Console.ReadLine());

        total = pertama + kedua + ketiga;
        rata = total / 3.0;
        Console.WriteLine($"Total Nilai adalah: {total}");
        Console.WriteLine($"Rata Rata Nilai adalah: {rata}");
        Console.Read();
    }
}