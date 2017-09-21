using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutNetCore.Version1_0.DefaultTemplate.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
