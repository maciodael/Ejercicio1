using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace CapaLogica
{
    public class Email
    {
        MailMessage mail = new MailMessage();
        public bool enviar(string from, string to)
        {
            try
            {
                string subject = "solicitud de empleado";
                string body = "has recibido una solicitud";
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(to));
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false;
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new NetworkCredential(from, "eqopnyyfqowtubqt");
                client.EnableSsl = true;
                client.Send(mail);
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }
    }

  
}

