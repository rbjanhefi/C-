using System;
using System.Collections.Generic;
using System.Text;

namespace Latihan_Inheritance
{
    class Teacher : Person
    {
        public Teacher (string Name, int Age, string ID, string Subject)
            :base(Name,Age)
        {
            nim = ID;
            sub = Subject;
        }

        string nim { get; set; }
        string sub { get; set; }
    }
}
