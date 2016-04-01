using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain;

namespace VK_Monitor.Domain.DBInitializers
{
    abstract public class InitializationAbstract
    {
        public abstract void Initialization(ApplicationDbContext context);
    }
}
