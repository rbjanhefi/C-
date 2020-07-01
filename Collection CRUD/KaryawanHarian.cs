﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD
{
    public class KaryawanHarian : Karyawan
    {
        public double JumlahJamKerja { get; set; }
        public double UpahPerJam { get; set; }

        public override double Gaji()
        {
            return JumlahJamKerja * UpahPerJam;
        }
    }
}
