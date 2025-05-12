using MimeKit;
using MailKit.Net.Smtp;
namespace MyMorApi.Common
{
    public class SendMail
    {
        public async static Task SendVerificationEmailAsync(string toEmail, string verificationCode)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("MyMor", "sandeepsharma553@gmail.com"));
            message.To.Add(new MailboxAddress("", toEmail));
            message.Subject = "Your Verification Code";

            message.Body = new TextPart("plain")
            {
                Text = $"Your verification code is: {verificationCode}"
            };

            using (var client = new SmtpClient())
            {
                // For demo, disable SSL validation (not recommended in production)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync("sandeepsharma553@gmail.com", "pvrf xity ruwp pqpl");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
