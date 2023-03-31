using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CreateEmployeeCrud
{
    internal class BroadcastNotification
    {
        List<Employee> EmpList = new List<Employee>();
        Validation validate = new Validation();
        public BroadcastNotification(List<Employee> empList)
        {
            this.EmpList = empList;
        }
        public void broadcastNotificationMessage()
        {
            Console.WriteLine("Enter subject for broadcast");
            string ? subject =Console.ReadLine();
            subject = validate.checkName(subject);
            Console.WriteLine("Enter body of The Broadcast");
            string ? body = Console.ReadLine();
            foreach(Employee emp in EmpList)
            {
                Thread emailThread = new Thread(() =>
                {
                    // Create a new SmtpClient object
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("pawank.aspirefox@gmail.com", "eftxaasvaejrqyfw");

                    // Create a new MailMessage object
                    MailMessage message = new MailMessage("pawank.aspirefox@gmail.com", emp.Email, subject, body);
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

                // Wait for the email thread to finish
                emailThread.Join();
             
            }
          
        }
        }
 }

