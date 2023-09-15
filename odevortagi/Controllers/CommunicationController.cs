using System;
using Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mono.TextTemplating;

namespace Controllers
{
    public class CommunicationController:Controller
    {
        private readonly IEmailSender _emailSender;
        public CommunicationController(IEmailSender emailSender)
        {
            this._emailSender = emailSender;
        }
        public async Task<IActionResult> IndexAsync(string name,string Eposta,string subject,string message){
            if (!string.IsNullOrEmpty(name)&&!string.IsNullOrEmpty(Eposta)&&!string.IsNullOrEmpty(subject)&&!string.IsNullOrEmpty(message))
            {
                string sum = name+" "+Eposta+" "+message; 
            await _emailSender.SendEmailAsync(subject,sum);
            return View();
            }
            return View();
        }
    }
}