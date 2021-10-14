using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
    public class Data
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string headphone { get; set; }

        public Data (int id, string nama, string alamat, string headphone)
        {
            this.id = id;
            this.nama = nama;
            this.alamat = alamat;
            this.headphone = headphone;
        }
    }
}
