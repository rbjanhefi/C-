using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }

        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}
