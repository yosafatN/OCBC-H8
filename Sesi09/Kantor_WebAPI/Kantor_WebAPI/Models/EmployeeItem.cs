using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kantor_WebAPI.Models
{
    public class EmployeeItem
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public string Alamat { get; set; }
    }
}
