using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace CRUDASPNETCoreMVC.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<UserCredential> AuthenticateAsync()
        {
            var clientId = _configuration["ClientId"];
            var clientSecret = _configuration["ClientSecret"];
            return await GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret
                },
                [GmailService.Scope.MailGoogleCom],
                "user",
                CancellationToken.None
            );
        }

        public async Task SendEmailAsync(UserCredential credential, string from, string to, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Email test", from));
            message.To.Add(new MailboxAddress("Email sent", to));
            message.Subject = subject;
            message.Body = new TextPart("plain")
            {
                Text = body
            };
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                var oauth2 = new SaslMechanismOAuth2(from, credential.Token.AccessToken);
                await client.AuthenticateAsync(oauth2);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
