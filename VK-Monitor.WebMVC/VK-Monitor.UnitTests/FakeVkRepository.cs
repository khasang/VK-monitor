using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.UnitTests
{
    public class FakeVkRepository : IVkRepository
    {
        ulong applicationId;
        string adminId;
        string adminPassword;

        public void Authorize(ulong applicationId, string adminId, string adminPassword)
        {
            this.applicationId = applicationId;
            this.adminId = adminId;
            this.adminPassword = adminPassword;
        }


        public Dictionary<string, IList<string>> Users(ulong userId)
        {
            throw new NotImplementedException();
        }
    }
}
