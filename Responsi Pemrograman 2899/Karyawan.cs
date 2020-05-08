using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman2899
{
    class Karyawan
    {
        public string nik1;
        public string nik2;
        public string nama1;
        public string nama2;
        public float gaji1;
        public float gaji2;

        public void DataGaji()
        {
            Console.WriteLine("No Nik/Nama\t\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. {0} {1}\t\t{2}", nik1, nama1, gaji1);
            Console.WriteLine("2. {0} {1}\t\t{2}", nik2, nama2, gaji2);
            Console.WriteLine(" ");
        }

        public void DataNaikGaji()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Asyiiiiik kenaikan gaji 10%!!");
            Console.WriteLine(" ");
            Console.WriteLine("No Nik/Nama\t\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. {0} {1}\t\t{2}", nik1, nama1, 0.1*gaji1+gaji1);
            Console.WriteLine("2. {0} {1}\t\t{2}", nik2, nama2, 0.1*gaji2+gaji2);
        }

    }
}
