using System;
using System.Collections.Generic;
using System.Collections;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<Karyawan> listKaryawan = new List<Karyawan>();
            List<KaryawanTetap> listKaryawanTetap = new List<KaryawanTetap>();
            List<KaryawanHarian> listKaryawanHarian = new List<KaryawanHarian>();
            List<Sales> listSales = new List<Sales>();
            int PilihanMenu, PilihanJenis;

            do{
                Console.Clear();
                Console.WriteLine("Pilihan Menu Aplikasi");
                Console.WriteLine("");
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("");
                Console.Write("Pilihan Anda [1-4] : ");
                PilihanMenu = int.Parse(Console.ReadLine());

                if (PilihanMenu == 1)
                {
                    do{
                        Console.Clear();
                        Console.WriteLine("Tambah Data Karyawan");
                        Console.WriteLine("");
                        Console.Write("Pilih Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3.Sales] : ");
                        PilihanJenis = int.Parse(Console.ReadLine());

                        if (PilihanJenis != 1 && PilihanJenis != 2 && PilihanJenis != 3)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Pilihan Tidak Tersedia !!!");
                            Console.WriteLine("");
                            Console.WriteLine("Tekan ENTER untuk memilih ulang");
                            Console.ReadKey(true);
                        }

                    } while (PilihanJenis != 1 && PilihanJenis != 2 && PilihanJenis != 3);

                    if (PilihanJenis == 1)
                    {
                        Console.WriteLine("");
                        string a = "Karyawan Tetap";
                        Console.Write("Nik : ");
                        string b = Console.ReadLine();
                        Console.Write("Nama : ");
                        string c = Console.ReadLine();
                        Console.Write("Gaji Bulanan : ");
                        double d = Double.Parse(Console.ReadLine());

                        listKaryawan.Add(new KaryawanTetap() {Jenis=a, Nik=b ,Nama=c ,GajiBulanan=d});
                    }
                    else if (PilihanJenis == 2)
                    {
                        Console.WriteLine("");
                        string a = "Karyawan Harian";
                        Console.Write("Nik : ");
                        string b = Console.ReadLine();
                        Console.Write("Nama : ");
                        string c = Console.ReadLine();
                        Console.Write("Jumlah Jam Kerja : ");
                        double d = Double.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam : ");
                        double e = Double.Parse(Console.ReadLine());

                        listKaryawan.Add(new KaryawanHarian() {Jenis = a, Nik = b, Nama = c, JumlahJamKerja=d, UpahPerJam=e });
                    }
                    else if (PilihanJenis == 3)
                    {
                        Console.WriteLine("");
                        string a = "Sales";
                        Console.Write("Nik : ");
                        string b = Console.ReadLine();
                        Console.Write("Nama : ");
                        string c = Console.ReadLine();
                        Console.Write("Jumlah Penjualan : ");
                        double d = Double.Parse(Console.ReadLine());
                        Console.Write("Komisi : ");
                        double e = Double.Parse(Console.ReadLine());

                        listKaryawan.Add(new Sales() {Jenis=a, Nik=b, Nama=c, JumlahPenjualan=d, Komisi=e});
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
                    Console.ReadKey(true);
                }
                else if (PilihanMenu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Hapus Data Karyawan");
                    Console.WriteLine("");
                    Console.Write("Masukan Nik yang ingin dihapus : ");
                    string Hapus = Console.ReadLine();
                    int i = 0;
                    bool ketemu = false;

                    foreach (Karyawan karyawan in listKaryawan)
                    {
                        if(Hapus == karyawan.Nik)
                        {
                            listKaryawan.RemoveAt(i);
                            ketemu = true;
                            break;
                        }
                        i++;
                    }
                    if(ketemu==false)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Data tidak ditemukan");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
                    Console.ReadKey(true);
                }
                else if (PilihanMenu == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Data Karyawan");
                    Console.WriteLine("");
                    int noUrut = 1;
                    
                    foreach (Karyawan karyawan in listKaryawan)
                    {
                        Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}, {4}",
                        noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji(), karyawan.Jenis);
                        noUrut++;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Tekan ENTER untuk kembali ke Menu");
                    Console.ReadKey(true);
                }
                else if (PilihanMenu == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Terima Kasih");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Pilihan Tidak Tersedia !!!");
                    Console.WriteLine("");
                    Console.WriteLine("Tekan ENTER untuk memilih ulang");
                    Console.ReadKey(true);
                }

            } while (PilihanMenu != 4);

            Console.ReadKey();
        }
    }
}
