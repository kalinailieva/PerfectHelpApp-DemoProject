﻿using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace PerfectHelp.Services
{
    //Due to security reasons the key has been removed. 
 //   public class EmailSender : IEmailSender
	//{
 //       public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
 //       {
 //           Options = optionsAccessor.Value;
 //       }

 //       public AuthMessageSenderOptions Options { get; } //set only via Secret Manager



 //       public Task SendEmailAsync(string email, string subject, string message)
 //       {
 //           return Execute(Options.SendGridKey, subject, message, email);
 //       }

 //       public async Task<Response> Execute(string apiKey, string subject, string message, string email)
 //       {
 //           var client = new SendGridClient(apiKey);
 //           var msg = new SendGridMessage()
 //           {
 //               From = new EmailAddress("sendgrid1@abv.bg", "Password Recovery"),
 //               Subject = subject,
 //               PlainTextContent = message,
 //               HtmlContent = message
 //           };
 //           msg.AddTo(new EmailAddress(email));

 //           msg.SetClickTracking(false, false);

 //           var response = await client.SendEmailAsync(msg);

 //           return response;
 //       }
 //   }
}
