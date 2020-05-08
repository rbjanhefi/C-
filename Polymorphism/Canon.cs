using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nCanon display dimension : 9.5*12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
}
