using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectPemrograman
{
    public class LaundryReguler : Laundry
    {
        public override double Harga()
        {
            return Berat * 6000;
        }

        public override void Waktu()
        {
            Console.WriteLine("|Lama Pencucian 3 Hari                      |");
            Console.WriteLine("|===========================================|");
        }
    }
}   
