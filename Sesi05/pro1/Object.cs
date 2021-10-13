using System;

namespace Object
{
    class Laptop
    {
        public string merk;
        public int ram;
        public int memory;

        public Laptop(string merk, int ram, int memory)
        {
            this.merk = merk;
            this.ram = ram;
            this.memory = memory;
        }
        public void Chatting()
        {
            Console.WriteLine("\n{0} sedang chatting", this.merk);
        }
        public void Sosmed()
        {
            Console.WriteLine("\n{0} sedang sosmed", this.merk);
        }
        public void OnlineShop()
        {
            Console.WriteLine("\n{0} sedang online shop", this.merk);
        }
    }
}