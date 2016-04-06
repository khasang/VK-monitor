using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.Domain.DBInitializers
{
    public interface IInitialization
    {
        void Initialization(ApplicationDbContext context);
    }
}
