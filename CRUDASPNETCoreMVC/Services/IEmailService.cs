using Google.Apis.Auth.OAuth2;

namespace CRUDASPNETCoreMVC.Services
{
    public interface IEmailService
    {
        Task<UserCredential> AuthenticateAsync();
        Task SendEmailAsync(UserCredential credential, string from, string to, string subject, string body);
    }
}
