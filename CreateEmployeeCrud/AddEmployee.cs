using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEmployeeCrud
{
    internal class AddEmployee
    {
        int EmpId = 0;

        public void addDetails(List<Employee> employees)
        {

            Validation validate = new Validation();
            Console.WriteLine("Add Employee Details");
            Console.WriteLine("Enter Employee Name :");
            string? name = Console.ReadLine();
            name=validate.checkName(name);
            Console.WriteLine("Please Enter Department");
            string? deptt = Console.ReadLine();
            deptt=validate.checkName(deptt);
            Console.WriteLine("Please Enter  Date-Of-Birth :");
            DateTime dob;
            while(!DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.WriteLine("Please Enter a Valid Date-Of-Birth");
            }
            string dob1=dob.Date.ToString("d");
            Console.WriteLine("please enter your salary");
            double sal;
            while(!double.TryParse(Console.ReadLine(), out sal))
            {
                Console.WriteLine("Please Enter Correct Salary");
            }
            Console.WriteLine("Please Enter Your Email Address");
            string? email = Console.ReadLine();
            email=validate.checkEmail(email);
            Console.WriteLine("please enter your Hobbies");
            string? hob = Console.ReadLine();
            hob=validate.checkName(hob);
            //com_name = validate.checkName(com_name);

            // Increment id by 1.
            
            if (employees.Count == 0)
            {

                EmpId = 1;
            }
            else
            {
                EmpId = employees.Max(emp => emp.EmpId);
                EmpId++;
            }

            Employee obj1 = new Employee(EmpId, name, deptt, dob1, sal, email, hob);
            employees.Add(obj1);
            Console.WriteLine("Employee Added successfully \n");
        }
    }
}
