using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;

namespace Diamond.BusinessLogic.Services
{
    public class EmailService : IMailService
    {
        MailSettings mailSettings = null;
        public EmailService(IOptions<MailSettings> options)
        {
            mailSettings = options.Value;
        }
        public async Task SendEmailAsync(MessageDto message)
        {
            var emailMessage = CreateEmailMessage(message);
            Send(emailMessage);
        }
        private MimeMessage CreateEmailMessage(MessageDto message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("email", mailSettings.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            //emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };
            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = message.Content,
            };
            emailMessage.Body = bodyBuilder.ToMessageBody();

            return emailMessage;
        }
        private void Send(MimeMessage mailMessage)
        {
            using var client = new SmtpClient();
            try
            {
                client.Connect(mailSettings.SmtpServer, mailSettings.Port, true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(mailSettings.Username, mailSettings.Password);

                client.Send(mailMessage);
            }
            catch
            {
                //log an error message or throw an exception or both.
                throw;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }
    }
}
