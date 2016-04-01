using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain;
using VK_Monitor.Domain.Entities;

namespace VK_Monitor.Domain.DBInitializers
{
    class InitUserAdmin : InitializationAbstract
    {
        override public void Initialization(ApplicationDbContext context)
        {
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            ApplicationUser user = new ApplicationUser()
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                EmailConfirmed = true
            };
            
            IdentityRole role = new IdentityRole("Admin");

            userManager.Create(user, "password");
            roleManager.Create(role);
            userManager.AddToRole(user.Id, role.Name);
        }
    }
}
