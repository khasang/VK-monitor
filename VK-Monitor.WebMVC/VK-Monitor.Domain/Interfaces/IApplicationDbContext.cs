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
    public interface IApplicationDbContext
    {
        DbSet<TargetUser> TargetUsers { get; set; }
        DbSet<Subscriber> Subscribers { get; set; }

        IDbSet<ApplicationUser> GetUsers();
        IDbSet<IdentityRole> GetRoles();

        void SaveChanges();
        void Dispose();
    }
}
