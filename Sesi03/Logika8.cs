using System;

public class Logika7
{

    public static void Main()
    {
        string menu;
        bool isExit = false;
        int start, end;

        do
        {
            Console.WriteLine("\n[1] Increment by 2");
            Console.WriteLine("[2] Decrement by 2");
            Console.WriteLine("[3] Multiplied by 2");
            Console.WriteLine("[4] Divided by 2");
            Console.Write("=> ");
            menu = Console.ReadLine();

            Console.Write("Start : ");
            start = int.Parse(Console.ReadLine());
            Console.Write("End : ");
            end = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case "1":
                    incrementBy2(start, end);
                    break;
                case "2":
                    decrementBy2(start, end);
                    break;
                case "3":
                    multipleBy2(start, end);
                    break;
                case "4":
                    dividedBy2(start, end);
                    break;
            }

            Console.Write("\nCoba Ulang? [y/N]: ");
            isExit = Console.ReadLine() != "y";
        } while (!isExit);
    }

    static void incrementBy2(int start, int end)
    {
        while (start <= end)
        {
            Console.WriteLine($"i = {start}");
            start += 2;
        }
    }

    static void decrementBy2(int start, int end)
    {
        while (start >= end)
        {
            Console.WriteLine($"i = {start}");
            start -= 2;
        }
    }

    static void multipleBy2(int start, int end)
    {
        while (start <= end)
        {
            Console.WriteLine($"i = {start}");
            start *= 2;
        }
    }

    static void dividedBy2(int start, int end)
    {
        double forDouble = start;
        while (forDouble >= end)
        {
            Console.WriteLine($"i = {forDouble}");
            forDouble /= 2;
        }
    }
}