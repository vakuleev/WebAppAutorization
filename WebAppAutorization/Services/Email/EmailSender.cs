using Microsoft.AspNetCore.Identity.UI.Services;

namespace WebAppAutorization.Services.Email
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //TODO Создание емаил сервиса
            await Task.CompletedTask;
            //throw new NotImplementedException();
        }
    }
}
