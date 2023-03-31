using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CreateEmployeeCrud
{
    internal class SendMailToEmployee
    {
        List<Employee> Emp = new List<Employee>();
        public SendMailToEmployee(List<Employee> empList)
        {
            this.Emp = empList;
        }
        public void sendMailEmp()
        {

            Console.WriteLine("Please enter Id of The Employee:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please Provide Valid Input");
            }
            Employee? sendMail = Emp.FirstOrDefault(e => e.EmpId == id);
            if (sendMail != null)
            {
                Console.WriteLine("please enter subject for the email");
                string? sub = Console.ReadLine();
                Console.WriteLine("Please enter body of the email");
                string ? body = Console.ReadLine();
                // Create a new thread to send the email
                Thread emailThread = new Thread(() =>
                {
                    // Create a new SmtpClient object
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("pawank.aspirefox@gmail.com", "eftxaasvaejrqyfw");

                    // Create a new MailMessage object
                    MailMessage message = new MailMessage("pawank.aspirefox@gmail.com",sendMail.Email, sub, body);

                    try
                    {
                        // Send the email
                        client.Send(message);
                        Console.WriteLine("Email sent successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error sending email: " + ex.Message);
                    }
                });

                // Start the email thread
                emailThread.Start();

                /*// Wait for the email thread to finish
                emailThread.Join();*/

                Console.ReadLine();

            }
            else
                Console.WriteLine("Employee not found at this location");
           
        }
    }
}
