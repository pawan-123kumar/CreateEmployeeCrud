using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEmployeeCrud
{
    internal class DeleteEmployee
    {
        List<Employee> Emplist = new List<Employee>();
        public DeleteEmployee(List<Employee> empList)
        {
            this.Emplist = empList;
        }
        public void deleteEmployeeDetails()
        {
            Console.WriteLine("Enter EmpId you want to delete");
            int y;
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Please Provide Valid Input");
            }
            Employee? DeleteIndex = Emplist.FirstOrDefault(e => e.EmpId == y);
            if (DeleteIndex != null)
            {
                Console.WriteLine("Are You Confirm  To Delete please enter yes for DeleteEmployee or no for cancel");
                string? conf = Console.ReadLine();
                if (conf != null)
                {
                    if (conf == "yes" || conf=="Yes" || conf=="YES" || conf=="yES" ||conf=="yeS" || conf=="YEs")
                    {
                        Emplist.Remove(DeleteIndex);
                        Console.WriteLine("Employee deleted successfully! \n");
                    }
                    else
                        Console.WriteLine("Employees are not Deleted\n");
                }
            }
            else
            {
                Console.WriteLine("Employee not found! List is already Empty please select 1 To add The Employee \n");
            }
        }
    }
}
