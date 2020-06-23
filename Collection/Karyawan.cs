using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }

        public abstract double Gaji();
    }
}
