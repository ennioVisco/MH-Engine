using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Services
{
    interface IPmSender
    {
        Task SendPmAsync(string username, string message);
    }
}
