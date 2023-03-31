namespace CreateEmployeeCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            bool y = true;
            while (y)
            {
                Console.WriteLine("1.Add an Employee");
                Console.WriteLine("2.List All Employee");
                Console.WriteLine("3.Edit Employee");
                Console.WriteLine("4.Delete Employee");
                Console.WriteLine("5.Send Mail To The Employee");
                Console.WriteLine("6.Broadcast Notification");
                Console.WriteLine("7.Export Data To Csv");
                Console.WriteLine("8.Quit Application\n");
                Console.WriteLine("Please select your choice");
                int x;
                while(!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Please Provide Valid Input");
                }
                switch (x)
                    {
                        case 1:
                        Console.Clear();
                            Console.WriteLine("Add an Employee");
                            AddEmployee emp1 = new AddEmployee();
                            emp1.addDetails(employees);
                            Console.WriteLine("\nPress Enter to get back to main menu");
                            Console.ReadLine();
                            Console.Clear();
                        break;
                        case 2:
                        Console.Clear();
                            Console.WriteLine("List All Employee");
                            ListAllEmployee l = new ListAllEmployee(employees);
                            l.ShowEmployee();
                            Console.WriteLine("\nPress Enter to get back to main menu");
                            Console.ReadLine();
                            Console.Clear();
                        break;
                        case 3:
                        Console.Clear();
                            Console.WriteLine("Edit Employee");
                            EditEmployee e = new EditEmployee(employees);
                        e.EditEmpDetails();
                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                        case 4:
                        Console.Clear();
                            Console.WriteLine("Delete Employee");
                            DeleteEmployee d = new DeleteEmployee(employees);
                            d.deleteEmployeeDetails();
                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                        case 5:
                        Console.Clear();
                            Console.WriteLine("Send Mail To The Employee");
                        ListAllEmployee l1 = new ListAllEmployee(employees);
                        l1.ShowEmployee();
                        SendMailToEmployee e1 = new SendMailToEmployee(employees);
                            e1.sendMailEmp();
                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                        case 6:
                        Console.Clear();
                            Console.WriteLine("Broadcast Notification");
                        BroadcastNotification b1 = new BroadcastNotification(employees);
                        b1.broadcastNotificationMessage();
                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                        case 7:
                        Console.Clear();
                            Console.WriteLine("Export Data To csv");
                        ExportDataTocsv save= new ExportDataTocsv(employees);
                        save.saveData();
                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                        case 8:
                            Console.WriteLine("Quit Application");
                            y = false;
                            break;
                        default:
                            Console.WriteLine("Please Enter a valid Choise");
                            break;
                    }
            }
        }
    
    }
}