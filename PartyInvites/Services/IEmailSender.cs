using System.Threading.Tasks;

namespace PartyInvites.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}