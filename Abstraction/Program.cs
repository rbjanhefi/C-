using Abstraction.AbstractClass;
using Abstraction.Interface;
using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTOH-CONTOH GADGET BESERTA FUNGSI");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            
            //Abstract Class (Handphone dan Laptop)
            Gadget gadget;

            gadget = new Handphone();
            gadget.Fungsi();

            Console.WriteLine();
            gadget = new Laptop();
            gadget.Fungsi();


            //Interface (Camera)
            IGadget2 gadget2;

            Console.WriteLine();
            gadget2 = new Camera();
            gadget2.Fungsi();

            Console.ReadKey();
        }
    }
}
