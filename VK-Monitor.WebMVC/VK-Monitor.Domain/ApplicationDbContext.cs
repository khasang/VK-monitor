using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Entities;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.Domain
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public DbSet<TargetUser> TargetUsers { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Friend> Friends { get; set; }

        public IDbSet<ApplicationUser> GetUsers() { return base.Users; }
        public IDbSet<IdentityRole> GetRoles() { return base.Roles; } 
 
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public ApplicationDbContext(string connectionString)
            : base(connectionString, throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public void SaveChanges()
        {
            base.SaveChanges();
        }

        public void Dispose()
        {
            base.Dispose();
        }
    }
}
