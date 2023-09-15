using System;
using System.Net;
using System.Net.Mail;
using Abstract;

namespace Concrete
{
    public class EmailSender:IEmailSender
    {
        public Task SendEmailAsync(string subject, string message)
    {
        var client = new SmtpClient("smtp-mail.outlook.com", 587)
        {
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("youremail@hotmail.com", "password")
        };
 
        return client.SendMailAsync(
            new MailMessage(from: "youremail@hotmail.com",
                            to: "burhancavdaroglu70@gmail.com",
                            subject,
                            message
                            ));
    }

        
    }
}