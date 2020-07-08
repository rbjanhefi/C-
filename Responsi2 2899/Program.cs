using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();
        
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4:
                        EditPenjualan();
                        break;

                    case 5: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("3. Edit Penjualan");
            Console.WriteLine("4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            string jenis2;
            
            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine("");
            
            Console.Write("Nota : ");
            string nota = Console.ReadLine();
            Console.Write("Tanggal : ");
            string tanggal = Console.ReadLine();
            Console.Write("Customer : ");
            string customer = Console.ReadLine();
            Console.Write("Jenis [T/K] : ");
            char jenis = char.Parse(Console.ReadLine());
            if(jenis == 'T' || jenis == 't')
            {
                jenis2 = "Tunai";
            }
            else
            {
                jenis2 = "Kredit";
            }

            Console.Write("Total Nota : ");
            double total = double.Parse(Console.ReadLine());

            daftarPenjualan.Add(new Penjualan { Nota = nota, Tanggal = tanggal, Customer = customer, Jenis = jenis2, Total = total});

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            Console.WriteLine("Hapus Data Penjualan");
            Console.WriteLine("");
            Console.Write("Nota : ");
            string Hapus = Console.ReadLine();
            int i = 0;
            bool ketemu = false;

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (Hapus == penjualan.Nota)
                {
                    daftarPenjualan.RemoveAt(i);
                    ketemu = true;
                    Console.WriteLine("");
                    Console.WriteLine("Data Penjualan berhasil dihapus");

                    break;
                }
                i++;
            }
            if (ketemu == false)
            {
                Console.WriteLine("");
                Console.WriteLine("Data tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.Clear();
            Console.WriteLine("Tampil Data Penjualan");
            Console.WriteLine("");
            int Nomor = 1;

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                Nomor, penjualan.Nota, penjualan.Tanggal, penjualan.Customer, penjualan.Jenis, penjualan.Total);
                Nomor++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }

        static void EditPenjualan()
        {
            Console.Clear();

            string jenis2;
            Console.WriteLine("Edit Data Penjualan");
            Console.WriteLine("");
            Console.Write("Nota : ");
            string Cari = Console.ReadLine();
            int i = 0;
            bool ketemu = false;

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (Cari == penjualan.Nota)
                {
                    //menampilkan nota yg akan di edit
                    Console.WriteLine("");
                    Console.WriteLine("Edit Data");
                    Console.WriteLine("");
                    Console.Write("Tanggal : ");
                    string tanggal = Console.ReadLine();
                    Console.Write("Customer : ");
                    string customer = Console.ReadLine();
                    Console.Write("Jenis [T/K] : ");
                    char jenis = char.Parse(Console.ReadLine());
                    if (jenis == 'T' || jenis == 't')
                    {
                        jenis2 = "Tunai";
                    }
                    else
                    {
                        jenis2 = "Kredit";
                    }
                    Console.Write("Total Nota : ");
                    double total = double.Parse(Console.ReadLine());

                    penjualan.Customer = customer;
                    penjualan.Tanggal = tanggal;
                    penjualan.Jenis = jenis2;
                    penjualan.Total = total;

                    ketemu = true;

                    break;
                }
                i++;
            }
            if (ketemu == false)
            {
                Console.WriteLine("");
                Console.WriteLine("Data tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
    }
    
}