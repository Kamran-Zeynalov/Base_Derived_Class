using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    internal class Teacher : Person
    {
        public Teacher(string name, string surname, byte age) : base(name, surname, age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void Explain()
        {
            Console.WriteLine("Explane Base Class and Derived Class in C#");
        }

    }
}
