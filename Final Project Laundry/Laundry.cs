using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectPemrograman
{
    public abstract class Laundry : LamaProses
    {
        public  int NoPesanan  { get; set; }
        public  string Jenis   { get; set; }
        public  string Nama    { get; set; }
        public  string Alamat  { get; set; }
        public string  Durasi  { get; set; }
        public  double Berat   { get; set; }
        public abstract Double Harga(); 
    }
}
