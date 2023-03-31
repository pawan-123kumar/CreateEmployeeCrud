using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEmployeeCrud
{
    internal class EditEmployee
    {
        List<Employee> Emplist = new List<Employee>();
        public EditEmployee(List<Employee> empList)
        {
            this.Emplist = empList;
        }
        public void EditEmpDetails()
        {
            Validation validate = new Validation();
            Console.WriteLine("Edit Employee");
            Console.WriteLine("Enter EmpId you want to Edit");
            int y;
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Please Provide Valid Input");
            }
            Employee? EditEmp = Emplist.FirstOrDefault(e => e.EmpId == y);
            if (EditEmp != null)
            {
                //Console.WriteLine("Please enter name");
                //string? name = Console.ReadLine();
                //name = validate.checkName(name);
                //EditEmp.Name = name;
                Console.WriteLine("Please enter department");
                string? dept = Console.ReadLine();
                dept = validate.checkName(dept);
                EditEmp.Department = dept;
                Console.WriteLine("please enter dateofbirth");
                DateTime dob;
                while(!DateTime.TryParse(Console.ReadLine(), out dob))
                {
                    Console.WriteLine("please provide a valid Date");
                }
                EditEmp.Dob=dob.Date.ToString("d");
                Console.WriteLine("please enter salary");
                double sal;
                if (!double.TryParse(Console.ReadLine(), out sal))
                {
                    Console.WriteLine("please enter correct amount");
                }
                EditEmp.Salary = sal;
                //Console.WriteLine("please enter your email Address");
                //string? email = Console.ReadLine();
                //email = validate.checkName(email);
                //EditEmp.Email = email;
                Console.WriteLine("please enter your Hobbies");
                string? hob = Console.ReadLine();
                hob = validate.checkName(hob);
                EditEmp.Hobbies = hob;
                Console.WriteLine("Employee Updated Sucessfully. please select Choise 2 for view employee");
            }
            else
                Console.WriteLine("Employee not found please Enter a valid EmpId");
        }
    }
}
