using System;

namespace Abstract
{
    public interface IEmailSender
    {
            Task SendEmailAsync(string subject, string message);

    }
}