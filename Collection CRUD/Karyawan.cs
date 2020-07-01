using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD
{
    public abstract class Karyawan
    {
        public string Jenis { get; set; }
        public string Nik { get; set; }
        public string Nama { get; set; }

        public abstract double Gaji();
    }
}
