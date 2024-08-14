using System;
using System.Globalization;

namespace _211_interface_icomparable.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) {
            string[] array = csvEmployee.Split(',');
            Name = array[0];
            Salary = double.Parse(array[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{Name}, {Salary.ToString("f2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not Employee") ;
            }
            Employee other = obj as Employee;
            return Salary.CompareTo(other.Salary);
        }
    }
}
