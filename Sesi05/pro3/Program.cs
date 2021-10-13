using System;

namespace pro3
{
    class Program
    {
        public int bilangan1, bilangan2;

        public void bilangan(int angka1, int angka2)
        {
            bilangan1 = angka1;
            bilangan2 = angka2;
        }

        public virtual void penjumlahanPerkalian()
        {
            Console.WriteLine("\n============== Overriding 1 ==============");
            Console.WriteLine($"Hasil penjumlahan angka {bilangan1} dan angka {bilangan2} = {bilangan1 + bilangan2}");
            Console.WriteLine($"Hasil perkalian angka {bilangan1} dan angka {bilangan2} = {bilangan1 * bilangan2}");
        }
    }
    class Overide : Program
    {
        public override void penjumlahanPerkalian()
        {
            Console.WriteLine("\n============== Overriding 2 ==============");
            Console.WriteLine($"Hasil pembagian angka {bilangan1} dan angka {bilangan2} = {bilangan1 / bilangan2}");
            Console.WriteLine($"Hasil pengurangan angka {bilangan1} dan angka {bilangan2} = {bilangan1 - bilangan2}");
        }

        static void Main(string[] args)
        {
            string menu;
            bool isExit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("======= Menu =======");
                Console.WriteLine("[1] Pesawat Tempur");
                Console.WriteLine("[2] Overloading");
                Console.WriteLine("[3] Override");
                Console.WriteLine("[4] Tentang Saya");
                Console.WriteLine("[0] Keluar");
                Console.Write("=> ");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        pesawatTempur();
                        break;

                    case "2":
                        dataOverloading();
                        break;

                    case "3":
                        angka();
                        break;

                    case "4":
                        aboutMe();
                        break;

                    case "0":
                        isExit = true;
                        break;
                }
            } while (!isExit);
        }

        static void pesawatTempur()
        {
            Pesawat pesawat = new Pesawat();
            PesawatTempur pesawatTempur = new PesawatTempur();

            Console.Clear();
            Console.WriteLine("========== Pesawat ===========");
            Console.Write("Nama Pesawat     : ");
            pesawat.Nama = Console.ReadLine();
            Console.Write("Ketinggian       : ");
            pesawat.Ketinggian = int.Parse(Console.ReadLine());
            Console.Write("Jumlah Roda      : ");
            pesawat.JumlahRoda = int.Parse(Console.ReadLine());
            Console.Write("Jumlah Penumpang : ");
            pesawat.JumlahPenumpang = int.Parse(Console.ReadLine());

            Console.WriteLine("\n======= Pesawat Tempur =======");
            Console.Write("Nama Pesawat     : ");
            pesawatTempur.Nama = Console.ReadLine();
            Console.Write("Ketinggian       : ");
            pesawatTempur.Ketinggian = int.Parse(Console.ReadLine());
            Console.Write("Jumlah Roda      : ");
            pesawatTempur.JumlahRoda = int.Parse(Console.ReadLine());
            Console.Write("Jumlah Penumpang : ");
            pesawatTempur.JumlahPenumpang = int.Parse(Console.ReadLine());

            pesawat.terbang();
            pesawatTempur.terbangTinggi();
            Console.ReadLine();
        }

        static void dataOverloading()
        {
            string nama;
            int nomor_telepon;

            Console.Clear();
            Console.WriteLine("=============== Overloading ==============");

            Data data = new Data();
            Console.Write("Nama     : ");
            nama = Console.ReadLine();

            Console.Write("Nomor HP : ");
            nomor_telepon = int.Parse(Console.ReadLine());

            Console.WriteLine();
            data.print(nama);
            data.print(nomor_telepon);
            Console.Read();
        }

        static void angka()
        {
            int bilangan1, bilangan2;

            Console.Clear();
            Console.WriteLine("\n============ Sebelum Override ============");

            Program overiding = new Program();
            Console.Write("Bilangan 1 : ");
            bilangan1 = int.Parse(Console.ReadLine());

            Console.Write("Bilangan 2 : ");
            bilangan2 = int.Parse(Console.ReadLine());

            overiding.bilangan(bilangan1, bilangan2);
            overiding.penjumlahanPerkalian();

            Console.WriteLine("\n============ Sesudah Override ============");

            overiding = new Overide();
            Console.Write("Bilangan 1 : ");
            bilangan1 = int.Parse(Console.ReadLine());

            Console.Write("Bilangan 2 : ");
            bilangan2 = int.Parse(Console.ReadLine());
            overiding.bilangan(bilangan1, bilangan2);

            overiding.penjumlahanPerkalian();
            Console.Read();
        }

        static void aboutMe()
        {
            Console.Clear();
            Console.WriteLine("Halo Nama saya Yosafat Nababan");
            Console.WriteLine("Pengalaman Coding saya lumayan seru, seru dikerjar Deadline");
            Console.WriteLine("Pengalaman belajar C# juga seru, bahasanya mirip dengan bahasa C dan Java");
            Console.WriteLine("Terima Kasih");
            Console.Read();
        }
    }
}