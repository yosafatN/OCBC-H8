using System;

namespace pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();

            Console.Write("Nama Pesawat: ");
            pesawat.nama = Console.ReadLine();

            Console.Write("Ketinggian Pesawat: ");
            pesawat.Ketinggian = Console.ReadLine();

            pesawat.terbang();
            pesawat.sudahTerbang();
            Console.Read();
        }
    }
}
