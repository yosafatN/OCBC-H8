using System;
using Object;

namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempMerk;
            int tempRam, tempMemory;

            Console.Clear();
            Console.WriteLine("Masukan Merk Laptop");
            Console.Write("=> ");
            tempMerk = Console.ReadLine();

            Console.WriteLine("\nMasukan Kapasitas RAM Laptop");
            Console.Write("=> ");
            tempRam = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMasukan Kapasitas Memoru Laptop");
            Console.Write("=> ");
            tempMemory = int.Parse(Console.ReadLine());

            Object.Laptop laptop1 = new Object.Laptop(tempMerk, tempRam, tempMemory);

            Console.WriteLine($"\nMerk Laptop adalah {laptop1.merk}");
            Console.WriteLine($"Kapasitas RAM adalah {laptop1.ram}");
            Console.WriteLine($"Kapasitas Memory adalah {laptop1.memory}");

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}
