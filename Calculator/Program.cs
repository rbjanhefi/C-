using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Judul
            Console.Title = "Aplikasi Calculator";

            //Menu
            Console.WriteLine("Pilih menu calculator");
            Console.WriteLine("");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("");

            Console.Write("Input nomor menu [1-4] : ");
            int Pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Menampilkan angka
            if (Pilihan == 1)
            {
                //Input angka
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2}", a, b, Penjumlahan(a, b));
            }

            else if (Pilihan == 2)
            {
                //Input angka
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }

            else if (Pilihan == 3)
            {
                //Input angka
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Hasil Perkalian {0} x {1} = {2}", a, b, Perkalian(a, b));
            }

            else if (Pilihan == 4)
            {
                //Input angka
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }

            else
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak ada");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        //Fungsi operasi
        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
