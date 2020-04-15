using System;

namespace ResponsiPemrograman2899
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan();

            karyawan.nik1 = "190302123";
            karyawan.nama1 = "Jono";
            karyawan.gaji1 = 3000000;

            karyawan.nik2 = "190302123";
            karyawan.nama2 = "Paijo";
            karyawan.gaji2 = 2000000;

            karyawan.DataGaji();
            karyawan.DataNaikGaji();
        }
    }
}
