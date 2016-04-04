using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_Monitor.Domain.Interfaces
{
    public interface IDataManager : IDisposable
    {
        ITargetUserRepository TargetUsers { get; }
        ISubscriberRepository Subscribers { get; }

        void Save();
        void Dispose();
    }
}
