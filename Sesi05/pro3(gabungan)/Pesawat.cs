using System;

namespace pro3
{
    class Pesawat
    {
        private string nama;
        private int ketinggian, jumlahRoda, jumlahPenumpang;

        public string Nama
        {
            get { return this.nama; }
            set { nama = value; }
        }

        public int Ketinggian
        {
            get { return this.ketinggian; }
            set { ketinggian = value; }
        }

        public int JumlahRoda
        {
            get { return this.jumlahRoda; }
            set { jumlahRoda = value; }
        }

        public int JumlahPenumpang
        {
            get { return this.jumlahPenumpang; }
            set { jumlahPenumpang = value; }
        }

        public void terbang()
        {
            Console.WriteLine($"\nPesawat dengan nama {this.Nama}, yang mempunyai jumlah roda {this.JumlahRoda}, sedang berada pada ketinggian {this.Ketinggian} kaki dengan jumlah penumpang sebanyak {this.JumlahPenumpang} akan menuju tujuan");
        }
    }
}