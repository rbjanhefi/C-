using System;
using System.Collections.Generic;
using System.Text;

namespace Latihan_Inheritance
{
    class Person
    {
        public Person(string Name, int Age)
        {
            nama = Name;
            umur = Age;
        }

        public string nama { get; set; }
        public int umur { get; set; }

        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name : {0} and age : {1} ", nama, umur);
        }
    }
}
