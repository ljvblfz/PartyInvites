using System.Threading.Tasks;

namespace PartyInvites.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}