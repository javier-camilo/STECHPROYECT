using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace INFRAESTRUCTURA
{
    public class EnviarCorreo
    {
        public MailMessage ConfigurarCorreo(Email mail)
        {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(mail.Para));
            email.From = new MailAddress("schooltechproyect@gmail.com");
            email.Subject = mail.Asunto;
            email.Body = mail.Cuerpo;
            if (!mail.RutaArchivo.Equals(""))
            {
                Attachment _attachment = new Attachment(@mail.RutaArchivo);
                email.Attachments.Add(_attachment);
            }
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            return email;
        }
        public SmtpClient ConfigurarHostConGmail()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("schooltechproyect@gmail.com", "schooltech2019");
            return smtp;
        }
        public bool Enviar(Email mail)
        {
            try
            {
                MailMessage email = ConfigurarCorreo(mail);
                SmtpClient smtp = ConfigurarHostConGmail();
                smtp.Send(email);
                email.Dispose();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }
}
