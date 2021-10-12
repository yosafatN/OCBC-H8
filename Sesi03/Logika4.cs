using System;

public class Logika4
{
    public static void Main()
    {
        int nilai;
        bool isExit = false;
        bool isNumeric;

        do
        {
            Console.Write("\nMasukan Nilai: ");
            nilai = int.Parse(Console.ReadLine());

            if (nilai >= 85)
            {
                Console.WriteLine("Kamu mendapatkan grade A");
            }
            else if (nilai >= 65)
            {
                Console.WriteLine("Kamu mendapatkan grade B");
            }
            else if (nilai >= 45)
            {
                Console.WriteLine("Kamu mendapatkan grade C");
            }
            else
            {
                Console.WriteLine("Kamu mendapatkan grade D");
            }

            Console.Write("\nCoba Ulang? [y/N]: ");
            isExit = Console.ReadLine() != "y";
        } while (!isExit);
    }
}