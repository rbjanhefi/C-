using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectPemrograman
{
    public class LaundryKilat : Laundry
    {

        public override Double Harga()
        {
            return Berat*8000 ;
        }
        public override void Waktu()
        {
            Console.WriteLine("|Lama Pencucian 1 Hari                      |");
            Console.WriteLine("|===========================================|");
        }
    }
  
}

