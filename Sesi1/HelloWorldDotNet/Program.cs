using System;

namespace HelloWorldDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string fname, lname, address, birthDate;
            int age;
            bool[] vaccine = new bool[2];

            Console.Write("Enter Your First Name\t: ");
            fname = Console.ReadLine();

            Console.Write("Enter Your Last Name\t: ");
            lname = Console.ReadLine();

            Console.Write("Enter Your Age\t\t: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Address\t: ");
            address = Console.ReadLine();

            Console.Write("Enter Your Birth Date\t: ");
            birthDate = Console.ReadLine();

            Console.Write("First Vaccinated [y/N]\t: ");
            vaccine[0] = String.Equals(Console.ReadLine(), "y");

            Console.Write("Second Vaccinated [y/N]\t: ");
            vaccine[1] = String.Equals(Console.ReadLine(), "y");

            Console.WriteLine($"\nYour Full Name is \t: {fname} {lname}");
            Console.WriteLine($"$Your Age is \t\t: {age}");
            Console.WriteLine($"Your Address is \t: {address}");
            Console.WriteLine($"Your Birth Date is \t: {birthDate}");
            Console.WriteLine($"First Vaccine \t\t: {vaccine[0]}");
            Console.WriteLine($"Second Vaccine \t\t: {vaccine[1]}");
        }
    }
}
