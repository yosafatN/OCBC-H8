using System;

namespace pro3
{
    class PesawatTempur : Pesawat
    {
        public void terbangTinggi()
        {
            Console.WriteLine($"\nPesawat Tempur dengan nama {this.Nama}, yang mempunyai jumlah roda {this.JumlahRoda}, sedang berada pada ketinggian {this.Ketinggian} kaki dengan jumlah penumpang sebanyak {this.JumlahPenumpang} akan meledakkan senjata");
        }
    }
}