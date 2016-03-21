using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_Monitor.Domain.Interfaces
{
    public interface IVkRepository
    {
        void Authorize(ulong applicationId, string adminId, string adminPassword);
    }
}
