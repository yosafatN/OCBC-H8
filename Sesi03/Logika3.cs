using System;

public class Logika3
{
    public static void Main()
    {
        string username, password;
        string COMPERE_USERNAME = "OCBC", COMPERE_PASSWORD = "Bootcamp";

        do
        {
            Console.Write("\n Username : ");
            username = Console.ReadLine();
            Console.Write(" Password : ");
            password = Console.ReadLine();

            if (username == COMPERE_USERNAME && password == COMPERE_PASSWORD)
            {
                Console.WriteLine("\t Anda berhasil login");
            }
            else
            {
                Console.WriteLine("\t Username atau Password anda salah");
            }
        } while (username != COMPERE_USERNAME || password != COMPERE_PASSWORD);
    }
}