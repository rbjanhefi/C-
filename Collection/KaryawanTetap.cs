using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }

        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
