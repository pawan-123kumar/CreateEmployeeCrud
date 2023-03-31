using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEmployeeCrud
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Dob { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }
        public string Hobbies { get; set; }

        public Employee(int Id, string name, string department,string dob, double salary, string email, string hobbbies)
        {
            EmpId = Id;
            Name = name;
            Department = department;
            Dob = dob;
            Salary = salary;
            Email = email;
            Hobbies = hobbbies;
        }
    }
}
