using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projec6
{
    public class Student : IStudent
    {
        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }
        public virtual string LastName { get; set; }

        public Student(string name, string surname, string lastName)
        {
            Name = name;
            Surname = surname;
            LastName = lastName;
        }
    }
}
