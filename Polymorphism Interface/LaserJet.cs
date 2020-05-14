using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Interface
{
    class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nLaserJet display dimension : 12*12");
        }

        public void Print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }
}
