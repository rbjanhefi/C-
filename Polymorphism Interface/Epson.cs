using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Interface
{
    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nEpson display dimension : 10*11");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
