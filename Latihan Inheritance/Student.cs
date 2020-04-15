using System;
using System.Collections.Generic;
using System.Text;

namespace Latihan_Inheritance
{
    class Student : Teacher
    {
        public Student(string Name, int Age, string ID, string Subject)
            :base(Name,Age,ID,Subject)
        {
            email = Subject;
        }

        string email { get; set; }
    }
}
