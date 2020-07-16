using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectPemrograman
{
    public  class LaundryExpress : Laundry 
    {
        public override Double Harga()
        {
            return Berat*10000;
        }
        public override void Waktu()
        {
            Console.WriteLine("|Lama Pencucian 10 Jam                      |");
            Console.WriteLine("|===========================================|");
        }
    }
    
}
