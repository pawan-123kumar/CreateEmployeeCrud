using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEmployeeCrud
{
    internal class ListAllEmployee
    {
        List<Employee> Emplist = new List<Employee>();
        public ListAllEmployee(List<Employee> empList)
        {
            this.Emplist = empList;
        }

        public  void ShowEmployee()
        {
            if (Emplist.Count > 0)
            {
                Console.WriteLine("EmpId\tName\tDepartment\tDob\tSalary\tEmail\tHobbies\n");
                foreach (var emp in Emplist)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", emp.EmpId, emp.Name, emp.Department, emp.Dob, emp.Salary, emp.Email, emp.Hobbies + "\n");
                }
            }
            else
            {
                Console.WriteLine("EmpId\tName\tDepartment\tDob\tSalary\tEmail\tHobbies\n");
                Console.WriteLine("List is Empty please Go To Choise 1 for Add The Employees \n");
            }
        }
    }
}
