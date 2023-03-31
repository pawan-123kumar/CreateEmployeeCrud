using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEmployeeCrud
{
    internal class ExportDataTocsv
    {
         List<Employee> employeeList = new List<Employee>();
        public ExportDataTocsv(List<Employee> empList)
        {
            this.employeeList = empList;
        }
        public void saveData()
        {           
            string path = @"X:\CreateEmployeeCrud\CreateEmployeeCrud\New folderMyFile.csv";
           // string path = @"C:\\Users\\pawan kumar\\Documents\\C#sharp\\CreateEmployeeCrud\\CreateEmployeeCrud.csv";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Employee emp in employeeList)
                    {
                        sw.WriteLine("EmpId,Name,Department,Dob,Salary,Email,Hobbies\n");
                        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", emp.EmpId, emp.Name, emp.Department, emp.Dob, emp.Salary, emp.Email, emp.Hobbies + "\n");
                    }
                }
            }
            Console.WriteLine("Save File Successfully to : {0}\n", path);
        }
    }
}
