using System;

public class TugasJoin
{
    public static void Main()
    {
        string username, password;
        int age;
        string isMale, isMarried;

        string comparUsername = "Yosafat";
        string comparPassword = "OCBC";
        int comparAge = 18;

        int nilai1, nilai2, nilai3, total;
        double rata;

        do
        {
            Console.WriteLine("\t ======= Biodata =======");

            Console.Write("\t Username : ");
            username = Console.ReadLine();

            Console.Write("\t Password : ");
            password = Console.ReadLine();

            Console.Write("\t Umur : ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\t Jenis Kelamin : ");
            Console.WriteLine("\t [1] Laki Laki ");
            Console.WriteLine("\t [2] Perempuan ");
            Console.Write("\t => ");
            isMale = Console.ReadLine() == "1" ? "Laki - Laki" : "Perempuan";

            Console.WriteLine("\n\t Status Nikah : ");
            Console.WriteLine("\t [1] Belum Menikah");
            Console.WriteLine("\t [2] Sudah Menikah");
            Console.Write("\t => ");
            isMarried = Console.ReadLine() == "1" ? "Belum Menikah" : "Sudah Menikah";

            if (username != comparUsername || password != comparPassword)
            {
                Console.WriteLine("\n\t Username atau Password belum valid\n");
            }
            else if (age <= comparAge)
            {
                Console.WriteLine("\n\t Umur belum mencukupi\n");
            }

        } while (username != comparUsername || password != comparPassword || age <= comparAge);

        Console.Write("\n\t Nilai 1 : ");
        nilai1 = int.Parse(Console.ReadLine());
        Console.Write("\t Nilai 2 : ");
        nilai2 = int.Parse(Console.ReadLine());
        Console.Write("\t Nilai 3 : ");
        nilai3 = int.Parse(Console.ReadLine());
        total = nilai1 + nilai2 + nilai3;
        rata = total / 3.0;

        Console.WriteLine("\n\t ======= BIODATA ANDA =======");
        Console.WriteLine($"\t Username: {username}");
        Console.WriteLine($"\t Password: {password}");
        Console.WriteLine($"\t Umur: {age}");
        Console.WriteLine($"\t Jenis Kelamin: {isMale}");
        Console.WriteLine($"\t Status Menikah: {isMarried}");

        Console.WriteLine("\n\t ======= ARITMATIKA =======");
        Console.WriteLine($"\t Total Nilai adalah: {total}");
        Console.WriteLine($"\t Rata rata Nilai adalah: {rata}");
    }
}