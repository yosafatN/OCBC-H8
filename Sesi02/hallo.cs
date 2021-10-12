using System;

public class HelloWorld
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
        Console.WriteLine("Hello Yosafat");
        Console.WriteLine("Selamat Datang di Program Bootcamp OCBC");
        Console.WriteLine("Tahap 1 saya akan belajar C#");

        string namaCustomer = "Yosafat";

        int jumlah1 = 10, jumlah2 = 5, jumlah3 = 7;
        double harga1 = 1000, harga2 = 2000, harga3 = 3000;

        double total1 = jumlah1 * harga1;
        double total2 = jumlah2 * harga2;
        double total3 = jumlah3 * harga3;

        double totalHargaBarang = total1 + total2 + total3;
        int totalJumlahBarang = jumlah1 + jumlah2 + jumlah3;

        Console.WriteLine($"Nama Customer       : {namaCustomer}");
        Console.WriteLine($"Barang 1 ber jumlah : {jumlah1} dengan harga {harga1} yang harus dibayar {total1}");
        Console.WriteLine($"Barang 2 ber jumlah : {jumlah2} dengan harga {harga2} yang harus dibayar {total2}");
        Console.WriteLine($"Barang 3 ber jumlah : {jumlah3} dengan harga {harga3} yang harus dibayar {total3}\n");

        Console.WriteLine($"Jumlah semua barang : {totalJumlahBarang}");
        Console.WriteLine($"Total harga semua barang : {totalHargaBarang}");
    }
}