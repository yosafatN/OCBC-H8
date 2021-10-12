using System;

public class data2
{
    public static void Main()
    {
        string[] contoh = new string[4]{
            "Motherboard", "Processor", "Power Supply", "Video Card"
        };

        Console.WriteLine("Menampilkan semua data dalam array");
        Console.WriteLine("");

        foreach (string c in contoh)
        {
            Console.WriteLine(c);
        }

        Console.Write("Press any key to countinue");
    }
}