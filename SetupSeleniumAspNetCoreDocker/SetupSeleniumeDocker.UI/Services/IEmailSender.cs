using System.Threading.Tasks;

namespace SetupSeleniumeDocker.UI.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}