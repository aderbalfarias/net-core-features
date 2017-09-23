using System.Threading.Tasks;

namespace AboutNetCore.Version1_0.DefaultTemplate.Services.Interfaces
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
