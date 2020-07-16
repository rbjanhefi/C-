using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace FinalProjectPemrograman
{
    class Program
    {

        static List<Laundry> daftarLaundry = new List<Laundry>();

        static List<LaundryExpress> daftarLaundryExpress = new List<LaundryExpress>();
        static List<LaundryKilat> daftarLaundryKilat = new List<LaundryKilat>();
        static List<LaundryReguler> daftarLaundryReguler = new List<LaundryReguler>();
        static void Main(string[] args)
        {
            int nomor = 0;
        MENU:
            Console.Clear();
            Console.WriteLine("|=========MENU LAUNDRY=========|");
            Console.WriteLine("|1. Daftar Harga               |");
            Console.WriteLine("|2. Input Data Laundry         |");
            Console.WriteLine("|3. Riwayat Laundry            |");
            Console.WriteLine("|4. Hapus Laundry              |");
            Console.WriteLine("|5. Ubah Data Laundry          |");
            Console.WriteLine("|6. Keluar                     |");
            Console.WriteLine("|==============================|");
            Console.Write(" > Pilih Menu :  ");
            int PilihanMenu = int.Parse(Console.ReadLine());

            switch (PilihanMenu)
            {
                case 1:
                    DaftarHargaLaundry();
                    goto MENU;
                    break;
                case 2:
                    nomor++;
                    InputDataLaundry(nomor);
                    goto MENU;
                    break;
                case 3:
                    RiwayatLaundry();
                    goto MENU;
                    break;
                case 4:
                    HapusLaundry();
                    goto MENU;
                    break;
                case 5:
                    UbahLaundry();
                    goto MENU;
                    break;
                case 6:
                    return;

                default:
                    break;
            }
        }

        static void DaftarHargaLaundry()
        {
            Console.Clear();
            Console.WriteLine("|=================Daftar Harga=================|");
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("| Jenis Laundry  |   Harga(/Kg)   |   Waktu    |");
            Console.WriteLine("|----------------|----------------|------------|");
            Console.WriteLine("| 1. Express     | Rp. 10000      |  10 Jam    |");
            Console.WriteLine("| 2. Kilat       | Rp. 8000       |   1 Hari   |");
            Console.WriteLine("| 3. Reguler     | Rp. 6000       |   3 Hari   |");
            Console.WriteLine("|==============================================|");
            Console.WriteLine(" ");
            Console.WriteLine(" Tekan ENTER untuk Kembali Ke menu...");
            Console.ReadKey(true);
        }
        static void InputDataLaundry(int nomor)
        {
        INPUT:
            LamaProses proses;

            Console.Clear();
            Console.WriteLine("|================Input Data=================|");
            Console.WriteLine("| > Pilih Jenis Laundry                     |");
            Console.WriteLine("|   [ 1. Express ]                          |");
            Console.WriteLine("|   [ 2. Kilat   ]                          |");
            Console.WriteLine("|   [ 3. Reguler ]                          |");
            Console.WriteLine("|===========================================|");
            Console.Write(    "| >Pilih  :  ");
            int PilihanJenis = int.Parse(Console.ReadLine());
            Console.WriteLine("|===========================================|");
            if (PilihanJenis!=1 && PilihanJenis!=2 && PilihanJenis!=3)
            {
                Console.WriteLine("Pilihan Tidak Tersedia !!!");
                Console.WriteLine("");
                Console.WriteLine("Tekan ENTER untuk memilih ulang");
                Console.ReadKey(true);
                goto INPUT;
            }
            

            Console.WriteLine("|No Pesanan\t: {0}",nomor);
            Console.Write("|Nama\t\t: ");
            string nama = (Console.ReadLine());
            Console.Write("|Alamat\t\t: ");
            string alamat = (Console.ReadLine());
            Console.Write("|Berat(Kg)\t: ");
            Double berat = Double.Parse(Console.ReadLine());
            Console.WriteLine("|===========================================|");
            if (PilihanJenis==1)
            {
                string jenis = "Laundry Express";
                string durasi = "10 Jam";
                daftarLaundry.Add(new LaundryExpress { NoPesanan = nomor, Nama = nama, Alamat = alamat, Berat = berat, Jenis = jenis, Durasi = durasi }); 
                proses= new LaundryExpress();
            }
            else if (PilihanJenis == 2)
            {
                string jenis = "Laundry Kilat";
                string durasi = "1 Hari";
                daftarLaundry.Add(new LaundryKilat { NoPesanan = nomor, Nama = nama, Alamat = alamat, Berat = berat, Jenis = jenis, Durasi = durasi }); 
                proses = new LaundryKilat();
            }
            else 
            {
                string jenis = "Laundry Reguler";
                string durasi = "3 Hari";
                daftarLaundry.Add(new LaundryReguler { NoPesanan = nomor, Nama = nama, Alamat = alamat, Berat = berat, Jenis = jenis, Durasi=durasi }); 
                proses = new LaundryReguler();
            }
            proses.Waktu();

            Console.WriteLine(" Tekan ENTER untuk kembali ke menu awal.... ");
            Console.ReadKey(true);
            
        }
        static void RiwayatLaundry()
        {
            Console.Clear();
            Console.WriteLine("|================Riwayat================|");
            Console.WriteLine("|                                       |");
            int no = 0;

            //perulangan untuk menampilkan setiap riwayat pada laundry
            foreach (Laundry laundry in daftarLaundry)
            {
                no++;
                Console.WriteLine("|#{0}. \t\t\t\t\t|",no);                      
                Console.WriteLine("|Jenis Laundry\t: {0}\t|", laundry.Jenis);    
                Console.WriteLine("|No Pesanan\t: {0}\t\t\t|", laundry.NoPesanan);
                Console.WriteLine("|Nama\t\t: {0}", laundry.Nama); 
                Console.WriteLine("|Alamat\t\t: {0}", laundry.Alamat);
                Console.WriteLine("|Berat\t\t: {0} Kg\t\t\t|", laundry.Berat);
                Console.WriteLine("|Waktu\t\t: {0}     \t\t|", laundry.Durasi);
                Console.WriteLine("|Total Harga\t: Rp.{0}\t\t|", laundry.Harga());
                Console.WriteLine("|=======================================|");
            }
            if (no==0)
            {
                Console.WriteLine("|       Belum Ada Riwayat Laundry!      |");
                Console.WriteLine("|                                       |");
                Console.WriteLine("|=======================================|");
            }
            Console.WriteLine("");
            Console.WriteLine(" Tekan ENTER untuk kembali ke Menu...");
            Console.ReadKey(true);
        }
        static void HapusLaundry()
        {
            //melakukan proses penghapusan pada data dari nota pesanan
            Console.Clear();
            Console.WriteLine("|===============Hapus Laundry================|");
            Console.WriteLine("|                                            |");
            Console.Write("| Masukan No pesanan yang ingin dihapus : ");
            int Hapus = int.Parse(Console.ReadLine());
            int i = 0;
            bool ketemu = false;

            //perulangan untuk melakukan penghapusan
            foreach (Laundry laundry in daftarLaundry)
            {
                if (Hapus == laundry.NoPesanan)
                {
                    daftarLaundry.RemoveAt(i);
                    ketemu = true;

                    Console.WriteLine("|============================================|");
                    Console.WriteLine("|*Data Telah Berhasil Di hapus               |");
                    Console.WriteLine("|============================================|");

                    break;
                }
                i++;
            }
            if (ketemu == false)
            {
                Console.WriteLine("|============================================|");
                Console.WriteLine("| Data tidak ditemukan!!                     |");
                Console.WriteLine("|============================================|");
            }
                Console.WriteLine(" ");
                Console.WriteLine(" Tekan ENTER untuk kembali ke Menu...");
                Console.ReadKey(true);
        }
        static void UbahLaundry()
        {
            Console.Clear();
            Console.WriteLine("|=========Ubah Data Laundry============|");
            Console.WriteLine("|                                      |");
            Console.Write(    "| Nota Pesanan : ");
            int Cari =int.Parse(Console.ReadLine());
            Console.WriteLine("|======================================|");
            int i = 0;
            bool ketemu = false;

            foreach (Laundry laundry in daftarLaundry)
            {
                if (Cari == laundry.NoPesanan)
                {
                    //Menampilkan nota yang di inginkan untuk di edit
                    Console.Clear();
                    Console.WriteLine("|=======================================|");
                    Console.WriteLine("|            Data Sebelumya             |");
                    Console.WriteLine("|           ----------------            |");
                    Console.WriteLine("|Jenis Laundry\t: {0}\t|", laundry.Jenis); 
                    Console.WriteLine("|No Pesanan\t: {0}\t\t\t|", laundry.NoPesanan);
                    Console.WriteLine("|Nama\t\t: {0}", laundry.Nama);
                    Console.WriteLine("|Alamat\t\t: {0}", laundry.Alamat);
                    Console.WriteLine("|Berat\t\t: {0} Kg\t\t\t|", laundry.Berat);
                    Console.WriteLine("|Waktu\t\t: {0}     \t\t|", laundry.Durasi);
                    Console.WriteLine("|Total Harga\t: Rp.{0}\t\t|", laundry.Harga());
                    Console.WriteLine("|=======================================|");

                    //proses pengubahan data pada nota dia atas
                    Console.WriteLine("|               Ubah Data               |");
                    Console.WriteLine("|             -------------             |");
                    Console.Write("| Nama\t\t: ");
                    string nama = (Console.ReadLine());
                    Console.Write("| Alamat\t: ");
                    string alamat = (Console.ReadLine());
                    Console.Write("| Berat(Kg)\t: ");
                    Double berat = Double.Parse(Console.ReadLine());
                    Console.WriteLine("|=======================================|");
                    Console.WriteLine("| * Data Berhasil Di Ubah               |");
                    Console.WriteLine("|=======================================|");

                    laundry.Nama      = nama;
                    laundry.Alamat    = alamat;
                    laundry.Berat     = berat ;

                    ketemu = true;

                    break;
                }
                i++;
            }
            if (ketemu == false)
            {
                Console.WriteLine("| Data tidak ditemukan!!!              |");
                Console.WriteLine("|======================================|");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" Tekan ENTER untuk kembali ke menu...");
            Console.ReadKey();
        }
    
    }
}
