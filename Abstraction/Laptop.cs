using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class Laptop : Gadget
    {
        public override void Fungsi()
        {
            Console.WriteLine("2. LAPTOP");
            Console.WriteLine("   =>Laptop biasa digunakan untuk pekerjaan");
        }
    }
}
