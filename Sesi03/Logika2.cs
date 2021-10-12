using System;

public class Logika1
{
    public static void Main()
    {
        int nilai;
        bool isExit = false;

        do
        {
            Console.Write("\nMasukan Nilai: ");
            nilai = int.Parse(Console.ReadLine());

            if (nilai < 60)
            {
                Console.WriteLine("Nilai Anda C");
            }
            else if (nilai < 80)
            {
                Console.WriteLine("Nilai Anda B");
            }
            else
            {
                Console.WriteLine("Nilai Anda A");
            }

            Console.Write("\nCoba Ulang? [y/N]: ");
            isExit = Console.ReadLine() != "y";
        } while (!isExit);
    }
}