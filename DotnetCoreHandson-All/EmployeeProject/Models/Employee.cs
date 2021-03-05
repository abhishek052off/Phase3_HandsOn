using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public bool IsPermanent { get; set; }

        public Employee(int id, string name, double salary, bool isPermanent)
        {
            Id = id;
            Name = name;
            Salary = salary;
            IsPermanent = isPermanent;
        }
    }
}
