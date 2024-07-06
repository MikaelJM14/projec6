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

        public void Add(string gradentered)
        {
            double converted = char.GetNumericValue(gradentered[0]);
            if (gradentered.Length == 2 && char.IsDigit(gradentered[0]) && gradentered[0] <= '6' && (gradentered[1] == '+' || gradentered[1] == '-'))
            {
                switch (gradentered[1])
                {
                    case '+':
                        double gradeP = converted + 0.50;
                        if (gradeP > 1 && gradeP <= 6)
                        {
                            Add(gradeP);
                        }
                        else
                        {
                            throw new ArgumentException($"Invalid argument: {nameof(gradentered)}. Only grades from 1 to 6 are allowed!");
                        }
                        break;

                    case '-':
                        double gradeM = converted - 0.250;
                        if (gradeM > 1 && gradeM <= 6)
                        {
                            Add(gradeM);
                        }
                        else
                        {
                            throw new ArgumentException($"Invalid argument: {nameof(gradentered)}. Only grades from 1 to 6 are allowed!");
                        }
                        break;

                    default:
                        throw new ArgumentException($"Invalid argument: {nameof(gradentered)}. Only grades from 1 to 6 are allowed!");
                }
            }
            else
            {
                double gradeDoubled = 0;
                var Parsed = double.TryParse(gradentered, out gradeDoubled);
                if (Parsed && gradeDoubled > 1 && gradeDoubled <= 6)
                {
                    Add(gradeDoubled);
                }
                else
                {
                    throw new ArgumentException($"Invalid argument entered: {nameof(gradentered)}. Only grades from 1 to 6  are allowed!");
                }
            }
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        private void Add(double grade)
        {
            throw new NotImplementedException();
        }
    }
}
