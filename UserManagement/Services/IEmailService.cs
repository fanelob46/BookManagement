using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Services
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
