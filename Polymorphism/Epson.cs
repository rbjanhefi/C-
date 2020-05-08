﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nEpson display dimension : 10*11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
