using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projec6
{
    public abstract class AddGrade : Student
    {
        protected AddGrade(string name, string surname, string lastName) : base(name, surname, lastName)
        {
        }

        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Surname { get => base.Surname; set => base.Surname = value; }
        public override string LastName { get => base.LastName; set => base.LastName = value; }
    }
}
