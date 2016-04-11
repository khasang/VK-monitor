using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Entities;

namespace VK_Monitor.Domain.Interfaces
{
    public interface IDataManager : IDisposable
    {
        ITargetUserRepository TargetUsers { get; }
        ISubscriberRepository Subscribers { get; }
        IFriendRepository Friends { get; }
        IDbSet<ApplicationUser> Users { get; }
        IDbSet<IdentityRole> Roles { get; }

        void Save();
    }
}
