using System;

public class Logika5
{
    public static void Main()
    {
        int nilai;
        bool isExit = false;

        do
        {
            Console.Write("\nMasukan Bulan [1 ~ 12]: ");
            nilai = int.Parse(Console.ReadLine());

            switch (nilai)
            {
                case 1:
                    {
                        Console.WriteLine("Januari");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Febuari");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Maret");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("April");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Mei");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Juni");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Juli");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Agustus");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("September");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Oktober");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("November");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Desember");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Range angka 1 ~ 12");
                        break;
                    }
            }
            Console.Write("\nCoba Ulang? [y/N]: ");
            isExit = Console.ReadLine() != "y";
        } while (!isExit);
    }
}